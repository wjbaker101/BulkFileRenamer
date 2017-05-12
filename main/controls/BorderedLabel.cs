using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BulkFileNamer.main.controls
{
    public class BorderedLabel : Label
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                Color.Transparent, 5, ButtonBorderStyle.Solid,
                Color.Transparent, 5, ButtonBorderStyle.Solid,
                Color.Transparent, 5, ButtonBorderStyle.Solid,
                Color.FromArgb(84, 107, 150), 1, ButtonBorderStyle.Solid);
        }
    }
}
