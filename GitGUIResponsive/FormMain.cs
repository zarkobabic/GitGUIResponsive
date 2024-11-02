using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace GitGUIResponsive
{
    public partial class FormMain : Form
    {

        private static Button? CurrentSelectedButton { get; set; }
        private static TableLayoutPanel? CurrentContainerPanel { get; set; }
        private FormWelcomeScreen _welcomeForm;

        public FormMain(FormWelcomeScreen welcomeForm)
        {
            InitializeComponent();
            _welcomeForm = welcomeForm;
            Utility.CreateMessageBox("Loaded git repository successfully", $"Successfully loaded git repository from path {GitHelper.GetCurrentGitRepo}.", Utility.MESSAGE_SUCCESS);
            lblCurrentBranch.Text = GitHelper.GetCurrentGitBranch;
            btnGitStatus_Click(btnGitStatus, new EventArgs());
        }

        //Helper methods

        public static void SetCurrentSelectedButton(Button buttonRefToSet)
        {
            if (CurrentSelectedButton != buttonRefToSet) //Revert previous button styling to normal
            {
                if (CurrentSelectedButton != null)
                {
                    CurrentSelectedButton.BackColor = Color.FromArgb(63, 64, 69);
                }
                CurrentSelectedButton = buttonRefToSet;
                CurrentSelectedButton.BackColor = Color.FromArgb(61, 205, 88);
            }
        }

        public static void SetCurrentContainerPanel(TableLayoutPanel panelToSet)
        {
            if (CurrentContainerPanel != panelToSet)
            {
                if (CurrentContainerPanel != null)
                {
                    CurrentContainerPanel.Hide();
                }
                CurrentContainerPanel = panelToSet;
                panelToSet.Show();
            }
        }

        //Events

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _welcomeForm.Show();
        }

        //Git status panel
        private void btnGitStatus_Click(object sender, EventArgs e)
        {
            SetCurrentSelectedButton(btnGitStatus);
            SetCurrentContainerPanel(tblPanelGitStatus);
            try
            {
                string gitStatusOutput = GitHelper.GitStatus();
                txtGitStatusResult.Text = gitStatusOutput.Replace("\n", Environment.NewLine) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git status command", $"Unable to execute git status command. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitCommit_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCommitMsg.Text))
                {
                    Utility.CreateMessageBox("Error while executing git commit command", $"Failed to execute the git commit command, missing commit message.", Utility.MESSAGE_ERROR);
                    return;
                }
                if (GitHelper.GitCommit(txtCommitMsg.Text))
                {
                    Utility.CreateMessageBox("Git commit command executed successfully", $"New Git commit with the message \"{txtCommitMsg.Text}\" was added successfully.", Utility.MESSAGE_SUCCESS);
                    txtCommitMsg.Text = "";
                    btnGitStatus_Click(btnGitStatus, e); //Refresh textbox commponent
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git commit command", $"Failed to execute the git commit command. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitRestore_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtFilePathToGitRestore.Text))
                {
                    Utility.CreateMessageBox("Error while executing git restore command", $"Failed to execute the git restore command, missing file path.", Utility.MESSAGE_ERROR);
                    return;
                }
                if (GitHelper.GitRestore(txtFilePathToGitRestore.Text))
                {
                    Utility.CreateMessageBox("Git restore command executed successfully", $"The file at path: \"{txtFilePathToGitRestore.Text}\" was successfully restored to the previous version using git restore.", Utility.MESSAGE_SUCCESS);
                    txtFilePathToGitRestore.Text = "";
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git restore command", $"Failed to execute the git restore command with file path \"{txtFilePathToGitRestore}\". {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitRestoreAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (GitHelper.GitRestoreAll())
                {
                    Utility.CreateMessageBox("Git restore all command executed successfully", "All files in the current directory have been restored to the version from the last commit using the git restore command.", Utility.MESSAGE_SUCCESS);
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git restore all command", $"Error restoring all files from the current directory to the version from the last commit using the git restore command. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFilePathToGitAdd.Text))
                {
                    Utility.CreateMessageBox("Error while executing git add command", $"Failed to execute the git add command, missing file path.", Utility.MESSAGE_ERROR);
                    return;
                }
                if (GitHelper.GitAdd(txtFilePathToGitAdd.Text))
                {
                    Utility.CreateMessageBox("Git add command executed successfully", $"The file at path: \"{txtFilePathToGitAdd.Text}\" was successfully added using the git add command.", Utility.MESSAGE_SUCCESS);
                    txtFilePathToGitAdd.Text = "";
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git add command", $"Failed to execute the git add command with file path \"{txtFilePathToGitAdd}\". {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitAddAll_Click(object sender, EventArgs e)
        {
            try
            {
                if (GitHelper.GitAddAll())
                {
                    Utility.CreateMessageBox("Git add all command executed successfully", "All files in the current directory have been added using the git add command.", Utility.MESSAGE_SUCCESS);
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git add all command", $"Error adding all files from the current directory using the git add command. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitStash_Click(object sender, EventArgs e)
        {
            try
            {
                if (GitHelper.GitStash())
                {
                    Utility.CreateMessageBox("Git stash command executed successfully", "All working directory changes have been stashed successfully, preserving your uncommitted work.", Utility.MESSAGE_SUCCESS);
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git stash command", $"Unable to stash changes. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitStashPop_Click(object sender, EventArgs e)
        {
            try
            {
                if (GitHelper.GitStashPop())
                {
                    Utility.CreateMessageBox("Git stash pop command executed successfully", "Stash popped and applied successfully. Changes have been restored to your working directory.", Utility.MESSAGE_SUCCESS);
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git stash pop command", $"Unable to pop and apply stash. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitStashApply_Click(object sender, EventArgs e)
        {
            try
            {
                if (GitHelper.GitStashApply())
                {
                    Utility.CreateMessageBox("Git stash apply command executed successfully", "Stash applied successfully. Changes have been restored to your working directory.", Utility.MESSAGE_SUCCESS);
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git stash apply command", $"Unable to apply stash. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitPush_Click(object sender, EventArgs e)
        {
            try
            {
                if (GitHelper.GitPush())
                {
                    Utility.CreateMessageBox("Git push command executed successfully", "New changes have been successfully pushed to the remote repository.", Utility.MESSAGE_SUCCESS);
                    btnGitStatus_Click(btnGitStatus, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git push command", $"Unable to push new changes. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }


        //Git log panel

        private void btnGitLog_Click(object sender, EventArgs e)
        {
            SetCurrentSelectedButton(btnGitLog);
            SetCurrentContainerPanel(tblPanelGitLog);
            try
            {
                string gitLogOutput = GitHelper.GitLog();
                if (gitLogOutput.Equals(""))
                    txtGitLogResult.Text = "There are no logs to display.";
                else
                    txtGitLogResult.Text = gitLogOutput.Replace("\n", Environment.NewLine) + Environment.NewLine;
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git log command", $"Unable to execute git log command. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void btnGitBundle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBundleName.Text))
                {
                    Utility.CreateMessageBox("Error while executing git bundle command", "The bundle name must be entered.", Utility.MESSAGE_ERROR);
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtBundleStartingCommit.Text))
                {
                    Utility.CreateMessageBox("Error while executing git bundle command", "The bundle starting commit must be entered.", Utility.MESSAGE_ERROR);
                    return;
                }
                if (GitHelper.GitBundleCreate(txtBundleName.Text, txtBundleStartingCommit.Text))
                {
                    Utility.CreateMessageBox("Git bundle command executed successfully", $"The bundle with name \"{txtBundleName.Text}\" is created, starting from commit with hash \"{txtBundleStartingCommit.Text}\".", Utility.MESSAGE_SUCCESS);
                    txtBundleName.Text = "";
                    txtBundleStartingCommit.Text = "";
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git bundle command", $"Unable to create bundle with name \"{txtBundleName.Text}\", starting from git commit with hash \"{txtBundleStartingCommit.Text}\". {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }
    }

}
