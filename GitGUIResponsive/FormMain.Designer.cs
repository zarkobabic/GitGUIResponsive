namespace GitGUIResponsive
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMainContainer = new Panel();
            tblPanelGitStatus = new TableLayoutPanel();
            panel3 = new Panel();
            panel17 = new Panel();
            lblGitStatusHeading = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            panel6 = new Panel();
            btnGitPush = new CustomComponents.RoundedButtonNew();
            panel7 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel8 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel12 = new Panel();
            txtCommitMsg = new CustomComponents.LeftRoundedTextBox();
            panel16 = new Panel();
            btnGitCommit = new CustomComponents.RightRoundedButton();
            lblGitCommitHeader = new Label();
            panel9 = new Panel();
            panel13 = new Panel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtFilePathToGitRestore = new CustomComponents.LeftRoundedTextBox();
            btnGitRestore = new CustomComponents.RightRoundedButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            btnGitRestoreAll = new CustomComponents.RoundedButtonNew();
            lblGitRestoreHeader = new Label();
            panel10 = new Panel();
            panel14 = new Panel();
            tableLayoutPanel6 = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            btnGitAdd = new CustomComponents.RightRoundedButton();
            txtFilePathToGitAdd = new CustomComponents.LeftRoundedTextBox();
            tableLayoutPanel8 = new TableLayoutPanel();
            btnGitAddAll = new CustomComponents.RoundedButtonNew();
            lblGitAddHeader = new Label();
            panel11 = new Panel();
            panel15 = new Panel();
            tableLayoutPanel9 = new TableLayoutPanel();
            btnGitStashApply = new CustomComponents.RoundedButtonNew();
            btnGitStashPop = new CustomComponents.RoundedButtonNew();
            btnGitStash = new CustomComponents.RoundedButtonNew();
            lblGitStashHeader = new Label();
            pnlNavbar = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            lblCurrentBranch = new Label();
            lblCurrentBranchHeading = new Label();
            panel1 = new Panel();
            btnGitCherryPick = new CustomComponents.RoundedButton();
            btnGitLog = new CustomComponents.RoundedButton();
            btnGitBranch = new CustomComponents.RoundedButton();
            btnGitStatus = new CustomComponents.RoundedButton();
            pnlMainContainer.SuspendLayout();
            tblPanelGitStatus.SuspendLayout();
            panel3.SuspendLayout();
            panel17.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel8.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel12.SuspendLayout();
            panel16.SuspendLayout();
            panel9.SuspendLayout();
            panel13.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel10.SuspendLayout();
            panel14.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            panel11.SuspendLayout();
            panel15.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            pnlNavbar.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMainContainer
            // 
            pnlMainContainer.Controls.Add(tblPanelGitStatus);
            pnlMainContainer.Controls.Add(pnlNavbar);
            pnlMainContainer.Dock = DockStyle.Fill;
            pnlMainContainer.Location = new Point(0, 0);
            pnlMainContainer.Name = "pnlMainContainer";
            pnlMainContainer.Padding = new Padding(20);
            pnlMainContainer.Size = new Size(1174, 742);
            pnlMainContainer.TabIndex = 0;
            // 
            // tblPanelGitStatus
            // 
            tblPanelGitStatus.ColumnCount = 2;
            tblPanelGitStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 59.02896F));
            tblPanelGitStatus.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.97104F));
            tblPanelGitStatus.Controls.Add(panel3, 0, 0);
            tblPanelGitStatus.Controls.Add(panel7, 1, 0);
            tblPanelGitStatus.Dock = DockStyle.Fill;
            tblPanelGitStatus.Location = new Point(20, 127);
            tblPanelGitStatus.Margin = new Padding(0);
            tblPanelGitStatus.Name = "tblPanelGitStatus";
            tblPanelGitStatus.RowCount = 1;
            tblPanelGitStatus.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPanelGitStatus.Size = new Size(1134, 595);
            tblPanelGitStatus.TabIndex = 3;
            tblPanelGitStatus.Paint += tblPanelGitStatus_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel17);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(0, 0, 10, 0);
            panel3.Size = new Size(663, 589);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // panel17
            // 
            panel17.Controls.Add(lblGitStatusHeading);
            panel17.Dock = DockStyle.Top;
            panel17.Location = new Point(0, 0);
            panel17.Name = "panel17";
            panel17.Padding = new Padding(0, 3, 0, 0);
            panel17.Size = new Size(653, 49);
            panel17.TabIndex = 4;
            // 
            // lblGitStatusHeading
            // 
            lblGitStatusHeading.BackColor = Color.FromArgb(61, 205, 88);
            lblGitStatusHeading.Dock = DockStyle.Fill;
            lblGitStatusHeading.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGitStatusHeading.ForeColor = Color.White;
            lblGitStatusHeading.Location = new Point(0, 3);
            lblGitStatusHeading.Name = "lblGitStatusHeading";
            lblGitStatusHeading.Size = new Size(653, 46);
            lblGitStatusHeading.TabIndex = 0;
            lblGitStatusHeading.Text = "Git status:";
            lblGitStatusHeading.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(0, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(653, 526);
            textBox1.TabIndex = 3;
            textBox1.Text = "asdsdasd";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel6);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 526);
            panel4.Name = "panel4";
            panel4.Size = new Size(653, 63);
            panel4.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnGitPush);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(208, 63);
            panel6.TabIndex = 4;
            // 
            // btnGitPush
            // 
            btnGitPush.BackColor = Color.FromArgb(63, 64, 69);
            btnGitPush.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitPush.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitPush.BorderRadius = 20;
            btnGitPush.BorderSize = 0;
            btnGitPush.FlatAppearance.BorderSize = 0;
            btnGitPush.FlatStyle = FlatStyle.Flat;
            btnGitPush.Font = new Font("Arial Rounded MT Bold", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitPush.ForeColor = Color.White;
            btnGitPush.Location = new Point(0, 12);
            btnGitPush.Name = "btnGitPush";
            btnGitPush.Size = new Size(208, 50);
            btnGitPush.TabIndex = 1;
            btnGitPush.Text = "Git push";
            btnGitPush.TextColor = Color.White;
            btnGitPush.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(672, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(459, 589);
            panel7.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel8, 0, 0);
            tableLayoutPanel1.Controls.Add(panel9, 0, 1);
            tableLayoutPanel1.Controls.Add(panel10, 0, 2);
            tableLayoutPanel1.Controls.Add(panel11, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(459, 589);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Controls.Add(tableLayoutPanel2);
            panel8.Controls.Add(lblGitCommitHeader);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(453, 153);
            panel8.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.Controls.Add(panel12, 0, 0);
            tableLayoutPanel2.Controls.Add(panel16, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 46);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(453, 107);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel12
            // 
            panel12.Controls.Add(txtCommitMsg);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Padding = new Padding(5, 5, 0, 5);
            panel12.Size = new Size(311, 101);
            panel12.TabIndex = 0;
            // 
            // txtCommitMsg
            // 
            txtCommitMsg.BackColor = Color.White;
            txtCommitMsg.BorderColor = Color.FromArgb(63, 64, 69);
            txtCommitMsg.BorderRadius = 15;
            txtCommitMsg.Dock = DockStyle.Fill;
            txtCommitMsg.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCommitMsg.Location = new Point(5, 5);
            txtCommitMsg.Margin = new Padding(0);
            txtCommitMsg.Name = "txtCommitMsg";
            txtCommitMsg.PlaceholderText = "Enter the commit message";
            txtCommitMsg.Size = new Size(306, 91);
            txtCommitMsg.TabIndex = 2;
            txtCommitMsg.TextBoxBackground = Color.White;
            // 
            // panel16
            // 
            panel16.Controls.Add(btnGitCommit);
            panel16.Dock = DockStyle.Fill;
            panel16.Location = new Point(320, 3);
            panel16.Name = "panel16";
            panel16.Padding = new Padding(0, 5, 5, 5);
            panel16.Size = new Size(130, 101);
            panel16.TabIndex = 1;
            // 
            // btnGitCommit
            // 
            btnGitCommit.BackColor = Color.FromArgb(63, 64, 69);
            btnGitCommit.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitCommit.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitCommit.BorderRadius = 40;
            btnGitCommit.BorderSize = 0;
            btnGitCommit.Dock = DockStyle.Fill;
            btnGitCommit.FlatAppearance.BorderSize = 0;
            btnGitCommit.FlatStyle = FlatStyle.Flat;
            btnGitCommit.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitCommit.ForeColor = Color.White;
            btnGitCommit.Location = new Point(0, 5);
            btnGitCommit.Margin = new Padding(0, 3, 3, 3);
            btnGitCommit.Name = "btnGitCommit";
            btnGitCommit.Size = new Size(125, 91);
            btnGitCommit.TabIndex = 2;
            btnGitCommit.Text = "Git commit";
            btnGitCommit.TextColor = Color.White;
            btnGitCommit.UseVisualStyleBackColor = false;
            btnGitCommit.Click += rightRoundedButton1_Click;
            // 
            // lblGitCommitHeader
            // 
            lblGitCommitHeader.BackColor = Color.FromArgb(61, 205, 88);
            lblGitCommitHeader.Dock = DockStyle.Top;
            lblGitCommitHeader.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGitCommitHeader.ForeColor = Color.White;
            lblGitCommitHeader.Location = new Point(0, 0);
            lblGitCommitHeader.Margin = new Padding(0);
            lblGitCommitHeader.Name = "lblGitCommitHeader";
            lblGitCommitHeader.Size = new Size(453, 46);
            lblGitCommitHeader.TabIndex = 4;
            lblGitCommitHeader.Text = "Git commit:";
            lblGitCommitHeader.TextAlign = ContentAlignment.MiddleCenter;
            lblGitCommitHeader.Click += label1_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(panel13);
            panel9.Controls.Add(lblGitRestoreHeader);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 162);
            panel9.Name = "panel9";
            panel9.Size = new Size(453, 153);
            panel9.TabIndex = 1;
            // 
            // panel13
            // 
            panel13.Controls.Add(tableLayoutPanel3);
            panel13.Dock = DockStyle.Fill;
            panel13.Location = new Point(0, 46);
            panel13.Name = "panel13";
            panel13.Padding = new Padding(10);
            panel13.Size = new Size(453, 107);
            panel13.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel5, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(10, 10);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(433, 87);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.Controls.Add(txtFilePathToGitRestore, 0, 0);
            tableLayoutPanel4.Controls.Add(btnGitRestore, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(433, 43);
            tableLayoutPanel4.TabIndex = 0;
            // 
            // txtFilePathToGitRestore
            // 
            txtFilePathToGitRestore.BackColor = Color.White;
            txtFilePathToGitRestore.BorderColor = Color.FromArgb(63, 64, 69);
            txtFilePathToGitRestore.BorderRadius = 15;
            txtFilePathToGitRestore.Dock = DockStyle.Fill;
            txtFilePathToGitRestore.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilePathToGitRestore.Location = new Point(3, 3);
            txtFilePathToGitRestore.Margin = new Padding(3, 3, 0, 3);
            txtFilePathToGitRestore.Name = "txtFilePathToGitRestore";
            txtFilePathToGitRestore.PlaceholderText = "Enter the path of the file to restore";
            txtFilePathToGitRestore.Size = new Size(300, 37);
            txtFilePathToGitRestore.TabIndex = 4;
            txtFilePathToGitRestore.TextBoxBackground = Color.White;
            // 
            // btnGitRestore
            // 
            btnGitRestore.BackColor = Color.FromArgb(63, 64, 69);
            btnGitRestore.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitRestore.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitRestore.BorderRadius = 35;
            btnGitRestore.BorderSize = 0;
            btnGitRestore.Dock = DockStyle.Fill;
            btnGitRestore.FlatAppearance.BorderSize = 0;
            btnGitRestore.FlatStyle = FlatStyle.Flat;
            btnGitRestore.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitRestore.ForeColor = Color.White;
            btnGitRestore.Location = new Point(303, 3);
            btnGitRestore.Margin = new Padding(0, 3, 3, 3);
            btnGitRestore.Name = "btnGitRestore";
            btnGitRestore.Size = new Size(127, 37);
            btnGitRestore.TabIndex = 3;
            btnGitRestore.Text = "Git restore";
            btnGitRestore.TextColor = Color.White;
            btnGitRestore.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Controls.Add(btnGitRestoreAll, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 46);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(427, 38);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // btnGitRestoreAll
            // 
            btnGitRestoreAll.BackColor = Color.FromArgb(63, 64, 69);
            btnGitRestoreAll.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitRestoreAll.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitRestoreAll.BorderRadius = 15;
            btnGitRestoreAll.BorderSize = 0;
            btnGitRestoreAll.Dock = DockStyle.Fill;
            btnGitRestoreAll.FlatAppearance.BorderSize = 0;
            btnGitRestoreAll.FlatStyle = FlatStyle.Flat;
            btnGitRestoreAll.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitRestoreAll.ForeColor = Color.White;
            btnGitRestoreAll.Location = new Point(213, 0);
            btnGitRestoreAll.Margin = new Padding(0);
            btnGitRestoreAll.Name = "btnGitRestoreAll";
            btnGitRestoreAll.Size = new Size(214, 38);
            btnGitRestoreAll.TabIndex = 5;
            btnGitRestoreAll.Text = "Git restore all changes";
            btnGitRestoreAll.TextColor = Color.White;
            btnGitRestoreAll.UseVisualStyleBackColor = false;
            // 
            // lblGitRestoreHeader
            // 
            lblGitRestoreHeader.BackColor = Color.FromArgb(61, 205, 88);
            lblGitRestoreHeader.Dock = DockStyle.Top;
            lblGitRestoreHeader.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGitRestoreHeader.ForeColor = Color.White;
            lblGitRestoreHeader.Location = new Point(0, 0);
            lblGitRestoreHeader.Name = "lblGitRestoreHeader";
            lblGitRestoreHeader.Size = new Size(453, 46);
            lblGitRestoreHeader.TabIndex = 5;
            lblGitRestoreHeader.Text = "Git restore:";
            lblGitRestoreHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Controls.Add(panel14);
            panel10.Controls.Add(lblGitAddHeader);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(3, 321);
            panel10.Name = "panel10";
            panel10.Size = new Size(453, 153);
            panel10.TabIndex = 2;
            // 
            // panel14
            // 
            panel14.Controls.Add(tableLayoutPanel6);
            panel14.Dock = DockStyle.Fill;
            panel14.Location = new Point(0, 46);
            panel14.Name = "panel14";
            panel14.Padding = new Padding(10);
            panel14.Size = new Size(453, 107);
            panel14.TabIndex = 6;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(tableLayoutPanel7, 0, 0);
            tableLayoutPanel6.Controls.Add(tableLayoutPanel8, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(10, 10);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(433, 87);
            tableLayoutPanel6.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel7.Controls.Add(btnGitAdd, 1, 0);
            tableLayoutPanel7.Controls.Add(txtFilePathToGitAdd, 0, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(3, 3);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Size = new Size(427, 37);
            tableLayoutPanel7.TabIndex = 0;
            // 
            // btnGitAdd
            // 
            btnGitAdd.BackColor = Color.FromArgb(63, 64, 69);
            btnGitAdd.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitAdd.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitAdd.BorderRadius = 35;
            btnGitAdd.BorderSize = 0;
            btnGitAdd.Dock = DockStyle.Fill;
            btnGitAdd.FlatAppearance.BorderSize = 0;
            btnGitAdd.FlatStyle = FlatStyle.Flat;
            btnGitAdd.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitAdd.ForeColor = Color.White;
            btnGitAdd.Location = new Point(298, 0);
            btnGitAdd.Margin = new Padding(0);
            btnGitAdd.Name = "btnGitAdd";
            btnGitAdd.Size = new Size(129, 37);
            btnGitAdd.TabIndex = 4;
            btnGitAdd.Text = "Git add";
            btnGitAdd.TextColor = Color.White;
            btnGitAdd.UseVisualStyleBackColor = false;
            // 
            // txtFilePathToGitAdd
            // 
            txtFilePathToGitAdd.BackColor = Color.White;
            txtFilePathToGitAdd.BorderColor = Color.FromArgb(63, 64, 69);
            txtFilePathToGitAdd.BorderRadius = 15;
            txtFilePathToGitAdd.Dock = DockStyle.Fill;
            txtFilePathToGitAdd.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFilePathToGitAdd.Location = new Point(0, 0);
            txtFilePathToGitAdd.Margin = new Padding(0);
            txtFilePathToGitAdd.Name = "txtFilePathToGitAdd";
            txtFilePathToGitAdd.PlaceholderText = "Enter the path of the file to add";
            txtFilePathToGitAdd.Size = new Size(298, 37);
            txtFilePathToGitAdd.TabIndex = 3;
            txtFilePathToGitAdd.TextBoxBackground = Color.White;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(btnGitAddAll, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(3, 46);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.Size = new Size(427, 38);
            tableLayoutPanel8.TabIndex = 1;
            // 
            // btnGitAddAll
            // 
            btnGitAddAll.BackColor = Color.FromArgb(63, 64, 69);
            btnGitAddAll.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitAddAll.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitAddAll.BorderRadius = 15;
            btnGitAddAll.BorderSize = 0;
            btnGitAddAll.Dock = DockStyle.Fill;
            btnGitAddAll.FlatAppearance.BorderSize = 0;
            btnGitAddAll.FlatStyle = FlatStyle.Flat;
            btnGitAddAll.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitAddAll.ForeColor = Color.White;
            btnGitAddAll.Location = new Point(213, 0);
            btnGitAddAll.Margin = new Padding(0);
            btnGitAddAll.Name = "btnGitAddAll";
            btnGitAddAll.Size = new Size(214, 38);
            btnGitAddAll.TabIndex = 6;
            btnGitAddAll.Text = "Git add all changes";
            btnGitAddAll.TextColor = Color.White;
            btnGitAddAll.UseVisualStyleBackColor = false;
            // 
            // lblGitAddHeader
            // 
            lblGitAddHeader.BackColor = Color.FromArgb(61, 205, 88);
            lblGitAddHeader.Dock = DockStyle.Top;
            lblGitAddHeader.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGitAddHeader.ForeColor = Color.White;
            lblGitAddHeader.Location = new Point(0, 0);
            lblGitAddHeader.Name = "lblGitAddHeader";
            lblGitAddHeader.Size = new Size(453, 46);
            lblGitAddHeader.TabIndex = 6;
            lblGitAddHeader.Text = "Git add:";
            lblGitAddHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel11
            // 
            panel11.Controls.Add(panel15);
            panel11.Controls.Add(lblGitStashHeader);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(3, 480);
            panel11.Name = "panel11";
            panel11.Size = new Size(453, 106);
            panel11.TabIndex = 3;
            // 
            // panel15
            // 
            panel15.Controls.Add(tableLayoutPanel9);
            panel15.Dock = DockStyle.Fill;
            panel15.Location = new Point(0, 46);
            panel15.Name = "panel15";
            panel15.Padding = new Padding(10);
            panel15.Size = new Size(453, 60);
            panel15.TabIndex = 6;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 3;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel9.Controls.Add(btnGitStashApply, 2, 0);
            tableLayoutPanel9.Controls.Add(btnGitStashPop, 1, 0);
            tableLayoutPanel9.Controls.Add(btnGitStash, 0, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(10, 10);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel9.Size = new Size(433, 40);
            tableLayoutPanel9.TabIndex = 0;
            // 
            // btnGitStashApply
            // 
            btnGitStashApply.BackColor = Color.FromArgb(63, 64, 69);
            btnGitStashApply.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitStashApply.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitStashApply.BorderRadius = 15;
            btnGitStashApply.BorderSize = 0;
            btnGitStashApply.Dock = DockStyle.Fill;
            btnGitStashApply.FlatAppearance.BorderSize = 0;
            btnGitStashApply.FlatStyle = FlatStyle.Flat;
            btnGitStashApply.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitStashApply.ForeColor = Color.White;
            btnGitStashApply.Location = new Point(293, 0);
            btnGitStashApply.Margin = new Padding(5, 0, 5, 0);
            btnGitStashApply.Name = "btnGitStashApply";
            btnGitStashApply.Size = new Size(135, 40);
            btnGitStashApply.TabIndex = 8;
            btnGitStashApply.Text = "Apply";
            btnGitStashApply.TextColor = Color.White;
            btnGitStashApply.UseVisualStyleBackColor = false;
            // 
            // btnGitStashPop
            // 
            btnGitStashPop.BackColor = Color.FromArgb(63, 64, 69);
            btnGitStashPop.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitStashPop.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitStashPop.BorderRadius = 15;
            btnGitStashPop.BorderSize = 0;
            btnGitStashPop.Dock = DockStyle.Fill;
            btnGitStashPop.FlatAppearance.BorderSize = 0;
            btnGitStashPop.FlatStyle = FlatStyle.Flat;
            btnGitStashPop.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitStashPop.ForeColor = Color.White;
            btnGitStashPop.Location = new Point(149, 0);
            btnGitStashPop.Margin = new Padding(5, 0, 5, 0);
            btnGitStashPop.Name = "btnGitStashPop";
            btnGitStashPop.Size = new Size(134, 40);
            btnGitStashPop.TabIndex = 9;
            btnGitStashPop.Text = "Pop";
            btnGitStashPop.TextColor = Color.White;
            btnGitStashPop.UseVisualStyleBackColor = false;
            // 
            // btnGitStash
            // 
            btnGitStash.BackColor = Color.FromArgb(63, 64, 69);
            btnGitStash.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitStash.BorderColor = Color.FromArgb(63, 64, 69);
            btnGitStash.BorderRadius = 15;
            btnGitStash.BorderSize = 0;
            btnGitStash.Dock = DockStyle.Fill;
            btnGitStash.FlatAppearance.BorderSize = 0;
            btnGitStash.FlatStyle = FlatStyle.Flat;
            btnGitStash.Font = new Font("Arial Rounded MT Bold", 9.163636F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGitStash.ForeColor = Color.White;
            btnGitStash.Location = new Point(5, 0);
            btnGitStash.Margin = new Padding(5, 0, 5, 0);
            btnGitStash.Name = "btnGitStash";
            btnGitStash.Size = new Size(134, 40);
            btnGitStash.TabIndex = 7;
            btnGitStash.Text = "Stash";
            btnGitStash.TextColor = Color.White;
            btnGitStash.UseVisualStyleBackColor = false;
            // 
            // lblGitStashHeader
            // 
            lblGitStashHeader.BackColor = Color.FromArgb(61, 205, 88);
            lblGitStashHeader.Dock = DockStyle.Top;
            lblGitStashHeader.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGitStashHeader.ForeColor = Color.White;
            lblGitStashHeader.Location = new Point(0, 0);
            lblGitStashHeader.Name = "lblGitStashHeader";
            lblGitStashHeader.Size = new Size(453, 46);
            lblGitStashHeader.TabIndex = 7;
            lblGitStashHeader.Text = "Git stash:";
            lblGitStashHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNavbar
            // 
            pnlNavbar.Controls.Add(panel2);
            pnlNavbar.Controls.Add(panel1);
            pnlNavbar.Dock = DockStyle.Top;
            pnlNavbar.Location = new Point(20, 20);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(1134, 107);
            pnlNavbar.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel5);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(481, 107);
            panel2.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblCurrentBranch);
            panel5.Controls.Add(lblCurrentBranchHeading);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(232, 107);
            panel5.TabIndex = 3;
            // 
            // lblCurrentBranch
            // 
            lblCurrentBranch.AutoSize = true;
            lblCurrentBranch.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBranch.ForeColor = Color.FromArgb(61, 205, 88);
            lblCurrentBranch.Location = new Point(3, 34);
            lblCurrentBranch.Margin = new Padding(0, 0, 3, 0);
            lblCurrentBranch.Name = "lblCurrentBranch";
            lblCurrentBranch.Size = new Size(161, 28);
            lblCurrentBranch.TabIndex = 2;
            lblCurrentBranch.Text = "branchName";
            // 
            // lblCurrentBranchHeading
            // 
            lblCurrentBranchHeading.AutoSize = true;
            lblCurrentBranchHeading.Font = new Font("Arial Rounded MT Bold", 15.7090912F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentBranchHeading.ForeColor = Color.FromArgb(63, 64, 69);
            lblCurrentBranchHeading.Location = new Point(3, 7);
            lblCurrentBranchHeading.Margin = new Padding(0, 0, 3, 0);
            lblCurrentBranchHeading.Name = "lblCurrentBranchHeading";
            lblCurrentBranchHeading.Size = new Size(200, 28);
            lblCurrentBranchHeading.TabIndex = 1;
            lblCurrentBranchHeading.Text = "Current Branch:";
            // 
            // panel1
            // 
            panel1.Controls.Add(btnGitCherryPick);
            panel1.Controls.Add(btnGitLog);
            panel1.Controls.Add(btnGitBranch);
            panel1.Controls.Add(btnGitStatus);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(481, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(653, 107);
            panel1.TabIndex = 0;
            // 
            // btnGitCherryPick
            // 
            btnGitCherryPick.BackColor = Color.FromArgb(63, 64, 69);
            btnGitCherryPick.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitCherryPick.BorderColor = Color.FromArgb(128, 232, 148);
            btnGitCherryPick.BorderRadius = 0;
            btnGitCherryPick.BorderSize = 1;
            btnGitCherryPick.FlatStyle = FlatStyle.Flat;
            btnGitCherryPick.Font = new Font("Arial Rounded MT Bold", 9.163636F);
            btnGitCherryPick.ForeColor = Color.White;
            btnGitCherryPick.Location = new Point(502, 19);
            btnGitCherryPick.Margin = new Padding(0);
            btnGitCherryPick.Name = "btnGitCherryPick";
            btnGitCherryPick.Size = new Size(146, 67);
            btnGitCherryPick.TabIndex = 4;
            btnGitCherryPick.Text = "Cherry-Pick";
            btnGitCherryPick.TextColor = Color.White;
            btnGitCherryPick.UseVisualStyleBackColor = false;
            // 
            // btnGitLog
            // 
            btnGitLog.BackColor = Color.FromArgb(63, 64, 69);
            btnGitLog.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitLog.BorderColor = Color.FromArgb(128, 232, 148);
            btnGitLog.BorderRadius = 0;
            btnGitLog.BorderSize = 1;
            btnGitLog.FlatStyle = FlatStyle.Flat;
            btnGitLog.Font = new Font("Arial Rounded MT Bold", 9.163636F);
            btnGitLog.ForeColor = Color.White;
            btnGitLog.Location = new Point(356, 19);
            btnGitLog.Margin = new Padding(0);
            btnGitLog.Name = "btnGitLog";
            btnGitLog.Size = new Size(146, 67);
            btnGitLog.TabIndex = 3;
            btnGitLog.Text = "Logs";
            btnGitLog.TextColor = Color.White;
            btnGitLog.UseVisualStyleBackColor = false;
            // 
            // btnGitBranch
            // 
            btnGitBranch.BackColor = Color.FromArgb(63, 64, 69);
            btnGitBranch.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitBranch.BorderColor = Color.FromArgb(128, 232, 148);
            btnGitBranch.BorderRadius = 0;
            btnGitBranch.BorderSize = 1;
            btnGitBranch.FlatStyle = FlatStyle.Flat;
            btnGitBranch.Font = new Font("Arial Rounded MT Bold", 9.163636F);
            btnGitBranch.ForeColor = Color.White;
            btnGitBranch.Location = new Point(209, 19);
            btnGitBranch.Margin = new Padding(0);
            btnGitBranch.Name = "btnGitBranch";
            btnGitBranch.Size = new Size(147, 67);
            btnGitBranch.TabIndex = 2;
            btnGitBranch.Text = "Branches";
            btnGitBranch.TextColor = Color.White;
            btnGitBranch.UseVisualStyleBackColor = false;
            // 
            // btnGitStatus
            // 
            btnGitStatus.BackColor = Color.FromArgb(63, 64, 69);
            btnGitStatus.BackgroundColor = Color.FromArgb(63, 64, 69);
            btnGitStatus.BorderColor = Color.FromArgb(128, 232, 148);
            btnGitStatus.BorderRadius = 0;
            btnGitStatus.BorderSize = 1;
            btnGitStatus.FlatStyle = FlatStyle.Flat;
            btnGitStatus.Font = new Font("Arial Rounded MT Bold", 9.163636F);
            btnGitStatus.ForeColor = Color.White;
            btnGitStatus.Location = new Point(60, 19);
            btnGitStatus.Margin = new Padding(0);
            btnGitStatus.Name = "btnGitStatus";
            btnGitStatus.Size = new Size(149, 67);
            btnGitStatus.TabIndex = 1;
            btnGitStatus.Text = "Status";
            btnGitStatus.TextColor = Color.White;
            btnGitStatus.UseVisualStyleBackColor = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1174, 742);
            Controls.Add(pnlMainContainer);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMain";
            Load += FormMain_Load;
            pnlMainContainer.ResumeLayout(false);
            tblPanelGitStatus.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel17.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel8.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel16.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel13.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel14.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel8.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel15.ResumeLayout(false);
            tableLayoutPanel9.ResumeLayout(false);
            pnlNavbar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainContainer;
        private TableLayoutPanel tblPanelGitStatus;
        private Panel panel3;
        private Label lblGitStatusHeading;
        private Panel pnlNavbar;
        private Panel panel2;
        private Label lblCurrentBranch;
        private Label lblCurrentBranchHeading;
        private Panel panel1;
        private CustomComponents.RoundedButton btnGitCherryPick;
        private CustomComponents.RoundedButton btnGitLog;
        private CustomComponents.RoundedButton btnGitBranch;
        private CustomComponents.RoundedButton btnGitStatus;
        private Panel panel5;
        private CustomComponents.RoundedButtonNew btnGitPush;
        private Panel panel4;
        private Panel panel6;
        private TextBox textBox1;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel8;
        private Label lblGitCommitHeader;
        private Panel panel9;
        private Label lblGitRestoreHeader;
        private Panel panel10;
        private Label lblGitAddHeader;
        private Panel panel11;
        private Label lblGitStashHeader;
        private Panel panel14;
        private Panel panel15;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel12;
        private CustomComponents.LeftRoundedTextBox txtCommitMsg;
        private Panel panel16;
        private CustomComponents.RightRoundedButton btnGitCommit;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel3;
        private CustomComponents.LeftRoundedTextBox txtFilePathToGitAdd;
        private TableLayoutPanel tableLayoutPanel4;
        private CustomComponents.RightRoundedButton btnGitRestore;
        private CustomComponents.LeftRoundedTextBox txtFilePathToGitRestore;
        private CustomComponents.RightRoundedButton btnGitAdd;
        private TableLayoutPanel tableLayoutPanel5;
        private CustomComponents.RoundedButtonNew btnGitRestoreAll;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private CustomComponents.RoundedButtonNew btnGitAddAll;
        private Panel panel17;
        private TableLayoutPanel tableLayoutPanel9;
        private CustomComponents.RoundedButtonNew btnGitStashApply;
        private CustomComponents.RoundedButtonNew btnGitStashPop;
        private CustomComponents.RoundedButtonNew btnGitStash;
    }
}