using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

        private static void LoadFontFromResource(string fontFileName)
        {
            string resourceName = $"Bibliothek.Resources.{fontFileName}"; // Passe den Namespace an

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
