using System;
using System.Drawing;
using System.Drawing.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace TriviaClient
{
    internal static class FontManager
    {
        private static readonly PrivateFontCollection fontCollection;  // create your private font collection object
        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        static FontManager()
        {
            fontCollection = new PrivateFontCollection();

            LoadFont(Properties.Resources.FontFiraMono);
            LoadFont(Properties.Resources.FontUbuntu);
            LoadFont(Properties.Resources.FontArcade);
            LoadFont(Properties.Resources.FontOpenSans);
        }

        /// <summary>
        /// Load custom font to program memory
        /// </summary>
        /// <param name="selectedFont">The file (Properties.Resources.XXX) of the font</param>
        internal static void LoadFont(byte[] selectedFont)
        {
            uint c = 0;
            IntPtr data;

            // select your font from the resources.
            int fontLength = selectedFont.Length;

            // create a buffer to read in to
            byte[] fontData = selectedFont;

            // create an unsafe memory block for the font data
            data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontData, 0, data, fontLength);

            // register the font to the system
            AddFontMemResourceEx(data, (uint)fontLength, IntPtr.Zero, ref c);

            // pass the font to the font collection
            fontCollection.AddMemoryFont(data, fontLength);

            //free the unsafe memory to avoid memory leaks
            Marshal.FreeCoTaskMem(data);
        }

        /// <summary>
        /// Returns the requested font by his name
        /// </summary>
        /// <param name="name">font name</param>
        /// <returns>requested font</returns>
        /// <exception cref="Exception">Requested font was not loaded before</exception>
        internal static FontFamily GetFontByName(string name)
        {
            foreach (FontFamily family in fontCollection.Families)
            {
                if (family.Name == name)
                    return family;
            }

            throw new Exception("Font does not exist in font collection");
        }

        /// <summary>
        /// Set custom font to the requested label
        /// </summary>
        /// <param name="font">Custom font to set</param>
        /// <param name="label">Requested label to set his font</param>
        internal static void SetFont(this FontFamily font, params Control[] controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView view)
                {

                    view.ColumnHeadersDefaultCellStyle.Font = view.ColumnHeadersDefaultCellStyle.Font.Bold
                        ? new Font(font, view.ColumnHeadersDefaultCellStyle.Font.Size, FontStyle.Bold)
                        : new Font(font, view.ColumnHeadersDefaultCellStyle.Font.Size, FontStyle.Regular);
                }
                else
                {
                    control.Font = control.Font.Bold ? new Font(font, control.Font.Size, FontStyle.Bold) : new Font(font, control.Font.Size, FontStyle.Regular);
                }
            }
        }
    }
}
