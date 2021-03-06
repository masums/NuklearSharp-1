using System;
using System.Runtime.InteropServices;

namespace NuklearSharp
{
	unsafe partial class Nuklear
	{
		public const int nk_false = 0;
		public const int nk_true = 1;
		public const int NK_UP = 0;
		public const int NK_RIGHT = 1;
		public const int NK_DOWN = 2;
		public const int NK_LEFT = 3;
		public const int NK_BUTTON_DEFAULT = 0;
		public const int NK_BUTTON_REPEATER = 1;
		public const int NK_FIXED = Nuklear.nk_false;
		public const int NK_MODIFIABLE = Nuklear.nk_true;
		public const int NK_VERTICAL = 0;
		public const int NK_HORIZONTAL = 1;
		public const int NK_MINIMIZED = Nuklear.nk_false;
		public const int NK_MAXIMIZED = Nuklear.nk_true;
		public const int NK_HIDDEN = Nuklear.nk_false;
		public const int NK_SHOWN = Nuklear.nk_true;
		public const int NK_CHART_LINES = 0;
		public const int NK_CHART_COLUMN = 1;
		public const int NK_CHART_MAX = 2;
		public const int NK_CHART_HOVERING = 0x01;
		public const int NK_CHART_CLICKED = 0x02;
		public const int NK_RGB = 0;
		public const int NK_RGBA = 1;
		public const int NK_POPUP_STATIC = 0;
		public const int NK_POPUP_DYNAMIC = 1;
		public const int NK_DYNAMIC = 0;
		public const int NK_STATIC = 1;
		public const int NK_TREE_NODE = 0;
		public const int NK_TREE_TAB = 1;
		public const int NK_SYMBOL_NONE = 0;
		public const int NK_SYMBOL_X = 1;
		public const int NK_SYMBOL_UNDERSCORE = 2;
		public const int NK_SYMBOL_CIRCLE_SOLID = 3;
		public const int NK_SYMBOL_CIRCLE_OUTLINE = 4;
		public const int NK_SYMBOL_RECT_SOLID = 5;
		public const int NK_SYMBOL_RECT_OUTLINE = 6;
		public const int NK_SYMBOL_TRIANGLE_UP = 7;
		public const int NK_SYMBOL_TRIANGLE_DOWN = 8;
		public const int NK_SYMBOL_TRIANGLE_LEFT = 9;
		public const int NK_SYMBOL_TRIANGLE_RIGHT = 10;
		public const int NK_SYMBOL_PLUS = 11;
		public const int NK_SYMBOL_MINUS = 12;
		public const int NK_SYMBOL_MAX = 13;
		public const int NK_KEY_NONE = 0;
		public const int NK_KEY_SHIFT = 1;
		public const int NK_KEY_CTRL = 2;
		public const int NK_KEY_DEL = 3;
		public const int NK_KEY_ENTER = 4;
		public const int NK_KEY_TAB = 5;
		public const int NK_KEY_BACKSPACE = 6;
		public const int NK_KEY_COPY = 7;
		public const int NK_KEY_CUT = 8;
		public const int NK_KEY_PASTE = 9;
		public const int NK_KEY_UP = 10;
		public const int NK_KEY_DOWN = 11;
		public const int NK_KEY_LEFT = 12;
		public const int NK_KEY_RIGHT = 13;
		public const int NK_KEY_TEXT_INSERT_MODE = 14;
		public const int NK_KEY_TEXT_REPLACE_MODE = 15;
		public const int NK_KEY_TEXT_RESET_MODE = 16;
		public const int NK_KEY_TEXT_LINE_START = 17;
		public const int NK_KEY_TEXT_LINE_END = 18;
		public const int NK_KEY_TEXT_START = 19;
		public const int NK_KEY_TEXT_END = 20;
		public const int NK_KEY_TEXT_UNDO = 21;
		public const int NK_KEY_TEXT_REDO = 22;
		public const int NK_KEY_TEXT_SELECT_ALL = 23;
		public const int NK_KEY_TEXT_WORD_LEFT = 24;
		public const int NK_KEY_TEXT_WORD_RIGHT = 25;
		public const int NK_KEY_SCROLL_START = 26;
		public const int NK_KEY_SCROLL_END = 27;
		public const int NK_KEY_SCROLL_DOWN = 28;
		public const int NK_KEY_SCROLL_UP = 29;
		public const int NK_KEY_MAX = 30;
		public const int NK_BUTTON_LEFT = 0;
		public const int NK_BUTTON_MIDDLE = 1;
		public const int NK_BUTTON_RIGHT = 2;
		public const int NK_BUTTON_DOUBLE = 3;
		public const int NK_BUTTON_MAX = 4;
		public const int NK_ANTI_ALIASING_OFF = 0;
		public const int NK_ANTI_ALIASING_ON = 1;
		public const int NK_CONVERT_SUCCESS = 0;
		public const int NK_CONVERT_INVALID_PARAM = 1;
		public const int NK_CONVERT_COMMAND_BUFFER_FULL = (1 << (1));
		public const int NK_CONVERT_VERTEX_BUFFER_FULL = (1 << (2));
		public const int NK_CONVERT_ELEMENT_BUFFER_FULL = (1 << (3));
		public const int NK_WINDOW_BORDER = (1 << (0));
		public const int NK_WINDOW_MOVABLE = (1 << (1));
		public const int NK_WINDOW_SCALABLE = (1 << (2));
		public const int NK_WINDOW_CLOSABLE = (1 << (3));
		public const int NK_WINDOW_MINIMIZABLE = (1 << (4));
		public const int NK_WINDOW_NO_SCROLLBAR = (1 << (5));
		public const int NK_WINDOW_TITLE = (1 << (6));
		public const int NK_WINDOW_SCROLL_AUTO_HIDE = (1 << (7));
		public const int NK_WINDOW_BACKGROUND = (1 << (8));
		public const int NK_WINDOW_SCALE_LEFT = (1 << (9));
		public const int NK_WINDOW_NO_INPUT = (1 << (10));
		public const int NK_WIDGET_INVALID = 0;
		public const int NK_WIDGET_VALID = 1;
		public const int NK_WIDGET_ROM = 2;
		public const int NK_WIDGET_STATE_MODIFIED = (1 << (1));
		public const int NK_WIDGET_STATE_INACTIVE = (1 << (2));
		public const int NK_WIDGET_STATE_ENTERED = (1 << (3));
		public const int NK_WIDGET_STATE_HOVER = (1 << (4));
		public const int NK_WIDGET_STATE_ACTIVED = (1 << (5));
		public const int NK_WIDGET_STATE_LEFT = (1 << (6));
		public const int NK_WIDGET_STATE_HOVERED = Nuklear.NK_WIDGET_STATE_HOVER | Nuklear.NK_WIDGET_STATE_MODIFIED;
		public const int NK_WIDGET_STATE_ACTIVE = Nuklear.NK_WIDGET_STATE_ACTIVED | Nuklear.NK_WIDGET_STATE_MODIFIED;
		public const int NK_TEXT_ALIGN_LEFT = 0x01;
		public const int NK_TEXT_ALIGN_CENTERED = 0x02;
		public const int NK_TEXT_ALIGN_RIGHT = 0x04;
		public const int NK_TEXT_ALIGN_TOP = 0x08;
		public const int NK_TEXT_ALIGN_MIDDLE = 0x10;
		public const int NK_TEXT_ALIGN_BOTTOM = 0x20;
		public const int NK_TEXT_LEFT = Nuklear.NK_TEXT_ALIGN_MIDDLE | Nuklear.NK_TEXT_ALIGN_LEFT;
		public const int NK_TEXT_CENTERED = Nuklear.NK_TEXT_ALIGN_MIDDLE | Nuklear.NK_TEXT_ALIGN_CENTERED;
		public const int NK_TEXT_RIGHT = Nuklear.NK_TEXT_ALIGN_MIDDLE | Nuklear.NK_TEXT_ALIGN_RIGHT;
		public const int NK_EDIT_DEFAULT = 0;
		public const int NK_EDIT_READ_ONLY = (1 << (0));
		public const int NK_EDIT_AUTO_SELECT = (1 << (1));
		public const int NK_EDIT_SIG_ENTER = (1 << (2));
		public const int NK_EDIT_ALLOW_TAB = (1 << (3));
		public const int NK_EDIT_NO_CURSOR = (1 << (4));
		public const int NK_EDIT_SELECTABLE = (1 << (5));
		public const int NK_EDIT_CLIPBOARD = (1 << (6));
		public const int NK_EDIT_CTRL_ENTER_NEWLINE = (1 << (7));
		public const int NK_EDIT_NO_HORIZONTAL_SCROLL = (1 << (8));
		public const int NK_EDIT_ALWAYS_INSERT_MODE = (1 << (9));
		public const int NK_EDIT_MULTILINE = (1 << (10));
		public const int NK_EDIT_GOTO_END_ON_ACTIVATE = (1 << (11));
		public const int NK_EDIT_SIMPLE = Nuklear.NK_EDIT_ALWAYS_INSERT_MODE;
		public const int NK_EDIT_FIELD = Nuklear.NK_EDIT_SIMPLE | Nuklear.NK_EDIT_SELECTABLE | Nuklear.NK_EDIT_CLIPBOARD;

