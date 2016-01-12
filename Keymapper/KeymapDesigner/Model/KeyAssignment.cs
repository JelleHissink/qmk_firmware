using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KeymapDesigner.Model
{
    public class KeyAssignment : Observable
    {
        private Action _action;
        private Layer _layer;

        public KeyAssignment(Action action, PhysicalKey key, Layer layer)
        {
            _action = action;
            _layer = layer;
            Key = key;
        }

        public Action Action
        {
            get
            {
                return _action;
            }
            set
            {
                SetValue(ref _action, value, nameof(Action));
            }
        }

        public PhysicalKey Key { get; }

        public Layer Layer
        {
            get
            {
                return _layer;
            }
            set
            {
                SetValue(ref _layer, value, nameof(Layer));
            }
        }
    }
}
