using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Used imports
using System.Diagnostics;
using System.IO;
using System.Diagnostics.Metrics;

namespace GitGUIResponsive
{
    public static class GitHelper
    {
        //Fields
        private static string CurrentGitRepo { get; set; } = "";
        private static string CurrentGitBranch { get; set; } = "Git repository is not initialized";
        private static string CurrentGitCherryPickedCommitHash { get; set; } = null;

        //Getters and setters
        public static string GetCurrentGitRepo => CurrentGitRepo;
        public static string GetCurrentGitBranch => CurrentGitBranch;
        public static string GetCurrentGitCherryPickedCommitHash => CurrentGitCherryPickedCommitHash;

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

        public static string GitCommandReturningOutput(string argument)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "git",
                Arguments = argument,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = CurrentGitRepo
            };

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
                string error = process.StandardError.ReadToEnd();
                string output = process.StandardOutput.ReadToEnd();
                if (process.ExitCode == 0)
                {
                    return output;
                }
                else
                {
                    string msg = "";
                    if (!string.IsNullOrWhiteSpace(error))
                        msg = $"{error}";
                    if (!string.IsNullOrWhiteSpace(output))
                        msg += $" | Output: {output} |";
                    throw new InvalidOperationException(msg);
                }
            }
        }

        public static bool GitCommandAction(string argument)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo()
            {
                FileName = "git",
                Arguments = argument,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = CurrentGitRepo
            };

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
                string error = process.StandardError.ReadToEnd();
                string output = process.StandardOutput.ReadToEnd();
                if (process.ExitCode == 0)
                {
                    return true;
                }
                else
                {
                    string msg = "";
                    if (!string.IsNullOrWhiteSpace(error))
                        msg = $"{error}";
                    if (!string.IsNullOrWhiteSpace(output))
                        msg += $" | Output: {output} |";
                    throw new InvalidOperationException(msg);
                }
            }
        }


        public static string GitStatus()
        {
            return GitCommandReturningOutput("status");
        }

        public static bool GitCommit(string commitMsg)
        {
            if (string.IsNullOrWhiteSpace(commitMsg))
            {
                throw new InvalidOperationException("A commit message is required!");
            }
            return GitCommandAction($"commit -m \"{commitMsg}\"");
        }

        public static bool GitRestore(string filePath)
        {

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new InvalidOperationException("You must enter the file path for the file you want to restore to the version from the last commit using the git restore command.");
            }
            return GitCommandAction($"restore {filePath}");
        }

        public static bool GitRestoreAll()
        {
            return GitCommandAction("restore .");
        }

        public static bool GitAdd(string filePath)
        {

            if (string.IsNullOrWhiteSpace(filePath))
            {
                throw new InvalidOperationException("You must enter the file path for the file you want to add with git add.");
            }
            return GitCommandAction($"add {filePath}");
        }

        public static bool GitAddAll()
        {
            return GitCommandAction("add .");
        }

        public static bool GitStash()
        {
            return GitCommandAction("stash");
        }

        public static bool GitStashPop()
        {
            return GitCommandAction("stash pop");
        }

        public static bool GitStashApply()
        {
            return GitCommandAction("stash apply");
        }

        public static bool GitPush()
        {
            return GitCommandAction("push");
        }

        public static string GitLog()
        {
            return GitCommandReturningOutput("log");
        }

        public static bool GitBundleCreate(string bundleName, string bundleStartingCommitHash)
        {

            if (string.IsNullOrWhiteSpace(bundleName))
            {
                throw new InvalidOperationException("The bundle name must be entered.");
            }
            else if (string.IsNullOrWhiteSpace(bundleStartingCommitHash))
            {
                throw new InvalidOperationException("The bundle starting commit must be entered.");
            }

            return GitCommandAction($"bundle create {bundleName} {bundleStartingCommitHash}..");
        }

        public static string GitBranch()
        {
            return GitCommandReturningOutput("branch"); 
        }

        public static bool GitSwitch(string branchName)
        {
            if (GitCommandAction($"switch {branchName}"))
            {
                CurrentGitBranch = branchName;
                return true;
            }
            else return false;
        }

        public static string GitRemoteBranch()
        {
            return GitCommandReturningOutput("branch -r");
        }

        public static bool GitRemoveRemoteBranchReference(string remoteBranchName)
        {
            return GitCommandAction($"branch -dr {remoteBranchName}");
        }

        public static bool GitFetch(string branchName)
        {

            if (string.IsNullOrWhiteSpace(branchName))
            {
                throw new InvalidOperationException("The remote branch name must be entered.");
            }

            return GitCommandAction($"fetch origin {branchName}");
        }

        //Git cherry pick view

        public static bool IsGitCherryPickingInProgress()
        {
            try
            {
                string cherryPickHeadPath = Path.Combine(CurrentGitRepo, ".git", "CHERRY_PICK_HEAD");
                return File.Exists(cherryPickHeadPath);
            }
            catch (Exception ex)
            {
                Utility.CreateMessageBox("Git cherry pick status check error", "Error checking cherry-pick status: " + ex.Message, Utility.MESSAGE_ERROR);
                return false;
            }
        }

        public static bool GitCherryPick(string commitHash)
        {

            if (string.IsNullOrWhiteSpace(commitHash))
            {
                throw new InvalidOperationException("You must enter the commit hash for the commit you want to cherry-pick.");
            }
            return GitCommandAction($"cherry-pick {commitHash}");
        }

        public static string GitLogGraph()
        {
            return GitCommandReturningOutput("log --all --graph --oneline --decorate");
        }

        public static string ReadCurrentGitCherryPickedCommitHash()
        {
            if(CurrentGitCherryPickedCommitHash == null) //First time read from file, every other read from variable until resolved
            {
                try
                {
                    string cherryPickHeadPath = Path.Combine(CurrentGitRepo, ".git", "CHERRY_PICK_HEAD");
                    if (File.Exists(cherryPickHeadPath))
                    {
                        string fullCommitHash = File.ReadAllText(cherryPickHeadPath).Trim();
                        CurrentGitCherryPickedCommitHash = fullCommitHash[..7];
                        return CurrentGitCherryPickedCommitHash;
                    }
                    else
                    {
                        return null;
                    }
                }
                catch (Exception ex)
                {
                    Utility.CreateMessageBox("Error reading cherry-pick commit hash", $"Error reading cherry-pick commit hash: {ex.Message}", Utility.MESSAGE_ERROR);
                    return null;
                }
            }
            else
            {
                return CurrentGitCherryPickedCommitHash;
            }
        }

        public static bool GitCherryPickContinue()
        {
            if(GitCommandAction("cherry-pick --continue --no-edit"))
            {
                CurrentGitCherryPickedCommitHash = null;
                return true;
            }
            return false;
        }

        public static bool GitCherryPickAbort()
        {
            if (GitCommandAction("cherry-pick --abort"))
            {
                CurrentGitCherryPickedCommitHash = null;
                return true;
            }
            return false;
        }

        //Git garbage collector
        public static bool GitRunGarbageCollector()
        {
            return GitCommandAction("gc --prune=all");
        }
    }
}
