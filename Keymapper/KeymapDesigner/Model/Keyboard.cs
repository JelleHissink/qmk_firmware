using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace KeymapDesigner.Model
{
    public abstract class Keyboard
    {
        protected Keyboard(params PhysicalKey[] physicalKeys)
        {
            PhysicalKeys = physicalKeys;
        }

        public PhysicalKey[] PhysicalKeys { get; }

        protected static PhysicalKey Key(double x, double y, double w = 1.0, double h = 1.0, double r = 0.0)
        {
            return new PhysicalKey(left: x, top: y, width: w, height: h, rotation: r);
        }

        public string Name => GetType().Name;

        public static Keyboard GetByName(string name)
        {
            switch (name)
            {
                case nameof(Ergodox):
                    return new Ergodox();
                default:
                    throw new InvalidOperationException($"Unknown keyboard {name}");
            }
        }

        public static Keyboard FromXml(XElement element)
        {
            var type = (string)element.Attribute("type");
            return GetByName(type);
        }

        public XElement ToXml(XName name)
        {
            return new XElement(name,
                new XAttribute("type", Name));
        }
    }
}
