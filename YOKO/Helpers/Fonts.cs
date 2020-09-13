using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOKO.Helpers
{
    public class Fonts
    {
        private static int fontSizeRegular = 10;
        private static int fontSizeLarge = 14;

        public static Font sanSerifbold = new Font(FontFamily.GenericSansSerif, fontSizeRegular, FontStyle.Bold, GraphicsUnit.Point);
        public static Font sanSerifRegular = new Font(FontFamily.GenericSansSerif, fontSizeRegular, FontStyle.Regular, GraphicsUnit.Point);
        public static Font sanSerifItalic = new Font(FontFamily.GenericSansSerif, fontSizeRegular, FontStyle.Italic, GraphicsUnit.Point);
        public static Font sanSerifUnderline = new Font(FontFamily.GenericSansSerif, fontSizeRegular, FontStyle.Underline, GraphicsUnit.Point);

        public static Font sanSerifboldLarge = new Font(FontFamily.GenericSansSerif, fontSizeLarge, FontStyle.Bold, GraphicsUnit.Point);
        public static Font sanSerifRegularLarge = new Font(FontFamily.GenericSansSerif, fontSizeLarge, FontStyle.Regular, GraphicsUnit.Point);
        public static Font sanSerifItalicLarge = new Font(FontFamily.GenericSansSerif, fontSizeLarge, FontStyle.Italic, GraphicsUnit.Point);
        public static Font sanSerifUnderlineLarge = new Font(FontFamily.GenericSansSerif, fontSizeLarge, FontStyle.Underline, GraphicsUnit.Point);
    }
}