		public const int NK_EDIT_BOX =
			Nuklear.NK_EDIT_ALWAYS_INSERT_MODE | Nuklear.NK_EDIT_SELECTABLE | Nuklear.NK_EDIT_MULTILINE |
			Nuklear.NK_EDIT_ALLOW_TAB | Nuklear.NK_EDIT_CLIPBOARD;

		public const int NK_EDIT_EDITOR =
			Nuklear.NK_EDIT_SELECTABLE | Nuklear.NK_EDIT_MULTILINE | Nuklear.NK_EDIT_ALLOW_TAB | Nuklear.NK_EDIT_CLIPBOARD;

		public const int NK_EDIT_ACTIVE = (1 << (0));
		public const int NK_EDIT_INACTIVE = (1 << (1));
		public const int NK_EDIT_ACTIVATED = (1 << (2));
		public const int NK_EDIT_DEACTIVATED = (1 << (3));
		public const int NK_EDIT_COMMITED = (1 << (4));
		public const int NK_COLOR_TEXT = 0;
		public const int NK_COLOR_WINDOW = 1;
		public const int NK_COLOR_HEADER = 2;
		public const int NK_COLOR_BORDER = 3;
		public const int NK_COLOR_BUTTON = 4;
		public const int NK_COLOR_BUTTON_HOVER = 5;
		public const int NK_COLOR_BUTTON_ACTIVE = 6;
		public const int NK_COLOR_TOGGLE = 7;
		public const int NK_COLOR_TOGGLE_HOVER = 8;
		public const int NK_COLOR_TOGGLE_CURSOR = 9;
		public const int NK_COLOR_SELECT = 10;
		public const int NK_COLOR_SELECT_ACTIVE = 11;
		public const int NK_COLOR_SLIDER = 12;
		public const int NK_COLOR_SLIDER_CURSOR = 13;
		public const int NK_COLOR_SLIDER_CURSOR_HOVER = 14;
		public const int NK_COLOR_SLIDER_CURSOR_ACTIVE = 15;
		public const int NK_COLOR_PROPERTY = 16;
		public const int NK_COLOR_EDIT = 17;
		public const int NK_COLOR_EDIT_CURSOR = 18;
		public const int NK_COLOR_COMBO = 19;
		public const int NK_COLOR_CHART = 20;
		public const int NK_COLOR_CHART_COLOR = 21;
		public const int NK_COLOR_CHART_COLOR_HIGHLIGHT = 22;
		public const int NK_COLOR_SCROLLBAR = 23;
		public const int NK_COLOR_SCROLLBAR_CURSOR = 24;
		public const int NK_COLOR_SCROLLBAR_CURSOR_HOVER = 25;
		public const int NK_COLOR_SCROLLBAR_CURSOR_ACTIVE = 26;
		public const int NK_COLOR_TAB_HEADER = 27;
		public const int NK_COLOR_COUNT = 28;
		public const int NK_CURSOR_ARROW = 0;
		public const int NK_CURSOR_TEXT = 1;
		public const int NK_CURSOR_MOVE = 2;
		public const int NK_CURSOR_RESIZE_VERTICAL = 3;
		public const int NK_CURSOR_RESIZE_HORIZONTAL = 4;
		public const int NK_CURSOR_RESIZE_TOP_LEFT_DOWN_RIGHT = 5;
		public const int NK_CURSOR_RESIZE_TOP_RIGHT_DOWN_LEFT = 6;
		public const int NK_CURSOR_COUNT = 7;
		public const int NK_COORD_UV = 0;
		public const int NK_COORD_PIXEL = 1;
		public const int NK_FONT_ATLAS_ALPHA8 = 0;
		public const int NK_FONT_ATLAS_RGBA32 = 1;
		public const int NK_BUFFER_FIXED = 0;
		public const int NK_BUFFER_DYNAMIC = 1;
		public const int NK_BUFFER_FRONT = 0;
		public const int NK_BUFFER_BACK = 1;
		public const int NK_BUFFER_MAX = 2;
		public const int NK_TEXT_EDIT_SINGLE_LINE = 0;
		public const int NK_TEXT_EDIT_MULTI_LINE = 1;
		public const int NK_TEXT_EDIT_MODE_VIEW = 0;
		public const int NK_TEXT_EDIT_MODE_INSERT = 1;
		public const int NK_TEXT_EDIT_MODE_REPLACE = 2;
		public const int NK_COMMAND_NOP = 0;
		public const int NK_COMMAND_SCISSOR = 1;
		public const int NK_COMMAND_LINE = 2;
		public const int NK_COMMAND_CURVE = 3;
		public const int NK_COMMAND_RECT = 4;
		public const int NK_COMMAND_RECT_FILLED = 5;
		public const int NK_COMMAND_RECT_MULTI_COLOR = 6;
		public const int NK_COMMAND_CIRCLE = 7;
		public const int NK_COMMAND_CIRCLE_FILLED = 8;
		public const int NK_COMMAND_ARC = 9;
		public const int NK_COMMAND_ARC_FILLED = 10;
		public const int NK_COMMAND_TRIANGLE = 11;
		public const int NK_COMMAND_TRIANGLE_FILLED = 12;
		public const int NK_COMMAND_POLYGON = 13;
		public const int NK_COMMAND_POLYGON_FILLED = 14;
		public const int NK_COMMAND_POLYLINE = 15;
		public const int NK_COMMAND_TEXT = 16;
		public const int NK_COMMAND_IMAGE = 17;
		public const int NK_COMMAND_CUSTOM = 18;
		public const int NK_CLIPPING_OFF = Nuklear.nk_false;
		public const int NK_CLIPPING_ON = Nuklear.nk_true;
		public const int NK_STROKE_OPEN = Nuklear.nk_false;
		public const int NK_STROKE_CLOSED = Nuklear.nk_true;
		public const int NK_VERTEX_POSITION = 0;
		public const int NK_VERTEX_COLOR = 1;
		public const int NK_VERTEX_TEXCOORD = 2;
		public const int NK_VERTEX_ATTRIBUTE_COUNT = 3;
		public const int NK_FORMAT_SCHAR = 0;
		public const int NK_FORMAT_SSHORT = 1;
		public const int NK_FORMAT_SINT = 2;
		public const int NK_FORMAT_UCHAR = 3;
		public const int NK_FORMAT_USHORT = 4;
		public const int NK_FORMAT_UINT = 5;
		public const int NK_FORMAT_FLOAT = 6;
		public const int NK_FORMAT_DOUBLE = 7;
		public const int NK_FORMAT_COLOR_BEGIN = 8;
		public const int NK_FORMAT_R8G8B8 = Nuklear.NK_FORMAT_COLOR_BEGIN;
		public const int NK_FORMAT_R16G15B16 = 10;
		public const int NK_FORMAT_R32G32B32 = 11;
		public const int NK_FORMAT_R8G8B8A8 = 12;
		public const int NK_FORMAT_B8G8R8A8 = 13;
		public const int NK_FORMAT_R16G15B16A16 = 14;
		public const int NK_FORMAT_R32G32B32A32 = 15;
		public const int NK_FORMAT_R32G32B32A32_FLOAT = 16;
		public const int NK_FORMAT_R32G32B32A32_DOUBLE = 17;
		public const int NK_FORMAT_RGB32 = 18;
		public const int NK_FORMAT_RGBA32 = 19;
		public const int NK_FORMAT_COLOR_END = Nuklear.NK_FORMAT_RGBA32;
		public const int NK_FORMAT_COUNT = 21;
		public const int NK_STYLE_ITEM_COLOR = 0;
		public const int NK_STYLE_ITEM_IMAGE = 1;
		public const int NK_HEADER_LEFT = 0;
		public const int NK_HEADER_RIGHT = 1;
		public const int NK_PANEL_WINDOW = (1 << (0));
		public const int NK_PANEL_GROUP = (1 << (1));
		public const int NK_PANEL_POPUP = (1 << (2));
		public const int NK_PANEL_CONTEXTUAL = (1 << (4));
		public const int NK_PANEL_COMBO = (1 << (5));
		public const int NK_PANEL_MENU = (1 << (6));
		public const int NK_PANEL_TOOLTIP = (1 << (7));

