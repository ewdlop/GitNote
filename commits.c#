using LibGit2Sharp;
using System;

class Program
{
    static void Main(string[] args)
    {
        using (var repo = new Repository("path/to/repo"))
        {
            foreach (Commit commit in repo.Commits)
            {
                Console.WriteLine(commit.Message);
            }
        }
    }
}
