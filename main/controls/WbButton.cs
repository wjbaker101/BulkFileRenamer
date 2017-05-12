using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BulkFileNamer.main.controls
{
    public class WbButton : Button
    {
        private Color borderColour;
        private Color hoverColour;
        private Color disabledColour;

        private bool mouseOver;

        private Timer animationTimer;

        public WbButton()
        {
            animationTimer = new Timer();
            animationTimer.Interval = 100;
            animationTimer.Tick += AnimationTimer_Tick;

            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.BorderColour = Color.FromArgb(23, 107, 192);
            this.HoverColour = Color.FromArgb(220, 225, 235);
            this.disabledColour = Color.FromArgb(244, 246, 249);

            this.Cursor = Cursors.Hand;
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

            e.Graphics.FillRectangle(new SolidBrush(!this.Enabled ? this.DisabledColour : this.IsMouseOver ? this.HoverColour : this.BackColor), 0, 0, this.Width, this.Height);
            e.Graphics.DrawRectangle(new Pen(this.BorderColour), 0, 0, this.Width - 1, this.Height - 1);

            e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), (int)((this.Width / 2.0F) - (TextRenderer.MeasureText(this.Text, this.Font).Width / 2.0F)), (int)((this.Height / 2.0F) - (TextRenderer.MeasureText(this.Text, this.Font).Height / 2.0F)));

            if (this.Image != null)
            {
                e.Graphics.DrawImage(this.Image, (int)((this.Width / 2.0F) - (this.Image.Width / 2.0F)), (int)((this.Height / 2.0F) - (this.Image.Height / 2.0F)));
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            mouseOver = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            mouseOver = false;
        }

        [System.ComponentModel.Category("Appearance")]
        public Color BorderColour
        {
            get { return this.borderColour; }
            set { this.borderColour = value; }
        }

        [System.ComponentModel.Category("Appearance")]
        public Color HoverColour
        {
            get { return this.hoverColour; }
            set { this.hoverColour = value; }
        }

        [System.ComponentModel.Category("Appearance")]
        public Color DisabledColour
        {
            get { return this.disabledColour; }
            set { this.disabledColour = value; }
        }

        [System.ComponentModel.Category("Behaviour")]
        public bool IsMouseOver
        {
            get { return this.mouseOver; }
        }
    }
}
