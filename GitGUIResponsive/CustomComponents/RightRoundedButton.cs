using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace GitGUIResponsive.CustomComponents
{
    public class RightRoundedButton : Button
    {
        private int borderSize = 0;
        private int borderRadius = 40;
        private Color borderColor = Color.FromArgb(63, 64, 69);

        [Category("Zarko's custom button settings")]
        public int BorderSize { get => borderSize; set { borderSize = value; this.Invalidate(); } }

        [Category("Zarko's custom button settings")]
        public int BorderRadius { get => borderRadius; set { borderRadius = value; this.Invalidate(); } }

        [Category("Zarko's custom button settings")]
        public Color BorderColor { get => borderColor; set { borderColor = value; this.Invalidate(); } }

        [Category("Zarko's custom button settings")]
        public Color BackgroundColor { get => BackColor; set { this.BackColor = value; } }

        [Category("Zarko's custom button settings")]
        public Color TextColor { get => ForeColor; set { this.ForeColor = value; } }

        public RightRoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.FromArgb(63, 64, 69);
            this.ForeColor = Color.White;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Top-left corner (straight line)
            path.StartFigure();
            path.AddLine(rect.X, rect.Y, rect.Width - radius, rect.Y);

            // Top-right corner (rounded)
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);

            // Right side (straight down to bottom-right corner)
            path.AddLine(rect.Width, rect.Y + radius, rect.Width, rect.Height - radius);

            // Bottom-right corner (rounded)
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);

            // Bottom edge to bottom-left corner (straight line)
            path.AddLine(rect.Width - radius, rect.Height, rect.X, rect.Height);

            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectangleSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectangleBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 1);

            //Rounded button
            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectangleSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectangleBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if (borderSize >= 1)
                        e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                this.Region = new Region(rectangleSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
                this.Invalidate();
        }

    }

}
