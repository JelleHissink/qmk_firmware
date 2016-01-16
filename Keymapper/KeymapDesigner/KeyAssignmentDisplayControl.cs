using KeymapDesigner.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KeymapDesigner
{
    public class KeyAssignmentDisplayControl : Control
    {
        static KeyAssignmentDisplayControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KeyAssignmentDisplayControl), new FrameworkPropertyMetadata(typeof(KeyAssignmentDisplayControl)));
        }
        
        public KeyAssignment KeyAssignment
        {
            get { return (KeyAssignment)GetValue(KeyAssignmentProperty); }
            set { SetValue(KeyAssignmentProperty, value); }
        }

        public static readonly DependencyProperty KeyAssignmentProperty =
            DependencyProperty.Register("KeyAssignment", typeof(KeyAssignment), typeof(KeyAssignmentDisplayControl), new PropertyMetadata(null));
    }
}
