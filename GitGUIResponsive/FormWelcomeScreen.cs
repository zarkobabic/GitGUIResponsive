namespace GitGUIResponsive
{
    public partial class FormWelcomeScreen : Form
    {
        public FormWelcomeScreen()
        {
            InitializeComponent();
        }

        private void btnLoadRepository_Click(object sender, EventArgs e)
        {
            try
            {
                if(GitHelper.GitLoadRepo(txtGitFolderPath.Text))
                {
                    this.Hide();
                    FormMain mainForm = new FormMain(this);
                    mainForm.Show();

                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while loading git repository", $"Unable to load git repository. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }
    }
}
