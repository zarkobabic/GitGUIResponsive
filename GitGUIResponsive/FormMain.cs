using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitGUIResponsive
{
    public partial class FormMain : Form
    {

        private FormWelcomeScreen _welcomeForm;

        public FormMain(FormWelcomeScreen welcomeForm)
        {
            InitializeComponent();
            _welcomeForm = welcomeForm;
            Utility.CreateMessageBox("Loaded git repository successfully", $"Successfully loaded git repository from path {GitHelper.GetCurrentGitRepo}.", Utility.MESSAGE_SUCCESS);
            lblCurrentBranch.Text = GitHelper.GetCurrentGitBranch;
            GitHelper.SetCurrentSelectedButton(btnGitStatus);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _welcomeForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnGitStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblCurrentBranchHeading_Click(object sender, EventArgs e)
        {

        }

        private void tblPanelGitStatus_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rightRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
