using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace SpriteEditor
{
    class FlickerFreePanel : Panel
    {
        public FlickerFreePanel() : base()
        {
            DoubleBuffered = true;
        }
    }
}
