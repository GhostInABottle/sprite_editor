using System;
using System.Drawing;
using System.IO;
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
                using var stream = File.Open(filename, FileMode.Open,
                    FileAccess.Read, FileShare.ReadWrite);
                return new Bitmap(stream);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}