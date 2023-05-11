using System;
using System.Drawing;
using System.Runtime.Versioning;

namespace SpriteEditor
{
    public static class BitmapHelpers
    {
        [SupportedOSPlatform("windows")]
        public static Bitmap OpenBitmap(SpriteLogic spriteLogic, string filename)
        {
            if (string.IsNullOrEmpty(filename)) return null;

            filename = spriteLogic.ResolvePath(filename);
            try
            {
                using var tempBitmap = new Bitmap(filename);
                return new Bitmap(tempBitmap);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}