using GitGUIResponsive.CustomComponents;
using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

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

        private void fillGitBranchOutput()
        {
            try
            {
                string gitBranchOutput = GitHelper.GitBranch();
                string[] gitBranchesArray = gitBranchOutput.Split("\n", StringSplitOptions.RemoveEmptyEntries);

                if (gitBranchesArray.Length == 0)
                {
                    //Only current branch exists
                    TableLayoutPanel tblPanelGitBranchInfoHolder = CreateOneElementForGitBranchesFlowLayout($"* {GitHelper.GetCurrentGitBranch}", false);
                    flwPanelGitBranches.Controls.Add(tblPanelGitBranchInfoHolder);
                }
                foreach (string nameOfBranch in gitBranchesArray)
                {
                    string branchName = nameOfBranch.Trim();
                    TableLayoutPanel tblPanelGitBranchInfoHolder = CreateOneElementForGitBranchesFlowLayout(branchName, false);
                    flwPanelGitBranches.Controls.Add(tblPanelGitBranchInfoHolder);
                }

            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git branch command", $"Unable to execute git branch command. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private void fillGitRemoteBrunchOutput()
        {
            try
            {
                string gitRemoteBranchOutput = GitHelper.GitRemoteBranch();
                if (String.IsNullOrWhiteSpace(gitRemoteBranchOutput))
                {
                    //No remote Git branch references have been fetched
                    TableLayoutPanel tblPanelGitBranchInfoHolder = CreateOneElementForGitBranchesFlowLayout("", true);
                    flwPanelGitRemoteBranches.Controls.Add(tblPanelGitBranchInfoHolder);
                }
                else
                {
                    string[] gitRemoteBranchesArray = gitRemoteBranchOutput.Split("\n", StringSplitOptions.RemoveEmptyEntries);
                    foreach (string nameOfBranch in gitRemoteBranchesArray)
                    {
                        string branchName = nameOfBranch.Trim();
                        TableLayoutPanel tblPanelGitBranchInfoHolder = CreateOneElementForGitBranchesFlowLayout(branchName, true);
                        flwPanelGitRemoteBranches.Controls.Add(tblPanelGitBranchInfoHolder);
                    }
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git remote branch command", $"Unable to fetch git remote branches. {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }

        private TableLayoutPanel CreateOneElementForGitBranchesFlowLayout(string branchName, bool remote)
        {
            PictureBox? pictureBoxNew = null;
            Panel? panelNew = null;

            Label labelNew = new Label();
            labelNew.AutoSize = true;
            labelNew.Dock = DockStyle.Fill;
            labelNew.Font = new Font("Arial Rounded MT Bold", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNew.Location = new Point(47, 0);
            labelNew.Name = "lblLabelGenerated";
            labelNew.Size = new Size(308, 50);
            labelNew.TabIndex = 0;
            labelNew.Text = branchName;
            labelNew.TextAlign = ContentAlignment.MiddleLeft;

            if (branchName != "" && branchName[0].Equals('*') && !remote) //trenutni branch
            {
                pictureBoxNew = new PictureBox();
                pictureBoxNew.BackgroundImage = Properties.Resources.current_branch_icon;
                pictureBoxNew.Location = new Point(0, 0);
                pictureBoxNew.Margin = new Padding(0);
                pictureBoxNew.Name = "picPictureBoxGenerated";
                pictureBoxNew.Size = new Size(24, 24);
                pictureBoxNew.TabIndex = 2;
                pictureBoxNew.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBoxNew.TabStop = false;


                panelNew = new Panel();
                panelNew.Controls.Add(pictureBoxNew);
                panelNew.Dock = DockStyle.Fill;
                panelNew.Location = new Point(10, 13);
                panelNew.Margin = new Padding(10, 13, 10, 13);
                panelNew.Name = "pnlPictureBoxPanelGenerated";
                panelNew.Size = new Size(24, 24);
                panelNew.TabIndex = 0;

                labelNew.ForeColor = Color.FromArgb(61, 205, 88);
            }

            RoundedButtonNew roundedButtonNew = new RoundedButtonNew();
            roundedButtonNew.BackgroundColor = Color.FromArgb(63, 64, 69);
            roundedButtonNew.BorderColor = Color.FromArgb(63, 64, 69);
            roundedButtonNew.BorderRadius = 20;
            roundedButtonNew.BorderSize = 0;
            roundedButtonNew.FlatAppearance.BorderSize = 0;
            roundedButtonNew.FlatStyle = FlatStyle.Flat;
            roundedButtonNew.Font = new Font("Arial Rounded MT Bold", 9.818182F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roundedButtonNew.ForeColor = Color.White;
            roundedButtonNew.Location = new Point(361, 3);
            roundedButtonNew.Name = "btnRoundedButtonNewGenerated";
            roundedButtonNew.Size = new Size(143, 44);
            roundedButtonNew.TabIndex = 1;
            roundedButtonNew.TextColor = Color.White;
            roundedButtonNew.UseVisualStyleBackColor = false;
            roundedButtonNew.Tag = branchName;

            TableLayoutPanel tblPanelGitBranchInfoHolder = new TableLayoutPanel();
            tblPanelGitBranchInfoHolder.ColumnCount = 4;
            tblPanelGitBranchInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            tblPanelGitBranchInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57F));
            tblPanelGitBranchInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27F));
            tblPanelGitBranchInfoHolder.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 8F));
            if (remote)
            {
                if (branchName == "")
                {
                    labelNew.Text = "No remote Git branch references have been fetched.";
                }
                else
                {
                    //Remote git branches exist -> Git remove button
                    roundedButtonNew.Text = "Remove";
                    roundedButtonNew.BackColor = Color.Red;
                    roundedButtonNew.Click += (sender, e) =>
                    {
                        try
                        {
                            if (GitHelper.GitRemoveRemoteBranchReference(branchName))
                            {
                                Utility.CreateMessageBox("Git remove remote branch command executed successfully", $"The reference to the remote branch \"{branchName}\" was successfully deleted from your local repository.", Utility.MESSAGE_SUCCESS);
                                btnGitBranch_Click(btnGitBranch, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utility.CreateMessageBox("Error while executing git remove remote branch command", $"Unable to delete the reference to the remote branch \"{branchName}\". {ex.Message}", Utility.MESSAGE_ERROR);
                        }
                    };

                    tblPanelGitBranchInfoHolder.Controls.Add(roundedButtonNew, 2, 0);
                }
            }
            else
            {
                if (panelNew != null)
                    tblPanelGitBranchInfoHolder.Controls.Add(panelNew, 0, 0);
                else
                {
                    //Not current branch -> Git switch button
                    roundedButtonNew.BackColor = Color.FromArgb(63, 64, 69);
                    roundedButtonNew.Text = "Switch";
                    roundedButtonNew.Click += (sender, e) =>
                    {
                        try
                        {
                            if (GitHelper.GitSwitch(branchName))
                            {
                                Utility.CreateMessageBox("Git switch command executed successfully", $"Switched to branch: {branchName}", Utility.MESSAGE_SUCCESS);
                                lblCurrentBranch.Text = GitHelper.GetCurrentGitBranch;
                                btnGitBranch_Click(btnGitBranch, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            Utility.CreateMessageBox("Error while executing git switch command", $"Unable to execute git switch command. {ex.Message}", Utility.MESSAGE_ERROR);
                        }
                    };
                    tblPanelGitBranchInfoHolder.Controls.Add(roundedButtonNew, 2, 0);
                }
            }
            tblPanelGitBranchInfoHolder.Controls.Add(labelNew, 1, 0);
            tblPanelGitBranchInfoHolder.Location = new Point(0, 20);
            tblPanelGitBranchInfoHolder.Margin = new Padding(0, 20, 0, 20);
            tblPanelGitBranchInfoHolder.Name = "tblPanelGitBranchInfoHolder";
            tblPanelGitBranchInfoHolder.RowCount = 1;
            tblPanelGitBranchInfoHolder.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblPanelGitBranchInfoHolder.Size = new Size(552, 50);
            tblPanelGitBranchInfoHolder.TabIndex = 0;
            if (!remote)
                tblPanelGitBranchInfoHolder.Width = flwPanelGitBranches.Width;
            else
                tblPanelGitBranchInfoHolder.Width = flwPanelGitRemoteBranches.Width;

            return tblPanelGitBranchInfoHolder;
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

        //Git branch panel

        private void btnGitBranch_Click(object sender, EventArgs e)
        {
            SetCurrentSelectedButton(btnGitBranch);
            SetCurrentContainerPanel(tblPanelGitBranch);
            flwPanelGitBranches.Controls.Clear();
            flwPanelGitRemoteBranches.Controls.Clear();
            fillGitBranchOutput();
            fillGitRemoteBrunchOutput();
        }

        private void flowLayoutPanel_ResizeChild(object sender, EventArgs e)
        {
            foreach (Control control in ((FlowLayoutPanel)sender).Controls)
            {
                control.Width = ((FlowLayoutPanel)sender).Width;
            }
        }

        private void btnGitFetch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtRemoteBranchNameToFetch.Text))
                {
                    Utility.CreateMessageBox("Error while executing git add remote branch command", "The remote branch name must be entered.", Utility.MESSAGE_ERROR);
                    return;
                }
                if (GitHelper.GitFetch(txtRemoteBranchNameToFetch.Text))
                {
                    Utility.CreateMessageBox("Git add remote branch command executed successfully", $"The reference to the remote branch \"origin\\{txtRemoteBranchNameToFetch.Text}\" was successfully added to your local repository.", Utility.MESSAGE_SUCCESS);
                    txtRemoteBranchNameToFetch.Text = "";
                    btnGitBranch_Click(btnGitBranch, e);
                }
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Error while executing git add remote branch command", $"Unable to add the reference to the remote branch \"origin\\{txtRemoteBranchNameToFetch.Text}\". {ex.Message}", Utility.MESSAGE_ERROR);
            }
        }
    }

}
