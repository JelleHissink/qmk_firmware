using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Linq;

namespace KeymapDesigner.Model
{
    public abstract class Action
    {
        public abstract ActionCategory Category { get; }
        public abstract string Label { get; }
        public abstract string ShiftLabel { get; }
        public virtual string AltLabel => "";
        public virtual string AltShiftLabel => "";
        public abstract string CCode { get; }
        public virtual string XmlValue => CCode;

        public abstract Key Key { get; }
        public abstract ModifierKeys Modifiers { get; }

        public static Action FromXml(XElement element)
        {
            string value = element.Value;
            return Parse(value);
        }

        public XElement ToXml(XName name)
        {
            return new XElement(name,
                XmlValue);
        }

        private static readonly Dictionary<string, string> alternatives = new[]
        {
            new { Short ="KC_LCTL", Long ="KC_LCTRL" },
            new { Short ="KC_RCTL", Long ="KC_RCTRL" },
            new { Short ="KC_LSFT", Long ="KC_LSHIFT" },
            new { Short ="KC_RSFT", Long ="KC_RSHIFT" },
            new { Short ="KC_ESC", Long ="KC_ESCAPE" },
            new { Short ="KC_BSPC", Long ="KC_BSPACE" },
            new { Short ="KC_ENT", Long ="KC_ENTER" },
            new { Short ="KC_DEL", Long ="KC_DELETE" },
            new { Short ="KC_INS", Long ="KC_INSERT" },
            new { Short ="KC_CAPS", Long ="KC_CAPSLOCK" },
            new { Short ="KC_CLCK", Long ="KC_CAPSLOCK" },
            new { Short ="KC_RGHT", Long ="KC_RIGHT" },
            new { Short ="KC_PGDN", Long ="KC_PGDOWN" },
            new { Short ="KC_PSCR", Long ="KC_PSCREEN" },
            new { Short ="KC_SLCK", Long ="KC_SCROLLLOCK" },
            new { Short ="KC_PAUS", Long ="KC_PAUSE" },
            new { Short ="KC_BRK", Long ="KC_PAUSE" },
            new { Short ="KC_NLCK", Long ="KC_NUMLOCK" },
            new { Short ="KC_SPC", Long ="KC_SPACE" },
            new { Short ="KC_MINS", Long ="KC_MINUS" },
            new { Short ="KC_EQL", Long ="KC_EQUAL" },
            new { Short ="KC_GRV", Long ="KC_GRAVE" },
            new { Short ="KC_RBRC", Long ="KC_RBRACKET" },
            new { Short ="KC_LBRC", Long ="KC_LBRACKET" },
            new { Short ="KC_COMM", Long ="KC_COMMA" },
            new { Short ="KC_BSLS", Long ="KC_BSLASH" },
            new { Short ="KC_SLSH", Long ="KC_SLASH" },
            new { Short ="KC_SCLN", Long ="KC_SCOLON" },
            new { Short ="KC_QUOT", Long ="KC_QUOTE" },
            new { Short ="KC_APP", Long ="KC_APPLICATION" },
            new { Short ="KC_NUHS", Long ="KC_NONUS_HASH" },
            new { Short ="KC_NUBS", Long ="KC_NONUS_BSLASH" },
            new { Short ="KC_LCAP", Long ="KC_LOCKING_CAPS" },
            new { Short ="KC_LNUM", Long ="KC_LOCKING_NUM" },
            new { Short ="KC_LSCR", Long ="KC_LOCKING_SCROLL" },
            new { Short ="KC_ERAS", Long ="KC_ALT_ERASE," },
            new { Short ="KC_CLR", Long ="KC_CLEAR" },
            new { Short ="KC_ZKHK", Long ="KC_GRAVE" },
            new { Short ="KC_RO", Long ="KC_INT1" },
            new { Short ="KC_KANA", Long ="KC_INT2" },
            new { Short ="KC_JYEN", Long ="KC_INT3" },
            new { Short ="KC_HENK", Long ="KC_INT4" },
            new { Short ="KC_MHEN", Long ="KC_INT5" },
            new { Short ="KC_P1", Long ="KC_KP_1" },
            new { Short ="KC_P2", Long ="KC_KP_2" },
            new { Short ="KC_P3", Long ="KC_KP_3" },
            new { Short ="KC_P4", Long ="KC_KP_4" },
            new { Short ="KC_P5", Long ="KC_KP_5" },
            new { Short ="KC_P6", Long ="KC_KP_6" },
            new { Short ="KC_P7", Long ="KC_KP_7" },
            new { Short ="KC_P8", Long ="KC_KP_8" },
            new { Short ="KC_P9", Long ="KC_KP_9" },
            new { Short ="KC_P0", Long ="KC_KP_0" },
            new { Short ="KC_PDOT", Long ="KC_KP_DOT" },
            new { Short ="KC_PCMM", Long ="KC_KP_COMMA" },
            new { Short ="KC_PSLS", Long ="KC_KP_SLASH" },
            new { Short ="KC_PAST", Long ="KC_KP_ASTERISK" },
            new { Short ="KC_PMNS", Long ="KC_KP_MINUS" },
            new { Short ="KC_PPLS", Long ="KC_KP_PLUS" },
            new { Short ="KC_PEQL", Long ="KC_KP_EQUAL" },
            new { Short ="KC_PENT", Long ="KC_KP_ENTER" },
            new { Short ="KC_MS_U", Long ="KC_MS_UP" },
            new { Short ="KC_MS_D", Long ="KC_MS_DOWN" },
            new { Short ="KC_MS_L", Long ="KC_MS_LEFT" },
            new { Short ="KC_MS_R", Long ="KC_MS_RIGHT" },
            new { Short ="KC_BTN1", Long ="KC_MS_BTN1" },
            new { Short ="KC_BTN2", Long ="KC_MS_BTN2" },
            new { Short ="KC_BTN3", Long ="KC_MS_BTN3" },
            new { Short ="KC_BTN4", Long ="KC_MS_BTN4" },
            new { Short ="KC_BTN5", Long ="KC_MS_BTN5" },
            new { Short ="KC_WH_U", Long ="KC_MS_WH_UP" },
            new { Short ="KC_WH_D", Long ="KC_MS_WH_DOWN" },
            new { Short ="KC_WH_L", Long ="KC_MS_WH_LEFT" },
            new { Short ="KC_WH_R", Long ="KC_MS_WH_RIGHT" },
            new { Short ="KC_ACL0", Long ="KC_MS_ACCEL0" },
            new { Short ="KC_ACL1", Long ="KC_MS_ACCEL1" },
            new { Short ="KC_ACL2", Long ="KC_MS_ACCEL2" },
            new { Short ="KC_PWR", Long ="KC_SYSTEM_POWER" },
            new { Short ="KC_SLEP", Long ="KC_SYSTEM_SLEEP" },
            new { Short ="KC_WAKE", Long ="KC_SYSTEM_WAKE" },
            new { Short ="KC_MUTE", Long ="KC_AUDIO_MUTE" },
            new { Short ="KC_VOLU", Long ="KC_AUDIO_VOL_UP" },
            new { Short ="KC_VOLD", Long ="KC_AUDIO_VOL_DOWN" },
            new { Short ="KC_MNXT", Long ="KC_MEDIA_NEXT_TRACK" },
            new { Short ="KC_MPRV", Long ="KC_MEDIA_PREV_TRACK" },
            new { Short ="KC_MFFD", Long ="KC_MEDIA_FAST_FORWARD" },
            new { Short ="KC_MRWD", Long ="KC_MEDIA_REWIND" },
            new { Short ="KC_MSTP", Long ="KC_MEDIA_STOP" },
            new { Short ="KC_MPLY", Long ="KC_MEDIA_PLAY_PAUSE" },
            new { Short ="KC_MSEL", Long ="KC_MEDIA_SELECT" },
            new { Short ="KC_EJCT", Long ="KC_MEDIA_EJECT" },
            new { Short ="KC_MAIL", Long ="KC_MAIL" },
            new { Short ="KC_CALC", Long ="KC_CALCULATOR" },
            new { Short ="KC_MYCM", Long ="KC_MY_COMPUTER" },
            new { Short ="KC_WSCH", Long ="KC_WWW_SEARCH" },
            new { Short ="KC_WHOM", Long ="KC_WWW_HOME" },
            new { Short ="KC_WBAK", Long ="KC_WWW_BACK" },
            new { Short ="KC_WFWD", Long ="KC_WWW_FORWARD" },
            new { Short ="KC_WSTP", Long ="KC_WWW_STOP" },
            new { Short ="KC_WREF", Long ="KC_WWW_REFRESH" },
            new { Short ="KC_WFAV", Long ="KC_WWW_FAVORITES" },
            new { Short ="KC_BTLD", Long ="KC_BOOTLOADER" },
            new { Short ="KC_TRNS", Long ="KC_TRANSPARENT" },
            new { Short ="MEH_T(KC_NO)", Long ="KC_MEH" },
            new { Short ="ALL_T(KC_NO)", Long ="KC_HYPR" },
            new { Short ="KC_DELT", Long ="KC_DELETE"},
            new { Short ="KC_COLN", Long="KC_COLON" },
            new { Short ="KC_RCBR", Long="KC_RIGHT_CURLY_BRACE" },
            new { Short ="KC_LCBR", Long="KC_LEFT_CURLY_BRACE" },
            new { Short ="KC_UNDS", Long="KC_UNDERSCORE" },
            new { Short ="KC_RPRN", Long="KC_RIGHT_PAREN" },
            new { Short ="KC_LPRN", Long="KC_LEFT_PAREN" },
            new { Short ="KC_ASTR", Long="KC_ASTERISK" },
            new { Short ="KC_AMPR", Long="KC_AMPERSAND" },
            new { Short ="KC_CIRC", Long="KC_CIRCUMFLEX" },
            new { Short ="KC_PERC", Long="KC_PERCENT" },
            new { Short ="KC_DLR", Long="KC_DOLLAR" },
            new { Short ="KC_EXLM", Long="KC_EXCLAIM" },
            new { Short ="KC_TILD", Long="KC_TILDE" },
        }
        .ToDictionary(x => x.Short, x => x.Long);

