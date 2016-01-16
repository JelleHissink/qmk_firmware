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
    public class KeyAssignmentEditorControl : Control
    {
        static KeyAssignmentEditorControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(KeyAssignmentEditorControl), new FrameworkPropertyMetadata(typeof(KeyAssignmentEditorControl)));
            IsHitTestVisibleProperty.OverrideMetadata(typeof(KeyAssignmentEditorControl), new FrameworkPropertyMetadata(true));
            FocusableProperty.OverrideMetadata(typeof(KeyAssignmentEditorControl), new FrameworkPropertyMetadata(true));
        }

        public KeyAssignmentEditorControl()
        {
            PreviewKeyDown += KeyAssignmentEditorControl_PreviewKeyDown;
            MouseRightButtonDown += KeyAssignmentEditorControl_MouseRightButtonDown;
            KeyDown += KeyAssignmentEditorControl_KeyDown;
            MouseDown += KeyAssignmentEditorControl_MouseDown;
        }

        private void KeyAssignmentEditorControl_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (KeyAssignment != null)
            {
                var window = new AssignKeyWindow(KeyAssignment);
                window.ShowDialog();
            }
        }

        private void KeyAssignmentEditorControl_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (Focusable)
            {
                this.Focus();
                e.Handled = true;
            }
        }

        private void KeyAssignmentEditorControl_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (Focusable)
            {
                Assign(e);
                e.Handled = true;
            }
        }

        private void KeyAssignmentEditorControl_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (Focusable)
            {
                Assign(e);
                e.Handled = true;

                // Application.Current.MainWindow.Title = e.Key.ToString();
            }
        }

        private bool Assign(KeyEventArgs e)
        {
            var modifiers = System.Windows.Input.Keyboard.Modifiers;
            var foundAction = Actions.All
                .Where(a =>
                    e.Key == a.Key &&
                    modifiers == a.Modifiers)
                .ToList();

            if (foundAction.Count == 1 && KeyAssignment != null)
            {
                e.Handled = true;
                KeyAssignment.Action = foundAction.Single();
                return true;
            }
            else
            {
                return false;
            }
        }
        
        public KeyAssignment KeyAssignment
        {
            get { return (KeyAssignment)GetValue(KeyAssignmentProperty); }
            set { SetValue(KeyAssignmentProperty, value); }
        }

        public static readonly DependencyProperty KeyAssignmentProperty =
            DependencyProperty.Register("KeyAssignment", typeof(KeyAssignment), typeof(KeyAssignmentEditorControl), new PropertyMetadata(null));
    }
}
