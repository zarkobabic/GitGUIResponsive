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
    public class RoundedTextBoxSingleLine : Control
    {
        private TextBox textBox;
        private int borderRadius = 15;
        private Color borderColor = Color.FromArgb(180, 180, 180);
        private float borderThickness = 1.5f;

        public RoundedTextBoxSingleLine()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = BackColor,
                Font = Font,
                Location = new Point(10, 0),
                AutoSize = false,
                TextAlign = HorizontalAlignment.Left
            };

            Controls.Add(textBox);
            BackColor = Color.White;
            ForeColor = Color.Black;
            Size = new Size(150, 30);

            textBox.TextChanged += (s, e) => OnTextChanged(e);

            // Make the entire control clickable
            Click += (s, e) => textBox.Focus();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox.Width = Width - 20;
            textBox.Height = Height;
            UpdateTextBoxPosition();
        }

        private void UpdateTextBoxPosition()
        {
            // Calculate the height of the text
            int textHeight = TextRenderer.MeasureText("Tg", Font).Height;

            // Calculate padding to center the text vertically
            int paddingTop = (Height - textHeight) / 2;

            // Set the TextBox padding to center the text
            textBox.Padding = new Padding(0, paddingTop, 0, 0);
        }

        // Properties to expose TextBox functionality
        [Browsable(true)]
        public override string Text
        {
            get => textBox.Text;
            set => textBox.Text = value;
        }

        [Browsable(true)]
        public int BorderRadius
        {
            get => borderRadius;
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    Invalidate();
                }
            }
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

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (var path = GetRoundedPath())
            {
                // Draw background
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

        private GraphicsPath GetRoundedPath()
        {
            var rect = ClientRectangle;
            rect.Inflate(-2, -2);
            var path = new GraphicsPath();

            if (borderRadius > 0)
            {
                int diameter = Math.Min(borderRadius * 2, Math.Min(rect.Width, rect.Height));
                var arc = new Rectangle(rect.Location, new Size(diameter, diameter));

                // Top left arc
                path.AddArc(arc, 180, 90);

                // Top right arc
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);

                // Bottom right arc
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // Bottom left arc
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
            }
            else
            {
                path.AddRectangle(rect);
            }

            return path;
        }

        [Browsable(true)]
        public string SelectedText
        {
            get => textBox.SelectedText;
            set => textBox.SelectedText = value;
        }

        [Browsable(true)]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;
                UpdateTextBoxPosition();
                Invalidate();
            }
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            textBox.Focus();
        }
    }
}
