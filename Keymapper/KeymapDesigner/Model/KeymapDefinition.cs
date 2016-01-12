using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace KeymapDesigner.Model
{
    public class KeymapDefinition
    {
        public Keyboard Keyboard { get; }

        public KeymapDefinition(Keyboard keyboard)
        {
            Keyboard = keyboard;
        }

        public ObservableCollection<Layer> Layers { get; } = new ObservableCollection<Layer>();

        public Layer AddLayer(string name)
        {
            var result = new Layer(Keyboard, Colors.Beige, Colors.Black, name, showhelpoverlay: Layers.Any());
            Layers.Add(result);
            return result;
        }

        public static KeymapDefinition FromXml(XElement element)
        {
            var keyboard = Keyboard.FromXml(element.Element("Keyboard"));
            var result = new KeymapDefinition(keyboard);
            foreach (var layer in element
                .Elements("Layer")
                .Select(e => Layer.FromXml(keyboard, e)))
            {
                result.Layers.Add(layer);
            }
            return result;
        }

        public XElement ToXml(XName name)
        {
            return new XElement(name,
                Keyboard.ToXml("Keyboard"),
                Layers
                    .Select(a => a.ToXml("Layer")));
        }
    }
}
