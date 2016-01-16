using KeymapDesigner.Model;
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

namespace KeymapDesigner
{
    /// <summary>
    /// Interaction logic for ActionEditorControl.xaml
    /// </summary>
    public partial class ActionEditorControl : UserControl
    {
        public ActionEditorControl()
        {
            InitializeComponent();
        }

        public KeyAssignment KeyAssignment
        {
            get { return (KeyAssignment)GetValue(KeyAssignmentProperty); }
            set { SetValue(KeyAssignmentProperty, value); }
        }

        public static readonly DependencyProperty KeyAssignmentProperty =
            DependencyProperty.Register("KeyAssignment", typeof(KeyAssignment), typeof(ActionEditorControl), new PropertyMetadata(null));

        private void keyControl_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var control = (KeyAssignmentDisplayControl)sender;
            KeyAssignment.Action = control.KeyAssignment.Action;
        }
    }
}
