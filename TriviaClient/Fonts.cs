using System.Drawing;

namespace TriviaClient
{
    public static class CustomFonts
    {
        public const string OpenSans = "Open Sans";
        public const string ArcadeClassic = "ArcadeClassic";
        public const string FiraMono = "Fira Mono";
        public const string Ubuntu = "Ubuntu";
    }
    public static class Fonts
    {
        static Fonts()
        {
            OpenSans = FontManager.GetFontByName(CustomFonts.OpenSans);
            ArcadeClassic = FontManager.GetFontByName(CustomFonts.ArcadeClassic);
            Ubuntu = FontManager.GetFontByName(CustomFonts.Ubuntu);
            FiraMono = FontManager.GetFontByName(CustomFonts.FiraMono);
        }

        public static FontFamily OpenSans { get; private set; }

        public static FontFamily ArcadeClassic { get; private set; }

        public static FontFamily Ubuntu { get; private set; }

        public static FontFamily FiraMono { get; private set; }
    }
}
