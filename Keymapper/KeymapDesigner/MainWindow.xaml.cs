using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KeymapDesigner.Model;
using System.Xml.Linq;
using System.Configuration;
using System.IO;

namespace KeymapDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HelpOverlay _helpOverlay;
        private ApplicationModel _model = new ApplicationModel();

        private static class Settings
        {
            public static string KeymapXml =>
                ConfigurationManager.AppSettings["keymapxml"];

            public static bool SaveKeymapXml =>
                bool.Parse(ConfigurationManager.AppSettings["savekeymapxml"]);

            public static string WriteKeymapCCode =>
                ConfigurationManager.AppSettings["writeKeymapCCode"];
        }

        private void Reload()
        {
            if (_model.ActiveLayer != null)
            {
                _model.ActiveLayer.PropertyChanged -= ActiveLayer_PropertyChanged;
            }
            try
            {
                _model.LoadKeymap(Settings.KeymapXml);

                if (Settings.SaveKeymapXml)
                {
                    _model.SaveKeymap(Settings.KeymapXml);
                }
                if (!string.IsNullOrWhiteSpace(Settings.WriteKeymapCCode))
                {
                    var codeWriter = new WriteCCode();
                    codeWriter.Update(Settings.WriteKeymapCCode, _model.Definition);
                }
            }
            finally
            {

                if (_model.ActiveLayer != null)
                {
                    _model.ActiveLayer.PropertyChanged += ActiveLayer_PropertyChanged;
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            _helpOverlay = new HelpOverlay()
            {
                DataContext = _model
            };

            DataContext = _model;

            Reload();

            _model.HIDListener.Start();

            this.Closing += MainWindow_Closing;

            var fileWatcher = new FileSystemWatcher(System.IO.Path.GetDirectoryName(Settings.KeymapXml), System.IO.Path.GetFileName(Settings.KeymapXml));
            fileWatcher.Changed += FileWatcher_Changed;
            fileWatcher.EnableRaisingEvents = true;
        }

        private void FileWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            try
            {
                Reload();
            }
            catch
            {
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _model.HIDListener.Stop();
            _helpOverlay.Hide();
            _helpOverlay.Close();
        }

        private void ActiveLayer_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(_model.ActiveLayer.ShowHelpOverlay))
            {
                Dispatcher.InvokeAsync(() =>
                {
                    if (_model.ActiveLayer.ShowHelpOverlay)
                    {
                        _helpOverlay.Show();
                    }
                    else
                    {
                        _helpOverlay.Hide();
                    }
                });
            }
        }
    }
}
