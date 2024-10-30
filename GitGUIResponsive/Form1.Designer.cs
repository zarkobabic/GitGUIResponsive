namespace GitGUIResponsive
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            rightRoundedButton1 = new CustomComponents.RightRoundedButton();
            leftRoundedTextBox1 = new CustomComponents.LeftRoundedTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(rightRoundedButton1);
            panel1.Controls.Add(leftRoundedTextBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1055, 668);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(63, 64, 69);
            panel2.Controls.Add(label5);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 626);
            panel2.Name = "panel2";
            panel2.Size = new Size(1055, 42);
            panel2.TabIndex = 11;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(381, 10);
            label5.Name = "label5";
            label5.Size = new Size(313, 18);
            label5.TabIndex = 13;
            label5.Text = "All rights reserved | Schneider electric";
            // 
            // rightRoundedButton1
            // 
            rightRoundedButton1.Anchor = AnchorStyles.None;
            rightRoundedButton1.BackColor = Color.FromArgb(63, 64, 69);
            rightRoundedButton1.BackgroundColor = Color.FromArgb(63, 64, 69);
            rightRoundedButton1.BorderColor = Color.FromArgb(63, 64, 69);
            rightRoundedButton1.BorderRadius = 40;
            rightRoundedButton1.BorderSize = 0;
            rightRoundedButton1.FlatAppearance.BorderSize = 0;
            rightRoundedButton1.FlatStyle = FlatStyle.Flat;
            rightRoundedButton1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rightRoundedButton1.ForeColor = Color.White;
            rightRoundedButton1.Location = new Point(631, 436);
            rightRoundedButton1.Margin = new Padding(0);
            rightRoundedButton1.Name = "rightRoundedButton1";
            rightRoundedButton1.Size = new Size(213, 48);
            rightRoundedButton1.TabIndex = 4;
            rightRoundedButton1.Text = "Load git repository";
            rightRoundedButton1.TextColor = Color.White;
            rightRoundedButton1.UseVisualStyleBackColor = false;
            rightRoundedButton1.Click += rightRoundedButton1_Click;
            // 
            // leftRoundedTextBox1
            // 
            leftRoundedTextBox1.Anchor = AnchorStyles.None;
            leftRoundedTextBox1.BackColor = Color.White;
            leftRoundedTextBox1.BorderColor = Color.FromArgb(93, 94, 96);
            leftRoundedTextBox1.BorderRadius = 15;
            leftRoundedTextBox1.Location = new Point(221, 436);
            leftRoundedTextBox1.Margin = new Padding(0);
            leftRoundedTextBox1.Name = "leftRoundedTextBox1";
            leftRoundedTextBox1.PlaceholderText = "Enter the path to the folder with an initialized Git repository";
            leftRoundedTextBox1.Size = new Size(414, 48);
            leftRoundedTextBox1.TabIndex = 10;
            leftRoundedTextBox1.TextBoxBackground = Color.White;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(63, 64, 69);
            label3.Location = new Point(221, 353);
            label3.Name = "label3";
            label3.Size = new Size(623, 68);
            label3.TabIndex = 2;
            label3.Text = "To start enter the path to the folder with an initialized Git repository in the input field below";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(61, 205, 88);
            label2.Location = new Point(328, 325);
            label2.Name = "label2";
            label2.Size = new Size(426, 27);
            label2.TabIndex = 1;
            label2.Text = "This project is fully functional git GUI ";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 50F);
            label1.ForeColor = Color.FromArgb(63, 64, 69);
            label1.Location = new Point(335, 198);
            label1.Name = "label1";
            label1.Size = new Size(410, 89);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 668);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private CustomComponents.RightRoundedButton rightRoundedButton1;
        private CustomComponents.LeftRoundedTextBox leftRoundedTextBox1;
        private Panel panel2;
        private Label label5;
    }
}
