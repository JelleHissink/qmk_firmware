using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KeymapDesigner.Model
{
    public class ApplicationModel : Observable
    {
        public ApplicationModel()
        {
            HIDListener.PropertyChanged += HIDListener_PropertyChanged;
        }

        private void HIDListener_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            var activeLayer = ActiveLayer;
            if (activeLayer != null)
            {
                activeLayer.ActiveLayersMask = HIDListener.ActiveLayersMask;
            }
        }

        public HIDListener HIDListener { get; } = new HIDListener();

        private KeymapDefinition _definition = new KeymapDefinition(new Ergodox());

        public KeymapDefinition Definition
        {
            get
            {
                return _definition;
            }
            set
            {
                if (SetValue(ref _definition, value, nameof(Definition)))
                {
                    ActiveLayer = new ActiveLayer(value);
                }
            }
        }

        private ActiveLayer _activeLayer;

        public ActiveLayer ActiveLayer
        {
            get
            {
                return _activeLayer;
            }
            set
            {
                if (SetValue(ref _activeLayer, value, nameof(ActiveLayer)))
                {
                    _activeLayer.ActiveLayersMask = HIDListener.ActiveLayersMask;
                }
            }
        }

        public void LoadKeymap(string fileName)
        {
            var doc = XDocument.Load(fileName);
            Definition = KeymapDefinition.FromXml(doc.Root);
        }

        public void SaveKeymap(string fileName)
        {
            var doc = new XDocument(
                Definition.ToXml("Definition"));
            doc.Save(fileName);
        }
    }
}