		public const int NK_PANEL_SET_NONBLOCK =
			Nuklear.NK_PANEL_CONTEXTUAL | Nuklear.NK_PANEL_COMBO | Nuklear.NK_PANEL_MENU | Nuklear.NK_PANEL_TOOLTIP;

		public const int NK_PANEL_SET_POPUP = Nuklear.NK_PANEL_SET_NONBLOCK | Nuklear.NK_PANEL_POPUP;
		public const int NK_PANEL_SET_SUB = Nuklear.NK_PANEL_SET_POPUP | Nuklear.NK_PANEL_GROUP;
		public const int NK_LAYOUT_DYNAMIC_FIXED = 0;
		public const int NK_LAYOUT_DYNAMIC_ROW = 1;
		public const int NK_LAYOUT_DYNAMIC_FREE = 2;
		public const int NK_LAYOUT_DYNAMIC = 3;
		public const int NK_LAYOUT_STATIC_FIXED = 4;
		public const int NK_LAYOUT_STATIC_ROW = 5;
		public const int NK_LAYOUT_STATIC_FREE = 6;
		public const int NK_LAYOUT_STATIC = 7;
		public const int NK_LAYOUT_TEMPLATE = 8;
		public const int NK_LAYOUT_COUNT = 9;
		public const int NK_WINDOW_PRIVATE = (1 << (11));
		public const int NK_WINDOW_DYNAMIC = Nuklear.NK_WINDOW_PRIVATE;
		public const int NK_WINDOW_ROM = (1 << (12));
		public const int NK_WINDOW_NOT_INTERACTIVE = Nuklear.NK_WINDOW_ROM | Nuklear.NK_WINDOW_NO_INPUT;
		public const int NK_WINDOW_HIDDEN = (1 << (13));
		public const int NK_WINDOW_CLOSED = (1 << (14));
		public const int NK_WINDOW_MINIMIZED = (1 << (15));
		public const int NK_WINDOW_REMOVE_ROM = (1 << (16));
		public const int NK_DO_NOT_STOP_ON_NEW_LINE = 0;
		public const int NK_STOP_ON_NEW_LINE = 1;
		public const int NK_RP_HEURISTIC_Skyline_default = 0;
		public const int NK_RP_HEURISTIC_Skyline_BL_sortHeight = Nuklear.NK_RP_HEURISTIC_Skyline_default;
		public const int NK_RP_HEURISTIC_Skyline_BF_sortHeight = 2;
		public const int NK_RP__INIT_skyline = 1;
		public const int NK_TT_vmove = 1;
		public const int NK_TT_vline = 2;
		public const int NK_TT_vcurve = 3;
		public const int NK_TT_PLATFORM_ID_UNICODE = 0;
		public const int NK_TT_PLATFORM_ID_MAC = 1;
		public const int NK_TT_PLATFORM_ID_ISO = 2;
		public const int NK_TT_PLATFORM_ID_MICROSOFT = 3;
		public const int NK_TT_UNICODE_EID_UNICODE_1_0 = 0;
		public const int NK_TT_UNICODE_EID_UNICODE_1_1 = 1;
		public const int NK_TT_UNICODE_EID_ISO_10646 = 2;
		public const int NK_TT_UNICODE_EID_UNICODE_2_0_BMP = 3;
		public const int NK_TT_UNICODE_EID_UNICODE_2_0_FULL = 4;
		public const int NK_TT_MS_EID_SYMBOL = 0;
		public const int NK_TT_MS_EID_UNICODE_BMP = 1;
		public const int NK_TT_MS_EID_SHIFTJIS = 2;
		public const int NK_TT_MS_EID_UNICODE_FULL = 10;
		public const int NK_TT_MAC_EID_ROMAN = 0;
		public const int NK_TT_MAC_EID_ARABIC = 4;
		public const int NK_TT_MAC_EID_JAPANESE = 1;
		public const int NK_TT_MAC_EID_HEBREW = 5;
		public const int NK_TT_MAC_EID_CHINESE_TRAD = 2;
		public const int NK_TT_MAC_EID_GREEK = 6;
		public const int NK_TT_MAC_EID_KOREAN = 3;
		public const int NK_TT_MAC_EID_RUSSIAN = 7;
		public const int NK_TT_MS_LANG_ENGLISH = 0x0409;
		public const int NK_TT_MS_LANG_ITALIAN = 0x0410;
		public const int NK_TT_MS_LANG_CHINESE = 0x0804;
		public const int NK_TT_MS_LANG_JAPANESE = 0x0411;
		public const int NK_TT_MS_LANG_DUTCH = 0x0413;
		public const int NK_TT_MS_LANG_KOREAN = 0x0412;
		public const int NK_TT_MS_LANG_FRENCH = 0x040c;
		public const int NK_TT_MS_LANG_RUSSIAN = 0x0419;
		public const int NK_TT_MS_LANG_GERMAN = 0x0407;
		public const int NK_TT_MS_LANG_SPANISH = 0x0409;
		public const int NK_TT_MS_LANG_HEBREW = 0x040d;
		public const int NK_TT_MS_LANG_SWEDISH = 0x041D;
		public const int NK_TT_MAC_LANG_ENGLISH = 0;
		public const int NK_TT_MAC_LANG_JAPANESE = 11;
		public const int NK_TT_MAC_LANG_ARABIC = 12;
		public const int NK_TT_MAC_LANG_KOREAN = 23;
		public const int NK_TT_MAC_LANG_DUTCH = 4;
		public const int NK_TT_MAC_LANG_RUSSIAN = 32;
		public const int NK_TT_MAC_LANG_FRENCH = 1;
		public const int NK_TT_MAC_LANG_SPANISH = 6;
		public const int NK_TT_MAC_LANG_GERMAN = 2;
		public const int NK_TT_MAC_LANG_SWEDISH = 5;
		public const int NK_TT_MAC_LANG_HEBREW = 10;
		public const int NK_TT_MAC_LANG_CHINESE_SIMPLIFIED = 33;
		public const int NK_TT_MAC_LANG_ITALIAN = 3;
		public const int NK_TT_MAC_LANG_CHINESE_TRAD = 19;
		public const int NK_TOGGLE_CHECK = 0;
		public const int NK_TOGGLE_OPTION = 1;
		public const int NK_PROPERTY_DEFAULT = 0;
		public const int NK_PROPERTY_EDIT = 1;
		public const int NK_PROPERTY_DRAG = 2;
		public const int NK_FILTER_INT = 0;
		public const int NK_FILTER_FLOAT = 1;
		public const int NK_PROPERTY_INT = 0;
		public const int NK_PROPERTY_FLOAT = 1;
		public const int NK_PROPERTY_DOUBLE = 2;
		public const int NK_INSERT_BACK = 0;
		public const int NK_INSERT_FRONT = 1;
	}
}