using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeymapDesigner.Model
{
    public static class Actions
    {
        public static readonly TransparentAction Transparent = new TransparentAction();
        public static readonly NoAction No = new NoAction();

        public static readonly KeyAction KC_A = new KeyAction(ActionCategory.Alphabet, "KC_A", "A");
        public static readonly KeyAction KC_B = new KeyAction(ActionCategory.Alphabet, "KC_B", "B");
        public static readonly KeyAction KC_C = new KeyAction(ActionCategory.Alphabet, "KC_C", "C");
        public static readonly KeyAction KC_D = new KeyAction(ActionCategory.Alphabet, "KC_D", "D");
        public static readonly KeyAction KC_E = new KeyAction(ActionCategory.Alphabet, "KC_E", "E");
        public static readonly KeyAction KC_F = new KeyAction(ActionCategory.Alphabet, "KC_F", "F");
        public static readonly KeyAction KC_G = new KeyAction(ActionCategory.Alphabet, "KC_G", "G");
        public static readonly KeyAction KC_H = new KeyAction(ActionCategory.Alphabet, "KC_H", "H");
        public static readonly KeyAction KC_I = new KeyAction(ActionCategory.Alphabet, "KC_I", "I");
        public static readonly KeyAction KC_J = new KeyAction(ActionCategory.Alphabet, "KC_J", "J");
        public static readonly KeyAction KC_K = new KeyAction(ActionCategory.Alphabet, "KC_K", "K");
        public static readonly KeyAction KC_L = new KeyAction(ActionCategory.Alphabet, "KC_L", "L");
        public static readonly KeyAction KC_M = new KeyAction(ActionCategory.Alphabet, "KC_M", "M");
        public static readonly KeyAction KC_N = new KeyAction(ActionCategory.Alphabet, "KC_N", "N");
        public static readonly KeyAction KC_O = new KeyAction(ActionCategory.Alphabet, "KC_O", "O");
        public static readonly KeyAction KC_P = new KeyAction(ActionCategory.Alphabet, "KC_P", "P");
        public static readonly KeyAction KC_Q = new KeyAction(ActionCategory.Alphabet, "KC_Q", "Q");
        public static readonly KeyAction KC_R = new KeyAction(ActionCategory.Alphabet, "KC_R", "R");
        public static readonly KeyAction KC_S = new KeyAction(ActionCategory.Alphabet, "KC_S", "S");
        public static readonly KeyAction KC_T = new KeyAction(ActionCategory.Alphabet, "KC_T", "T");
        public static readonly KeyAction KC_U = new KeyAction(ActionCategory.Alphabet, "KC_U", "U");
        public static readonly KeyAction KC_V = new KeyAction(ActionCategory.Alphabet, "KC_V", "V");
        public static readonly KeyAction KC_W = new KeyAction(ActionCategory.Alphabet, "KC_W", "W");
        public static readonly KeyAction KC_X = new KeyAction(ActionCategory.Alphabet, "KC_X", "X");
        public static readonly KeyAction KC_Y = new KeyAction(ActionCategory.Alphabet, "KC_Y", "Y");
        public static readonly KeyAction KC_Z = new KeyAction(ActionCategory.Alphabet, "KC_Z", "Z");
        public static readonly KeyAction KC_0 = new KeyAction(ActionCategory.Numeric, "KC_0", "0", ")");
        public static readonly KeyAction KC_1 = new KeyAction(ActionCategory.Numeric, "KC_1", "1", "!");
        public static readonly KeyAction KC_2 = new KeyAction(ActionCategory.Numeric, "KC_2", "2", "@");
        public static readonly KeyAction KC_3 = new KeyAction(ActionCategory.Numeric, "KC_3", "3", "#");
        public static readonly KeyAction KC_4 = new KeyAction(ActionCategory.Numeric, "KC_4", "4", "$");
        public static readonly KeyAction KC_5 = new KeyAction(ActionCategory.Numeric, "KC_5", "5", "%");
        public static readonly KeyAction KC_6 = new KeyAction(ActionCategory.Numeric, "KC_6", "6", "^");
        public static readonly KeyAction KC_7 = new KeyAction(ActionCategory.Numeric, "KC_7", "7", "&");
        public static readonly KeyAction KC_8 = new KeyAction(ActionCategory.Numeric, "KC_8", "8", "*");
        public static readonly KeyAction KC_9 = new KeyAction(ActionCategory.Numeric, "KC_9", "9", "(");

        public static readonly KeyAction KC_ENTER = new KeyAction(ActionCategory.Other, "KC_ENTER", "ENTER");
        public static readonly KeyAction KC_ESCAPE = new KeyAction(ActionCategory.Other, "KC_ESCAPE", "ESC");
        public static readonly KeyAction KC_BSPACE = new KeyAction(ActionCategory.Spacing, "KC_BSPACE", "BSPACE");
        public static readonly KeyAction KC_TAB = new KeyAction(ActionCategory.Spacing, "KC_TAB", "TAB");
        public static readonly KeyAction KC_SPACE = new KeyAction(ActionCategory.Spacing, "KC_SPACE", "SPACE");
        public static readonly KeyAction KC_MINUS = new KeyAction(ActionCategory.Symbols, "KC_MINUS", "-");
        public static readonly KeyAction KC_EQUAL = new KeyAction(ActionCategory.Symbols, "KC_EQUAL", "=");
        public static readonly KeyAction KC_LBRACKET = new KeyAction(ActionCategory.Symbols, "KC_LBRACKET", "[");
        public static readonly KeyAction KC_RBRACKET = new KeyAction(ActionCategory.Symbols, "KC_RBRACKET", "]");
        public static readonly KeyAction KC_BSLASH = new KeyAction(ActionCategory.Symbols, "KC_BSLASH", "\\", "|");
        public static readonly KeyAction KC_NONUS_HASH = new KeyAction(ActionCategory.Symbols, "KC_NONUS_HASH", "#", "~");
        public static readonly KeyAction KC_SCOLON = new KeyAction(ActionCategory.Symbols, "KC_SCOLON", ";", ":");
        public static readonly KeyAction KC_QUOTE = new KeyAction(ActionCategory.Symbols, "KC_QUOTE", "'", "\"");
        public static readonly KeyAction KC_GRAVE = new KeyAction(ActionCategory.Symbols, "KC_GRAVE", "`", "~");
        public static readonly KeyAction KC_COMMA = new KeyAction(ActionCategory.Symbols, "KC_COMMA", ",", "<");
        public static readonly KeyAction KC_DOT = new KeyAction(ActionCategory.Symbols, "KC_DOT", ".", ">");
        public static readonly KeyAction KC_SLASH = new KeyAction(ActionCategory.Symbols, "KC_SLASH", "/", "?");
        public static readonly KeyAction KC_CAPSLOCK = new KeyAction(ActionCategory.Modifiers, "KC_CAPSLOCK", "CAPSLOCK");

        public static readonly KeyAction KC_F1 = new KeyAction(ActionCategory.FunctionKeys, "KC_F1", "F1");
        public static readonly KeyAction KC_F2 = new KeyAction(ActionCategory.FunctionKeys, "KC_F2", "F2");
        public static readonly KeyAction KC_F3 = new KeyAction(ActionCategory.FunctionKeys, "KC_F3", "F3");
        public static readonly KeyAction KC_F4 = new KeyAction(ActionCategory.FunctionKeys, "KC_F4", "F4");
        public static readonly KeyAction KC_F5 = new KeyAction(ActionCategory.FunctionKeys, "KC_F5", "F5");
        public static readonly KeyAction KC_F6 = new KeyAction(ActionCategory.FunctionKeys, "KC_F6", "F6");
        public static readonly KeyAction KC_F7 = new KeyAction(ActionCategory.FunctionKeys, "KC_F7", "F7");
        public static readonly KeyAction KC_F8 = new KeyAction(ActionCategory.FunctionKeys, "KC_F8", "F8");
        public static readonly KeyAction KC_F9 = new KeyAction(ActionCategory.FunctionKeys, "KC_F9", "F9");
        public static readonly KeyAction KC_F10 = new KeyAction(ActionCategory.FunctionKeys, "KC_F10", "F10");
        public static readonly KeyAction KC_F11 = new KeyAction(ActionCategory.FunctionKeys, "KC_F11", "F11");
        public static readonly KeyAction KC_F12 = new KeyAction(ActionCategory.FunctionKeys, "KC_F12", "F12");
        public static readonly KeyAction KC_F13 = new KeyAction(ActionCategory.FunctionKeys, "KC_F13", "F13");
        public static readonly KeyAction KC_F14 = new KeyAction(ActionCategory.FunctionKeys, "KC_F14", "F14");
        public static readonly KeyAction KC_F15 = new KeyAction(ActionCategory.FunctionKeys, "KC_F15", "F15");
        public static readonly KeyAction KC_F16 = new KeyAction(ActionCategory.FunctionKeys, "KC_F16", "F16");
        public static readonly KeyAction KC_F17 = new KeyAction(ActionCategory.FunctionKeys, "KC_F17", "F17");
        public static readonly KeyAction KC_F18 = new KeyAction(ActionCategory.FunctionKeys, "KC_F18", "F18");
        public static readonly KeyAction KC_F19 = new KeyAction(ActionCategory.FunctionKeys, "KC_F19", "F19");
        public static readonly KeyAction KC_F20 = new KeyAction(ActionCategory.FunctionKeys, "KC_F20", "F20");
        public static readonly KeyAction KC_F21 = new KeyAction(ActionCategory.FunctionKeys, "KC_F21", "F21");
        public static readonly KeyAction KC_F22 = new KeyAction(ActionCategory.FunctionKeys, "KC_F22", "F22");
        public static readonly KeyAction KC_F23 = new KeyAction(ActionCategory.FunctionKeys, "KC_F23", "F23");
        public static readonly KeyAction KC_F24 = new KeyAction(ActionCategory.FunctionKeys, "KC_F24", "F24");

        public static readonly KeyAction KC_FN0 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN0", "FN0");
        public static readonly KeyAction KC_FN1 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN1", "FN1");
        public static readonly KeyAction KC_FN2 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN2", "FN2");
        public static readonly KeyAction KC_FN3 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN3", "FN3");
        public static readonly KeyAction KC_FN4 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN4", "FN4");
        public static readonly KeyAction KC_FN5 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN5", "FN5");
        public static readonly KeyAction KC_FN6 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN6", "FN6");
        public static readonly KeyAction KC_FN7 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN7", "FN7");
        public static readonly KeyAction KC_FN8 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN8", "FN8");
        public static readonly KeyAction KC_FN9 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN9", "FN9");
        public static readonly KeyAction KC_FN10 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN10", "FN10");
        public static readonly KeyAction KC_FN11 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN11", "FN11");
        public static readonly KeyAction KC_FN12 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN12", "FN12");
        public static readonly KeyAction KC_FN13 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN13", "FN13");
        public static readonly KeyAction KC_FN14 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN14", "FN14");
        public static readonly KeyAction KC_FN15 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN15", "FN15");
        public static readonly KeyAction KC_FN16 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN16", "FN16");
        public static readonly KeyAction KC_FN17 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN17", "FN17");
        public static readonly KeyAction KC_FN18 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN18", "FN18");
        public static readonly KeyAction KC_FN19 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN19", "FN19");
        public static readonly KeyAction KC_FN20 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN20", "FN20");
        public static readonly KeyAction KC_FN21 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN21", "FN21");
        public static readonly KeyAction KC_FN22 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN22", "FN22");
        public static readonly KeyAction KC_FN23 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN23", "FN23");
        public static readonly KeyAction KC_FN24 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN24", "FN24");
        public static readonly KeyAction KC_FN25 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN25", "FN25");
        public static readonly KeyAction KC_FN26 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN26", "FN26");
        public static readonly KeyAction KC_FN27 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN27", "FN27");
        public static readonly KeyAction KC_FN28 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN28", "FN28");
        public static readonly KeyAction KC_FN29 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN29", "FN29");
        public static readonly KeyAction KC_FN30 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN30", "FN30");
        public static readonly KeyAction KC_FN31 = new KeyAction(ActionCategory.FunctionKeys, "KC_FN31", "FN31");

        public static readonly KeyAction KC_PSCREEN = new KeyAction(ActionCategory.Other, "KC_PSCREEN", "PSCRN");
        public static readonly KeyAction KC_SCROLLLOCK = new KeyAction(ActionCategory.Modifiers, "KC_SCROLLLOCK", "SCROLL");
        public static readonly KeyAction KC_PAUSE = new KeyAction(ActionCategory.Other, "KC_PAUSE", "PAUSE");
        public static readonly KeyAction KC_INSERT = new KeyAction(ActionCategory.Other, "KC_INSERT", "INS");
        public static readonly KeyAction KC_HOME = new KeyAction(ActionCategory.Navigation, "KC_HOME", "HOME");
        public static readonly KeyAction KC_PGUP = new KeyAction(ActionCategory.Navigation, "KC_PGUP", "PGUP");
        public static readonly KeyAction KC_DELETE = new KeyAction(ActionCategory.Other, "KC_DELETE", "DEL");
        public static readonly KeyAction KC_END = new KeyAction(ActionCategory.Navigation, "KC_END", "END");
        public static readonly KeyAction KC_PGDOWN = new KeyAction(ActionCategory.Navigation, "KC_PGDOWN", "PGDN");
        public static readonly KeyAction KC_RIGHT = new KeyAction(ActionCategory.Navigation, "KC_RIGHT", "RIGHT");
        public static readonly KeyAction KC_LEFT = new KeyAction(ActionCategory.Navigation, "KC_LEFT", "LEFT");
        public static readonly KeyAction KC_DOWN = new KeyAction(ActionCategory.Navigation, "KC_DOWN", "DOWN");
        public static readonly KeyAction KC_UP = new KeyAction(ActionCategory.Navigation, "KC_UP", "UP");
        public static readonly KeyAction KC_NUMLOCK = new KeyAction(ActionCategory.Modifiers, "KC_NUMLOCK", "KP =");

        public static readonly KeyAction KC_KP_SLASH = new KeyAction(ActionCategory.Numpad, "KC_KP_SLASH", "KP =");
        public static readonly KeyAction KC_KP_ASTERISK = new KeyAction(ActionCategory.Numpad, "KC_KP_ASTERISK", "KP =");
        public static readonly KeyAction KC_KP_MINUS = new KeyAction(ActionCategory.Numpad, "KC_KP_MINUS", "KP =");
        public static readonly KeyAction KC_KP_PLUS = new KeyAction(ActionCategory.Numpad, "KC_KP_PLUS", "KP =");
        public static readonly KeyAction KC_KP_ENTER = new KeyAction(ActionCategory.Numpad, "KC_KP_ENTER", "KP =");
        public static readonly KeyAction KC_KP_1 = new KeyAction(ActionCategory.Numpad, "KC_KP_1", "KP 1");
        public static readonly KeyAction KC_KP_2 = new KeyAction(ActionCategory.Numpad, "KC_KP_2", "KP 2");
        public static readonly KeyAction KC_KP_3 = new KeyAction(ActionCategory.Numpad, "KC_KP_3", "KP 3");
        public static readonly KeyAction KC_KP_4 = new KeyAction(ActionCategory.Numpad, "KC_KP_4", "KP 4");
        public static readonly KeyAction KC_KP_5 = new KeyAction(ActionCategory.Numpad, "KC_KP_5", "KP 5");
        public static readonly KeyAction KC_KP_6 = new KeyAction(ActionCategory.Numpad, "KC_KP_6", "KP 6");
        public static readonly KeyAction KC_KP_7 = new KeyAction(ActionCategory.Numpad, "KC_KP_7", "KP 7");
        public static readonly KeyAction KC_KP_8 = new KeyAction(ActionCategory.Numpad, "KC_KP_8", "KP 8");
        public static readonly KeyAction KC_KP_9 = new KeyAction(ActionCategory.Numpad, "KC_KP_9", "KP 9");
        public static readonly KeyAction KC_KP_0 = new KeyAction(ActionCategory.Numpad, "KC_KP_0", "KP 0");
        public static readonly KeyAction KC_KP_DOT = new KeyAction(ActionCategory.Numpad, "KC_KP_DOT", "KP .");
        public static readonly KeyAction KC_NONUS_BSLASH = new KeyAction(ActionCategory.Numpad, "KC_NONUS_BSLASH", "\\", "|");
        public static readonly KeyAction KC_APPLICATION = new KeyAction(ActionCategory.Modifiers, "KC_APPLICATION", "APP");
        public static readonly KeyAction KC_POWER = new KeyAction(ActionCategory.SystemControl, "KC_POWER", "PWR");
        public static readonly KeyAction KC_KP_EQUAL = new KeyAction(ActionCategory.Numpad, "KC_KP_EQUAL", "KP =");

        public static readonly KeyAction KC_LCTRL = new KeyAction(ActionCategory.Modifiers, "KC_LCTRL", "LCTRL");
        public static readonly KeyAction KC_LSHIFT = new KeyAction(ActionCategory.Modifiers, "KC_LSHIFT", "LSHIFT");
        public static readonly KeyAction KC_LALT = new KeyAction(ActionCategory.Modifiers, "KC_LALT", "LALT");
        public static readonly KeyAction KC_LGUI = new KeyAction(ActionCategory.Other, "KC_LGUI", "LGUI");
        public static readonly KeyAction KC_RCTRL = new KeyAction(ActionCategory.Modifiers, "KC_RCTRL", "RCTRL");
        public static readonly KeyAction KC_RSHIFT = new KeyAction(ActionCategory.Modifiers, "KC_RSHIFT", "RSHIFT");
        public static readonly KeyAction KC_RALT = new KeyAction(ActionCategory.Modifiers, "KC_RALT", "RALT");
        public static readonly KeyAction KC_RGUI = new KeyAction(ActionCategory.Other, "KC_RGUI", "RGUI");
        public static readonly KeyAction KC_HYPHER = new KeyAction(ActionCategory.Modifiers, "KC_HYPR", "HYP");
        public static readonly KeyAction KC_MEH = new KeyAction(ActionCategory.Modifiers, "KC_MEH", "MEH");

        public static readonly KeyAction KC_COLON = new KeyAction(ActionCategory.Symbols, "KC_COLON", ":");
        public static readonly KeyAction KC_PIPE = new KeyAction(ActionCategory.Symbols, "KC_PIPE", "|");
        public static readonly KeyAction KC_RIGHT_CURLY_BRACE = new KeyAction(ActionCategory.Symbols, "KC_RIGHT_CURLY_BRACE", "}");
        public static readonly KeyAction KC_LEFT_CURLY_BRACE = new KeyAction(ActionCategory.Symbols, "KC_LEFT_CURLY_BRACE", "{");
        public static readonly KeyAction KC_PLUS = new KeyAction(ActionCategory.Symbols, "KC_PLUS", "+");
        public static readonly KeyAction KC_UNDERSCORE = new KeyAction(ActionCategory.Symbols, "KC_UNDERSCORE", "_");
        public static readonly KeyAction KC_RIGHT_PAREN = new KeyAction(ActionCategory.Symbols, "KC_RIGHT_PAREN", ")");
        public static readonly KeyAction KC_LEFT_PAREN = new KeyAction(ActionCategory.Symbols, "KC_LEFT_PAREN", "(");
        public static readonly KeyAction KC_ASTERISK = new KeyAction(ActionCategory.Symbols, "KC_ASTERISK", "*");
        public static readonly KeyAction KC_AMPERSAND = new KeyAction(ActionCategory.Symbols, "KC_AMPERSAND", "&");        
        public static readonly KeyAction KC_CIRCUMFLEX = new KeyAction(ActionCategory.Symbols, "KC_CIRCUMFLEX", "^");
        public static readonly KeyAction KC_PERCENT = new KeyAction(ActionCategory.Symbols, "KC_PERCENT", "%");
        public static readonly KeyAction KC_DOLLAR = new KeyAction(ActionCategory.Symbols, "KC_DOLLAR", "$");
        public static readonly KeyAction KC_EXCLAIM = new KeyAction(ActionCategory.Symbols, "KC_EXCLAIM", "!");
        public static readonly KeyAction KC_HASH = new KeyAction(ActionCategory.Symbols, "KC_HASH", "#");
        public static readonly KeyAction KC_AT = new KeyAction(ActionCategory.Symbols, "KC_AT", "@");
        public static readonly KeyAction KC_TILDE = new KeyAction(ActionCategory.Symbols, "KC_TILDE", "~");

        public static readonly KeyAction KC_MS_UP = new KeyAction(ActionCategory.Mouse, "KC_MS_UP", "MS UP");
        public static readonly KeyAction KC_MS_DOWN = new KeyAction(ActionCategory.Mouse, "KC_MS_DOWN", "MS DOWN");
        public static readonly KeyAction KC_MS_LEFT = new KeyAction(ActionCategory.Mouse, "KC_MS_LEFT", "MS LEFT");
        public static readonly KeyAction KC_MS_RIGHT = new KeyAction(ActionCategory.Mouse, "KC_MS_RIGHT", "MS RIGHT");
        public static readonly KeyAction KC_MS_BTN1 = new KeyAction(ActionCategory.Mouse, "KC_MS_BTN1", "MS B1");
        public static readonly KeyAction KC_MS_BTN2 = new KeyAction(ActionCategory.Mouse, "KC_MS_BTN2", "MS B2");
        public static readonly KeyAction KC_MS_BTN3 = new KeyAction(ActionCategory.Mouse, "KC_MS_BTN3", "MS B3");
        public static readonly KeyAction KC_MS_BTN4 = new KeyAction(ActionCategory.Mouse, "KC_MS_BTN4", "MS B4");
        public static readonly KeyAction KC_MS_BTN5 = new KeyAction(ActionCategory.Mouse, "KC_MS_BTN5", "MS B5");
        public static readonly KeyAction KC_MS_WH_UP = new KeyAction(ActionCategory.Mouse, "KC_MS_WH_UP", "MS WH UP");
        public static readonly KeyAction KC_MS_WH_DOWN = new KeyAction(ActionCategory.Mouse, "KC_MS_WH_DOWN", "MS WH DOWN");
        public static readonly KeyAction KC_MS_WH_LEFT = new KeyAction(ActionCategory.Mouse, "KC_MS_WH_LEFT", "MS WH LEFT");
        public static readonly KeyAction KC_MS_WH_RIGHT = new KeyAction(ActionCategory.Mouse, "KC_MS_WH_RIGHT", "MS WH RIGHT");
        public static readonly KeyAction KC_MS_ACCEL0 = new KeyAction(ActionCategory.Mouse, "KC_MS_ACCEL0", "MS ACC 0");
        public static readonly KeyAction KC_MS_ACCEL1 = new KeyAction(ActionCategory.Mouse, "KC_MS_ACCEL1", "MS ACC 1");
        public static readonly KeyAction KC_MS_ACCEL2 = new KeyAction(ActionCategory.Mouse, "KC_MS_ACCEL2", "MS ACC 2");

        public static readonly KeyAction KC_BOOTLOADER = new KeyAction(ActionCategory.SystemControl, "KC_BOOTLOADER", "TINY");

        public static readonly KeyAction KC_AUDIO_MUTE = new KeyAction(ActionCategory.Media, "KC_AUDIO_MUTE", "MUTE");
        public static readonly KeyAction KC_AUDIO_VOL_UP = new KeyAction(ActionCategory.Media, "KC_AUDIO_VOL_UP", "VOL UP");
        public static readonly KeyAction KC_AUDIO_VOL_DOWN = new KeyAction(ActionCategory.Media, "KC_AUDIO_VOL_DOWN", "VOL DN");
        public static readonly KeyAction KC_MEDIA_NEXT_TRACK = new KeyAction(ActionCategory.Media, "KC_MEDIA_NEXT_TRACK", "NEXT TRACK");
        public static readonly KeyAction KC_MEDIA_PREV_TRACK = new KeyAction(ActionCategory.Media, "KC_MEDIA_PREV_TRACK", "PREV TRACK");
        public static readonly KeyAction KC_MEDIA_STOP = new KeyAction(ActionCategory.Media, "KC_MEDIA_STOP", "MEDIA STOP");
        public static readonly KeyAction KC_MEDIA_PLAY_PAUSE = new KeyAction(ActionCategory.Media, "KC_MEDIA_PLAY_PAUSE", "PLAY/PAUSE");
        public static readonly KeyAction KC_MEDIA_SELECT = new KeyAction(ActionCategory.Media, "KC_MEDIA_SELECT", "MEDIA SELECT");
        public static readonly KeyAction KC_MEDIA_EJECT = new KeyAction(ActionCategory.Media, "KC_MEDIA_EJECT", "MEDIA EJECT");
        public static readonly KeyAction KC_MEDIA_FAST_FORWARD = new KeyAction(ActionCategory.Media, "KC_MEDIA_FAST_FORWARD", "FAST FORWARD");
        public static readonly KeyAction KC_MEDIA_REWIND = new KeyAction(ActionCategory.Media, "KC_MEDIA_REWIND", "REWIND");

        public static readonly KeyAction KC_MAIL = new KeyAction(ActionCategory.Media, "KC_MAIL", "MAIL");
        public static readonly KeyAction KC_CALCULATOR = new KeyAction(ActionCategory.Media, "KC_CALCULATOR", "CALC");
        public static readonly KeyAction KC_MY_COMPUTER = new KeyAction(ActionCategory.Media, "KC_MY_COMPUTER", "MY COMPUTER");
        public static readonly KeyAction KC_WWW_SEARCH = new KeyAction(ActionCategory.Media, "KC_WWW_SEARCH", "WWW SEARCH");
        public static readonly KeyAction KC_WWW_HOME = new KeyAction(ActionCategory.Media, "KC_WWW_HOME", "WWW HOME");
        public static readonly KeyAction KC_WWW_BACK = new KeyAction(ActionCategory.Media, "KC_WWW_BACK", "WWW BACK");
        public static readonly KeyAction KC_WWW_FORWARD = new KeyAction(ActionCategory.Media, "KC_WWW_FORWARD", "WWW FORWARD");
        public static readonly KeyAction KC_WWW_STOP = new KeyAction(ActionCategory.Media, "KC_WWW_STOP", "WWW STOP");
        public static readonly KeyAction KC_WWW_REFRESH = new KeyAction(ActionCategory.Media, "KC_WWW_REFRESH", "WWW REFRESH");
        public static readonly KeyAction KC_WWW_FAVORITES = new KeyAction(ActionCategory.Media, "KC_WWW_FAVORITES", "WWW FAV");

        //    public static readonly KeyAction KC_ = new KeyAction("KC_", "");

        //    KC_EXECUTE,
        //KC_HELP,
        //KC_MENU,
        //KC_SELECT,
        //KC_STOP,
        //KC_AGAIN,
        //KC_UNDO,
        //KC_CUT,
        //KC_COPY,
        //KC_PASTE,
        //KC_FIND,
        //KC__MUTE,
        //KC__VOLUP,          /* 0x80 */
        //KC__VOLDOWN,
        //KC_LOCKING_CAPS,    /* locking Caps Lock */
        //KC_LOCKING_NUM,     /* locking Num Lock */
        //KC_LOCKING_SCROLL,  /* locking Scroll Lock */
        //KC_KP_COMMA,
        //KC_KP_EQUAL_AS400,  /* equal sign on AS/400 */
        //KC_INT1,
        //KC_INT2,
        //KC_INT3,
        //KC_INT4,
        //KC_INT5,
        //KC_INT6,
        //KC_INT7,
        //KC_INT8,
        //KC_INT9,
        //KC_LANG1,           /* 0x90 */
        //KC_LANG2,
        //KC_LANG3,
        //KC_LANG4,
        //KC_LANG5,
        //KC_LANG6,
        //KC_LANG7,
        //KC_LANG8,
        //KC_LANG9,
        //KC_ALT_ERASE,
        //KC_SYSREQ,
        //KC_CANCEL,
        //KC_CLEAR,
        //KC_PRIOR,
        //KC_RETURN,
        //KC_SEPARATOR,
        //KC_OUT,             /* 0xA0 */
        //KC_OPER,
        //KC_CLEAR_AGAIN,
        //KC_CRSEL,
        //KC_EXSEL,           






        ///* System Control */
        //KC_SYSTEM_POWER     = 0xA5,
        //KC_SYSTEM_SLEEP,
        //KC_SYSTEM_WAKE,



        ///**************************************/
        ///* 0xE0-E7 for Modifiers. DO NOT USE. */
        ///**************************************/

        public readonly static Action[] All = new Action[]
        {
            Transparent, No,
            KC_A, KC_B, KC_C, KC_D, KC_E, KC_F, KC_G, KC_H, KC_I, KC_J, KC_K, KC_L, KC_M, KC_N, KC_O, KC_P, KC_Q, KC_R, KC_S, KC_T, KC_U, KC_V, KC_W, KC_X, KC_Y, KC_Z,
            KC_0, KC_1, KC_2, KC_3, KC_4, KC_5, KC_6, KC_7, KC_8, KC_9,
            KC_ENTER, KC_ESCAPE, KC_BSPACE, KC_TAB, KC_SPACE, KC_MINUS, KC_EQUAL, KC_LBRACKET, KC_RBRACKET, KC_BSLASH, KC_NONUS_HASH, KC_SCOLON, KC_QUOTE, KC_GRAVE, KC_COMMA, KC_DOT, KC_SLASH, KC_CAPSLOCK,
            KC_F1, KC_F2, KC_F3, KC_F4, KC_F5, KC_F6, KC_F7, KC_F8, KC_F9, KC_F10, KC_F11, KC_F12, KC_F13, KC_F14, KC_F15, KC_F16, KC_F17, KC_F18, KC_F19, KC_F20, KC_F21, KC_F22, KC_F23, KC_F24,
            KC_FN0, KC_FN1, KC_FN2, KC_FN3, KC_FN4, KC_FN5, KC_FN6, KC_FN7, KC_FN8, KC_FN9, KC_FN10, KC_FN11, KC_FN12, KC_FN13, KC_FN14, KC_FN15, KC_FN16, KC_FN17, KC_FN18, KC_FN19, KC_FN20, KC_FN21, KC_FN22, KC_FN23, KC_FN24, KC_FN25, KC_FN26, KC_FN27, KC_FN28, KC_FN29, KC_FN30, KC_FN31,
            KC_PSCREEN, KC_SCROLLLOCK, KC_PAUSE, KC_INSERT, KC_HOME, KC_PGUP, KC_DELETE, KC_END, KC_PGDOWN, KC_RIGHT, KC_LEFT, KC_DOWN, KC_UP, KC_NUMLOCK,
            KC_KP_SLASH, KC_KP_ASTERISK, KC_KP_MINUS, KC_KP_PLUS, KC_KP_ENTER, KC_KP_1, KC_KP_2, KC_KP_3, KC_KP_4, KC_KP_5, KC_KP_6, KC_KP_7, KC_KP_8, KC_KP_9, KC_KP_0, KC_KP_DOT, KC_NONUS_BSLASH, KC_APPLICATION, KC_POWER, KC_KP_EQUAL,
            KC_LCTRL, KC_LSHIFT, KC_LALT, KC_LGUI, KC_RCTRL, KC_RSHIFT, KC_RALT, KC_RGUI, KC_HYPHER, KC_MEH,
            KC_COLON, KC_PIPE, KC_RIGHT_CURLY_BRACE, KC_LEFT_CURLY_BRACE, KC_PLUS, KC_UNDERSCORE, KC_RIGHT_PAREN, KC_LEFT_PAREN, KC_ASTERISK, KC_AMPERSAND, KC_CIRCUMFLEX, KC_PERCENT, KC_DOLLAR, KC_EXCLAIM, KC_HASH, KC_AT, KC_TILDE,
            KC_MS_UP, KC_MS_DOWN, KC_MS_LEFT, KC_MS_RIGHT, KC_MS_BTN1, KC_MS_BTN2, KC_MS_BTN3, KC_MS_BTN4, KC_MS_BTN5, KC_MS_WH_UP, KC_MS_WH_DOWN, KC_MS_WH_LEFT, KC_MS_WH_RIGHT, KC_MS_ACCEL0, KC_MS_ACCEL1, KC_MS_ACCEL2,
            KC_BOOTLOADER,
            KC_AUDIO_MUTE, KC_AUDIO_VOL_UP, KC_AUDIO_VOL_DOWN, KC_MEDIA_NEXT_TRACK, KC_MEDIA_PREV_TRACK, KC_MEDIA_STOP, KC_MEDIA_PLAY_PAUSE, KC_MEDIA_SELECT, KC_MEDIA_EJECT, KC_MEDIA_FAST_FORWARD, KC_MEDIA_REWIND,
            KC_MAIL, KC_CALCULATOR, KC_MY_COMPUTER, KC_WWW_SEARCH, KC_WWW_HOME, KC_WWW_BACK, KC_WWW_FORWARD, KC_WWW_STOP, KC_WWW_REFRESH, KC_WWW_FAVORITES,
        };                                                                                
    }

    public class TransparentAction : Action
    {
        public override ActionCategory Category => ActionCategory.System;

        public override string CCode => "KC_TRANSPARENT";

        public override string Label => "";
        public override string ShiftLabel => "";
    }

    public class NoAction : Action
    {
        public override ActionCategory Category => ActionCategory.System;

        public override string CCode => "KC_NO";

        public override string Label => "Ø";
        public override string ShiftLabel => "";
    }

    public class KeyAction : Action
    {
        public KeyAction(ActionCategory category, string ccode, string label, string shiftLabel = null)
        {
            Category = category;
            CCode = ccode;
            Label = label;
            ShiftLabel = shiftLabel;
        }

        public override ActionCategory Category { get; }

        public override string CCode { get; }

        public override string Label { get; }
        public override string ShiftLabel { get; }
    }

    public class MomentaryLayer : Action
    {
        public MomentaryLayer(int layer)
        {
            Layer = layer;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"MO({Layer})";
        public override string Label => $"+[{Layer}]";
        public override string ShiftLabel => "";

        public int Layer { get; }
    }

    public class DefaultLayer : Action
    {
        public DefaultLayer(int layer)
        {
            Layer = layer;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"DF({Layer})";
        public override string Label => $"[{Layer}]";
        public override string ShiftLabel => "";

        public int Layer { get; }
    }

    public class ToggleLayer : Action
    {
        public ToggleLayer(int layer)
        {
            Layer = layer;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"TG({Layer})";
        public override string Label => $"~[{Layer}]";
        public override string ShiftLabel => "";

        public int Layer { get; }
    }

    public class LayerOrAction : Action
    {
        public LayerOrAction(int layer, Action other)
        {
            Layer = layer;
            Other = other;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"LT({Layer},{Other.CCode})";
        public override string Label => Other.Label;
        public override string ShiftLabel => Other.ShiftLabel;
        public override string AltLabel => $"+[{Layer}]";

        public int Layer { get; }
        public Action Other { get; }
    }

    public class ControlOrAction : Action
    {
        public ControlOrAction(Action other)
        {
            Other = other;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"CTL_T({Other.CCode})";
        public override string Label => Other.Label;
        public override string ShiftLabel => Other.ShiftLabel;
        public override string AltLabel => "CTRL";

        public Action Other { get; }
    }

    public class AltOrAction : Action
    {
        public AltOrAction(Action other)
        {
            Other = other;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"ALT_T({Other.CCode})";
        public override string Label => Other.Label;
        public override string ShiftLabel => Other.ShiftLabel;
        public override string AltLabel => "ALT";

        public Action Other { get; }
    }

    public class ShiftOrAction : Action
    {
        public ShiftOrAction(Action other)
        {
            Other = other;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"SFT_T({Other.CCode})";
        public override string Label => Other.Label;
        public override string ShiftLabel => Other.ShiftLabel;
        public override string AltLabel => "SHFT";

        public Action Other { get; }
    }

    public class ControlShiftOrAction : Action
    {
        public ControlShiftOrAction(Action other)
        {
            Other = other;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        public override string CCode => $"C_S_T({Other.CCode})";
        public override string Label => Other.Label;
        public override string ShiftLabel => Other.ShiftLabel;
        public override string AltLabel => "CTRL";
        public override string AltShiftLabel => "SHIFT";

        public Action Other { get; }
    }

    public class AltAndAction : Action
    {
        public AltAndAction(Action other)
        {
            Other = other;
        }

        public override ActionCategory Category => ActionCategory.Layers;

        private static string AltPlus(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return text;
            }
            return $"ALT+{text}";
        }

        public override string CCode => $"LALT({Other.CCode})";
        public override string Label => AltPlus(Other.Label);
        public override string ShiftLabel => AltPlus(Other.ShiftLabel);
        public override string AltLabel => AltPlus(Other.AltLabel);
        public override string AltShiftLabel => AltPlus(Other.AltShiftLabel);

        public Action Other { get; }
    }
    
}
