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
    public class RoundedTextBoxFinal : Control
    {
        private TextBox textBox;
        private int borderRadius = 15;
        private Color borderColor = Color.FromArgb(180, 180, 180);
        private float borderThickness = 2f;
        private bool centerText = true;
        private Color backgroundColor = Color.White;

        public RoundedTextBoxFinal()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.ResizeRedraw, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                BackColor = backgroundColor,
                Font = Font,
                Location = new Point(10, 5),
                Width = Width - 20
            };

            Controls.Add(textBox);
            BackColor = backgroundColor;
            ForeColor = Color.Black;
            Size = new Size(150, 30);

            textBox.TextChanged += (s, e) => OnTextChanged(e);
            textBox.TextChanged += TextBox_TextChanged;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Multiline && centerText)
                CenterTextVertically();
        }

        private void CenterTextVertically()
        {
            if (!Multiline) return;

            // Calculate the total height of the text
            var numberOfLines = textBox.GetLineFromCharIndex(textBox.TextLength) + 1;
            var textHeight = textBox.Font.Height * numberOfLines;

            // Calculate padding to center the text
            var paddingTop = (Height - textHeight) / 2;
            if (paddingTop < 10) paddingTop = 10; // Minimum padding

            textBox.Location = new Point(10, paddingTop);
        }

        [Browsable(true)]
        public bool CenterInMultiline
        {
            get => centerText;
            set
            {
                centerText = value;
                if (Multiline)
                    CenterTextVertically();
            }
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

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            textBox.Width = Width - 20;
            if (Multiline && centerText)
                CenterTextVertically();
            else
                textBox.Height = Height - 10;
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
        public bool Multiline
        {
            get => textBox.Multiline;
            set
            {
                textBox.Multiline = value;
                if (value)
                {
                    Size = new Size(Size.Width, Size.Height * 2);
                    if (centerText)
                        CenterTextVertically();
                }
                else
                {
                    Size = new Size(Size.Width, 30);
                    textBox.Location = new Point(10, 5);
                }
            }
        }

        [Browsable(true)]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                textBox.Font = value;
                if (Multiline && centerText)
                    CenterTextVertically();
                Invalidate();
            }
        }
    }
}
