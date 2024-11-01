namespace GitGUIResponsive
{
    partial class FormWelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcomeScreen));
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            btnLoadRepository = new CustomComponents.RightRoundedButton();
            txtGitFolderPath = new CustomComponents.LeftRoundedTextBox();
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
            panel1.Controls.Add(btnLoadRepository);
            panel1.Controls.Add(txtGitFolderPath);
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
            // btnLoadRepository
            // 
            btnLoadRepository.Anchor = AnchorStyles.None;
            btnLoadRepository.BackColor = Color.FromArgb(63, 64, 69);
            btnLoadRepository.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnLoadRepository.BorderColor = Color.FromArgb(63, 64, 69);
            btnLoadRepository.BorderRadius = 40;
            btnLoadRepository.BorderSize = 0;
            btnLoadRepository.FlatAppearance.BorderSize = 0;
            btnLoadRepository.FlatStyle = FlatStyle.Flat;
            btnLoadRepository.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLoadRepository.ForeColor = Color.White;
            btnLoadRepository.Location = new Point(631, 436);
            btnLoadRepository.Margin = new Padding(0);
            btnLoadRepository.Name = "btnLoadRepository";
            btnLoadRepository.Size = new Size(213, 48);
            btnLoadRepository.TabIndex = 4;
            btnLoadRepository.Text = "Load git repository";
            btnLoadRepository.TextColor = Color.White;
            btnLoadRepository.UseVisualStyleBackColor = false;
            btnLoadRepository.Click += btnLoadRepository_Click;
            // 
            // txtGitFolderPath
            // 
            txtGitFolderPath.Anchor = AnchorStyles.None;
            txtGitFolderPath.BackColor = Color.White;
            txtGitFolderPath.BorderColor = Color.FromArgb(93, 94, 96);
            txtGitFolderPath.BorderRadius = 15;
            txtGitFolderPath.Location = new Point(221, 436);
            txtGitFolderPath.Margin = new Padding(0);
            txtGitFolderPath.Name = "txtGitFolderPath";
            txtGitFolderPath.PlaceholderText = "Enter the path to the folder with an initialized Git repository";
            txtGitFolderPath.Size = new Size(414, 48);
            txtGitFolderPath.TabIndex = 10;
            txtGitFolderPath.TextBoxBackground = Color.White;
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
            // FormWelcomeScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 668);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormWelcomeScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Git GUI app";
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
        private CustomComponents.RightRoundedButton btnLoadRepository;
        private CustomComponents.LeftRoundedTextBox txtGitFolderPath;
        private Panel panel2;
        private Label label5;
    }
}
