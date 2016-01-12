using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Xml.Linq;

namespace KeymapDesigner.Model
{
    public class Layer : Observable
    {
        public Keyboard Keyboard { get; }

        public string Name { get; }

        public KeyAssignment[] Assignments { get; }

        public Layer(Keyboard keyboard, Color color, Color textColor, string name, bool showhelpoverlay)
        {
            Keyboard = keyboard;
            Name = name;
            _color = color;
            _textColor = textColor;
            _showHelpOverlay = showhelpoverlay;
            Assignments = keyboard.PhysicalKeys
                .Select(pk => new KeyAssignment(new TransparentAction(), pk, this))
                .ToArray();
        }

        private bool _showHelpOverlay = false;

        public bool ShowHelpOverlay
        {
            get
            {
                return _showHelpOverlay;
            }
            set
            {
                SetValue(ref _showHelpOverlay, value, nameof(ShowHelpOverlay));
            }
        }

        private Color _color;

        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                SetValue(ref _color, value, nameof(Color));
            }
        }

        private Color _textColor;

        public Color TextColor
        {
            get
            {
                return _textColor;
            }
            set
            {
                SetValue(ref _textColor, value, nameof(TextColor));
            }
        }

        public KeyAssignment Get(PhysicalKey key) =>
            Assignments.Single(x => x.Key == key);

        public Action this[PhysicalKey key]
        {
            get
            {
                return Get(key).Action;
            }
            set
            {
                Get(key).Action = value;
            }
        }

        private static Color ParseColor(string text)
        {
            return (Color)ColorConverter.ConvertFromString(text);
        }

        public static Layer FromXml(Keyboard keyboard, XElement element)
        {
            var name = (string)element.Attribute("name");
            var color = ParseColor((string)element.Attribute("color"));
            var textColor = ParseColor((string)element.Attribute("textcolor"));
            var showhelpoverlay = (bool)element.Attribute("showhelpoverlay");
            var result = new Layer(keyboard, color, textColor, name, showhelpoverlay);
            var assignments = element
                .Elements("Key")
                .Select(Action.FromXml)
                .ToList();
            for (int i = 0; i < assignments.Count; i++)
            {
                result[keyboard.PhysicalKeys[i]] = assignments[i];
            }
            return result;
        }

        public XElement ToXml(XName name)
        {
            return new XElement(name,
                new XAttribute("name", Name),
                new XAttribute("color", Color.ToString()),
                new XAttribute("textcolor", TextColor.ToString()),
                new XAttribute("showhelpoverlay", ShowHelpOverlay),
                Assignments
                    .Select(a => a.Action)
                    .Select(a => a.ToXml("Key")));
        }
    }
}
