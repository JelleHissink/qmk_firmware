using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace KeymapDesigner
{
    public class ActiveLayerControl : ItemsControl
    {
        static ActiveLayerControl()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ActiveLayerControl), new FrameworkPropertyMetadata(typeof(ActiveLayerControl)));
        }
    }
}
