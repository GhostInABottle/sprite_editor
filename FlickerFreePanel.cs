﻿using System.Windows.Forms;

namespace SpriteEditor
{
    public class FlickerFreePanel : Panel
    {
        public FlickerFreePanel()
        {
            DoubleBuffered = true;
        }
    }
}
