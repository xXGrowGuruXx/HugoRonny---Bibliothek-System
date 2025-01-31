using System.Drawing.Text;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Bibliothek.utils
{
    internal class CustomFonts
    {
        private static PrivateFontCollection _fontCollection = new PrivateFontCollection();

        public static void LoadSchriftarten()
        {
            string[] fonts = {
                "Vacaciones-font-ffp-defharo.ttf"
            };

            foreach (string font in fonts)
            {
                LoadFontFromResource(font);
            }
        }

        [DllImport("gdi32.dll")]
        private static extern int AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, ref uint pcFonts);

        private static void LoadFontFromResource(string fontFileName)
        {
            string resourceName = $"Bibliothek.Resources.{fontFileName}";

            using (Stream fontStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                if (fontStream == null)
                {
                    throw new FileNotFoundException($"Die Ressource {resourceName} wurde nicht gefunden.");
                }

                byte[] fontData = new byte[fontStream.Length];
                fontStream.Read(fontData, 0, fontData.Length);

                IntPtr fontPtr = Marshal.AllocCoTaskMem(fontData.Length);
                Marshal.Copy(fontData, 0, fontPtr, fontData.Length);

                _fontCollection.AddMemoryFont(fontPtr, fontData.Length);

                // Windows mitteilen, dass eine neue Schrift geladen wurde
                uint dummy = 0;
                AddFontMemResourceEx(fontPtr, (uint)fontData.Length, IntPtr.Zero, ref dummy);

                Marshal.FreeCoTaskMem(fontPtr);
            }
        }

        public static Font GetCustomFont(string fontName, float fontSize, FontStyle style = FontStyle.Regular)
        {
            FontFamily fontFamily = _fontCollection.Families.FirstOrDefault(f => f.Name == fontName);

            if (fontFamily == null)
            {
                throw new Exception($"Die Schriftart {fontName} ist nicht in der Sammlung geladen.");
            }

            return new Font(fontFamily, fontSize, style);
        }
    }
}