        public static Action TryParse(string value)
        {
            var result = Actions.All
                .SingleOrDefault(x => x.XmlValue == value);
            if (result != null)
            {
                return result;
            }
            string alternative;
            if (alternatives.TryGetValue(value, out alternative))
            {
                return TryParse(alternative);
            }

            var functionMatch = Regex.Match(value, @"^\s*(?<fn>[A-Z_]*)\s*\((?<args>.*)\s*\)\s*$");
            if (functionMatch.Success) {
                var function = functionMatch.Result("${fn}");
                var args = functionMatch.Result("${args}")
                    .Split(',')
                    .Select(x => x.Trim())
                    .ToArray();

                switch (function)
                {
                    case "MO":
                        return new MomentaryLayer(int.Parse(args.Single()));
                    case "DF":
                        return new DefaultLayer(int.Parse(args.Single()));
                    case "TG":
                        return new ToggleLayer(int.Parse(args.Single()));
                    case "CTL_T":
                        return new ControlOrAction(Action.Parse(args.Single()));
                    case "ALT_T":
                        return new AltOrAction(Action.Parse(args.Single()));
                    case "S":
                    case "SFT_T":
                        return new ShiftOrAction(Action.Parse(args.Single()));
                    case "C_S_T":
                        return new ControlShiftOrAction(Action.Parse(args.Single()));
                    case "LT":
                        return new LayerOrAction(int.Parse(args.First()), Action.Parse(args.Skip(1).Single()));
                    case "LALT":
                        return new AltAndAction(Action.Parse(args.Single()));
                    case "LCTL":
                        return new ControlAndAction(Action.Parse(args.Single()));
                }
            }
            return null;
        }

        public static Action Parse(string value)
        {
            var result = TryParse(value);
            if (result == null)
            {
                throw new InvalidOperationException($"Unknown action {value}");
            }
            return result;
        }
    }
}
