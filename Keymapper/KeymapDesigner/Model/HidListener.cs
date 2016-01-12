using HidLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class HIDListener : Observable
    {
        private bool _connected = false;
        private Thread thread;
        private readonly ManualResetEvent stopTrigger = new ManualResetEvent(false);

        public void Start()
        {
            stopTrigger.Reset();
            thread = new Thread(Run);
            thread.IsBackground = true;
            thread.Start();
        }

        public void Stop()
        {
            stopTrigger.Set();
            if (thread != null)
            {
                thread.Join();
            }
        }

        public bool Connected
        {
            get
            {
                return _connected;
            }
            private set
            {
                SetValue(ref _connected, value, nameof(Connected));
            }
        }

        private int _activeLayersMask = 0;

        public int ActiveLayersMask
        {
            get
            {
                return _activeLayersMask;
            }
            set
            {
                SetValue(ref _activeLayersMask, value, nameof(ActiveLayersMask));
            }
        }


        private void Disconnected()
        {
            Connected = false;
            ActiveLayersMask = 0;
        }

        private void Run()
        {
            Disconnected();
            while (true)
            {
                if (stopTrigger.WaitOne(1000))
                {
                    break;
                }
                try
                {
                    var devices = HidDevices.Enumerate(0xFEED, 0x1307)
                        .ToList();
                    var myDevice = devices
                        .FirstOrDefault(x =>
                            (ushort)x.Capabilities.UsagePage == 0xFF31 &&
                            x.Capabilities.Usage == 0x0074);
                    //.ElementAt(1);//.FirstOrDefault(x => x.Description == "HID-compliant vendor-defined device");

                    if (myDevice != null)
                    {
                        myDevice.OpenDevice();

                        // myDevice.inserted += deviceattachedhandler;
                        // myDevice.removed += deviceremovedhandler;

                        myDevice.MonitorDeviceEvents = true;

                        buffer.Clear();

                        // this is where we start listening for data
                        myDevice.ReadReport(report => OnReport(myDevice, report));

                        while (myDevice.IsConnected)
                        {
                            if (stopTrigger.WaitOne(1000))
                            {
                                myDevice.MonitorDeviceEvents = false;
                                break;
                            }
                        }
                        Disconnected();
                    }
                }
                catch
                {
                    Disconnected();
                }
            }
            Disconnected();
        }

        private readonly StringBuilder buffer = new StringBuilder();

        private void OnReport(HidDevice myDevice, HidReport report)
        {
            if (myDevice.IsConnected)
            {
                foreach (var b in report.GetBytes())
                {
                    if (b == 0 || b == 10 || b == 13)
                    {
                        if (buffer.Length > 0)
                        {
                            var process = buffer.ToString();
                            buffer.Clear();
                            ProcessLine(process);
                        }
                    }
                    else if (buffer.Length < 1000)
                    {
                        buffer.Append((char)b);
                    }
                }

                // we need to start listening again for more data
                myDevice.ReadReport(x => OnReport(myDevice, x));
            }
        }

        private void ProcessLine(string line)
        {
            if (line.StartsWith("layer_state: "))
            {
                int code;
                if (int.TryParse(line.Substring(13), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out code))
                {
                    ActiveLayersMask = code | 1;
                    Connected = true;
                }
            }
        }
    }
}
