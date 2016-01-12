using HidLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HidListenTest
{
    public class HIDListener
    {
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
            get;
            private set;
        }

        public ObservableCollection<int> ActiveLayers { get; } = new ObservableCollection<int>();

        private void Run()
        {
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
                    }
                }
                catch
                {
                }
            }
        }

        private readonly StringBuilder buffer = new StringBuilder();

        private void OnReport(HidDevice myDevice, HidReport report)
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

        private void ProcessLine(string line)
        {
            Console.WriteLine(line);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var listener = new HIDListener();
            listener.Start();
            Console.ReadLine();
            listener.Stop();

            return;

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

                // this is where we start listening for data
                myDevice.ReadReport(report => OnReport(myDevice, report));
            }
            while (true)
            {
            }

            Console.ReadLine();
            var devices2 = HidDevices.Enumerate()
                .ToList();
        }

        private static void OnReport(HidDevice myDevice, HidReport report)
        {
            //if (attached == false) { return; }

            // process your data here
            //Console.WriteLine(report.ReadStatus);
            var byteFromMyDevice = Encoding.ASCII.GetString(report.GetBytes());
            Console.WriteLine(byteFromMyDevice);// ;.Data[0];

            // we need to start listening again for more data
            myDevice.ReadReport(x => OnReport(myDevice, x));
        }
    }
}
