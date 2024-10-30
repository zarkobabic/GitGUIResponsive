using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GitGUIResponsive.CustomComponents
{

    public class RoundedTextBox : TextBox
    {
        private int radius = 15;
        private int padding = 5;

        public RoundedTextBox()
        {
            // Enable custom painting
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);

            // Set default properties
            BorderStyle = BorderStyle.None;
            BackColor = Color.White;
            Padding = new Padding(padding);
        }

        public int BorderRadius
        {
            get => radius;
            set
            {
                radius = value;
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var path = GetRoundedPath())
            using (var pen = new Pen(Color.FromArgb(180, 180, 180), 1.0f))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Draw background
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Draw border
                e.Graphics.DrawPath(pen, path);

                // Draw text
                TextRenderer.DrawText(
                    e.Graphics,
                    Text,
                    Font,
                    new Rectangle(padding, padding, Width - (padding * 2), Height - (padding * 2)),
                    ForeColor,
                    BackColor,
                    TextFormatFlags.Default
                );
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Invalidate();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Invalidate();
        }

        private GraphicsPath GetRoundedPath()
        {
            var rect = new Rectangle(0, 0, Width - 1, Height - 1);
            var path = new GraphicsPath();

            // Top left arc
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);

            // Top right arc
            path.AddArc(rect.Width - (radius * 2), rect.Y, radius * 2, radius * 2, 270, 90);

            // Bottom right arc
            path.AddArc(rect.Width - (radius * 2), rect.Height - (radius * 2), radius * 2, radius * 2, 0, 90);

            // Bottom left arc
            path.AddArc(rect.X, rect.Height - (radius * 2), radius * 2, radius * 2, 90, 90);

            path.CloseFigure();
            return path;
        }
    }
}