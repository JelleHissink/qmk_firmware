using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public class ActionCategory
    {
        private ActionCategory(string label)
        {
            Label = label;
        }

        public string Label { get; }

        public override string ToString()
            => Label;

        public static readonly ActionCategory System = new ActionCategory("System");
        public static readonly ActionCategory Alphabet = new ActionCategory("Alphabet");
        public static readonly ActionCategory Numeric = new ActionCategory("Numeric");
        public static readonly ActionCategory Numpad = new ActionCategory("Numpad");
        public static readonly ActionCategory Symbols = new ActionCategory("Symbols");
        public static readonly ActionCategory FunctionKeys = new ActionCategory("FunctionKeys");
        public static readonly ActionCategory Navigation = new ActionCategory("Navigation");
        public static readonly ActionCategory Spacing = new ActionCategory("Spacing");
        public static readonly ActionCategory Modifiers = new ActionCategory("Modifiers");
        public static readonly ActionCategory SystemControl = new ActionCategory("SystemControl");
        public static readonly ActionCategory Media = new ActionCategory("Media");
        public static readonly ActionCategory Mouse = new ActionCategory("Mouse");
        public static readonly ActionCategory Layers = new ActionCategory("Layers");
        public static readonly ActionCategory Other = new ActionCategory("Other");
    }
}
