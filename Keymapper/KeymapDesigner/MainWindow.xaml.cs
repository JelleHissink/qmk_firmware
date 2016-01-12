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

namespace KeymapDesigner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private HelpOverlay _helpOverlay;
        private ApplicationModel _model = new ApplicationModel();

        public MainWindow()
        {
            var keymapXml = ConfigurationManager.AppSettings["keymapxml"];
            var saveKeymapXml = bool.Parse(ConfigurationManager.AppSettings["savekeymapxml"]);

            InitializeComponent();

            _helpOverlay = new HelpOverlay()
            {
                DataContext = _model
            };

            DataContext = _model;

            _model.HIDListener.Start();

            _model.LoadKeymap(keymapXml);

            if (saveKeymapXml)
            {
                _model.SaveKeymap(keymapXml);
            }

            _model.ActiveLayer.PropertyChanged += ActiveLayer_PropertyChanged;
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
