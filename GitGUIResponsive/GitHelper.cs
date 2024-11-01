using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used imports
using System.Diagnostics;
using System.IO;

namespace GitGUIResponsive
{
    public static class GitHelper
    {
        //Fields
        private static string CurrentGitRepo { get; set; } = "";
        private static string CurrentGitBranch { get; set; } = "Git repository is not initialized";
        private static string CurrentGitCherryPickedCommitHash { get; set; } = "";
        private static Button? CurrentSelectedButton { get; set; }

        //Getters and setters
        public static string GetCurrentGitRepo => CurrentGitRepo;
        public static string GetCurrentGitBranch => CurrentGitBranch;
        public static string GetCurrentGitCherryPickedCommitHash => CurrentGitCherryPickedCommitHash;

        public static void SetCurrentSelectedButton(Button buttonRefToSet)
        {
            if(CurrentSelectedButton != buttonRefToSet) //Revert previous button styling to normal
            {
                if (CurrentSelectedButton != null)
                {
                    CurrentSelectedButton.BackColor = Color.FromArgb(63, 64, 69);
                }
                CurrentSelectedButton = buttonRefToSet;
                CurrentSelectedButton.BackColor = Color.FromArgb(61, 205, 88);
            }
        }

        //Methods
        public static bool GitLoadRepo(string pathToGitRepo)
        {
            if (!Directory.Exists($"{pathToGitRepo}\\.git"))
            {
                CurrentGitBranch = "Git repository is not initialized";
                throw new DirectoryNotFoundException($"The directory '{pathToGitRepo}' does not exist or is not a valid Git repository.");
            }
            else
            {
                CurrentGitRepo = pathToGitRepo;
                CurrentGitBranch = GitGetCurrentBranch();
                return true;
            }
        }

        private static string GitGetCurrentBranch()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "git",
                Arguments = "branch --show-current",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = CurrentGitRepo
            };

            try
            {
                using (Process process = Process.Start(startInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {

                        CurrentGitBranch = reader.ReadToEnd().Trim();
                        return CurrentGitBranch;
                    }
                }
            }
            catch (Exception ex)
            {
                CurrentGitRepo = "Git repository is not initialized";
                throw new InvalidOperationException("Unable to retrieve the current Git branch. ", ex);
            }
        }
    }
}
