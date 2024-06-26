﻿using SpriteEditor.Models;
using System.Drawing;
using System.Runtime.Versioning;

namespace SpriteEditor
{
    /// <summary>
    /// Find poses having frames where not all the edges are transparent.
    /// These frames cause wrapping issues in OpenGL when the texture is magnified.
    /// </summary>
    [SupportedOSPlatform("windows")]
    public class FrameEdgeChecker
    {
        public static void Check(SpriteLogic spriteLogic)
        {
            var oldPose = spriteLogic.CurrentPose?.NameWithTags();
            var spriteData = spriteLogic.SpriteData;
            for (int pi = 0; pi < spriteData.Poses.Count; pi++)
            {
                var pose = spriteData.Poses[pi];
                for (int fi = 0; fi < pose.Frames.Count; fi++)
                {
                    spriteLogic.SetPose(pose.NameWithTags(), 0);
                    spriteLogic.SetFrame(fi);

                    using var bitmap = BitmapHelpers.OpenBitmap(spriteLogic, spriteLogic.Image);

                    var transparentColorHex = spriteLogic.TransparentColorHex;
                    if (string.IsNullOrEmpty(transparentColorHex)) continue;

                    var transparentColor = Utilities.FromHex(transparentColorHex);
                    var frame = pose.Frames[fi];
                    var edge = CheckFrame(frame, bitmap, transparentColor);
                    if (edge == null) continue;

                    pose.EdgeCheckFrameIndex = (fi + 1, edge);
                    break;
                }
            }

            if (oldPose != null)
            {
                spriteLogic.SetPose(oldPose, 0);
            }

            spriteLogic.Reset(0);
        }

        private static bool IsTransparent(Bitmap bitmap, int x, int y, Color transparentColor)
        {
            var pixel = bitmap.GetPixel(x, y);
            return pixel.A == 0 || pixel == transparentColor;
        }

        private static string CheckFrame(Frame frame, Bitmap bitmap, Color transparentColor)
        {
            if (bitmap == null) return null;

            var sx = frame.Rectangle.X;
            var sy = frame.Rectangle.Y;
            var width = frame.Rectangle.Width;
            var height = frame.Rectangle.Height;
            for (int x = sx; x < sx + width; x++)
            {
                if (!IsTransparent(bitmap, x, sy, transparentColor)) return "T";
                if (!IsTransparent(bitmap, x, sy + height - 1, transparentColor)) return "B";
            }

            for (int y = sy; y < sy + height; y++)
            {
                if (!IsTransparent(bitmap, sx, y, transparentColor)) return "L";
                if (!IsTransparent(bitmap, sx + width - 1, y, transparentColor)) return "R";
            }

            return null;
        }
    }
}
