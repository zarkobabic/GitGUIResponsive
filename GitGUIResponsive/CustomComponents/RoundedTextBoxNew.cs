using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitGUIResponsive.CustomComponents
{
    public class RoundedTextBoxNew : Control
    {
        private TextBox textBox;
        private int borderRadius = 15;
        private Color borderColor = Color.FromArgb(180, 180, 180);
        private float borderThickness = 1.5f;

        public RoundedTextBoxNew()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                TextAlign = HorizontalAlignment.Center,
                BackColor = Color.White,
                Location = new Point(10, 5),
                Anchor = AnchorStyles.Left | AnchorStyles.Right
            };

            Controls.Add(textBox);
            BackColor = Color.White;
            Size = new Size(150, 30);

            // Handle click on the control to focus the textbox
            Click += (s, e) => textBox.Focus();
            textBox.TextChanged += (s, e) => OnTextChanged(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox.Width = Width - 20;
            // Center the textbox vertically
            textBox.Top = (Height - textBox.Height) / 2;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = new GraphicsPath())
            {
                var rect = ClientRectangle;
                rect.Inflate(-2, -2);
                int diameter = borderRadius * 2;

                // Draw the rounded rectangle
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                // Fill background
                using (var brush = new SolidBrush(BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }

                // Draw border
                using (var pen = new Pen(borderColor, borderThickness))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }

        // Essential properties
        [Browsable(true)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [Browsable(true)]
        public Color BorderColor
        {
            get => borderColor;
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        [Browsable(true)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }
    }
}
