using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace CreateFeatureBranchUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (!args.Any())
                    throw new ArgumentException("Missing command line parameter, RepoPath.");

                var repoPath = args[0];

                Console.Write("Repo path:  ");
                Console.WriteLine(repoPath);

                Console.Write("New Branch name? ");
                var newBranchName = Console.ReadLine();
                Console.WriteLine(newBranchName);
           
                var currentBranchName = RunGitCommand("branch", "--show-current", repoPath);
                Console.Write("Current branch: ");
                Console.WriteLine(currentBranchName);

                if (currentBranchName.Contains("/"))
                {
                    var split = currentBranchName.Split("/");
                    var featurePath = "";
                    for (int i = 0; i < split.Length - 1; i++)
                        featurePath += split[i];

                    Console.Write("Feature branch path: ");
                    Console.WriteLine(featurePath);
                    RunGitCommand("checkout", $"-b {featurePath}/{newBranchName}", repoPath);
                    currentBranchName = RunGitCommand("branch", "--show-current", repoPath);
                    Console.Write("New branch successfully created: ");
                    Console.WriteLine(currentBranchName);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Err: {ex}");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }

        // thanx stackoverflow
        // https://stackoverflow.com/questions/45202896/how-to-checkout-tags-using-c-sharp-and-git
        public static string RunGitCommand(string command, string args, string workingDirectory)
        {
            string git = "git";
            var results = "";
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = git,
                    Arguments = $"{command} {args}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDirectory,
                }
            };
            proc.Start();
            
            while (!proc.StandardOutput.EndOfStream)
                results += $"{proc.StandardOutput.ReadLine()}";
            
            proc.WaitForExit();

            return results;
        }
    }
}
