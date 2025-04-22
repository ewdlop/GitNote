using System;
using System.Net;
using System.Threading.Tasks;
using Octokit;

class Program
{
    private const string GitHubToken = "PAT"; // Replace with your GitHub personal access token (PAT)

    static async Task Main(string[] args)
    {
        var client = new GitHubClient(new ProductHeaderValue("SetNonForkedReposPrivate"))
        {
            Credentials = new Credentials(GitHubToken)
        };

        try
        {
            // Get the authenticated user
            var user = await client.User.Current();
            Console.WriteLine($"Authenticated as: {user.Login}");

            // Fetch all repositories owned by the authenticated user
            var repositories = await client.Repository.GetAllForCurrent();

            foreach (var repo in repositories)
            {
                // Check if the repository is not private and not a fork
                if (!repo.Private && !repo.Fork && repo.FullName.StartsWith(user.Login))
                {
                    Console.WriteLine($"Setting repository '{repo.FullName}' to private...");

                    // Update repository visibility to private
                    var update = new RepositoryUpdate()
                    {
                        Private = true
                    };

                    await client.Repository.Edit(user.Login, repo.Name, update);

                    Console.WriteLine($"Repository '{repo.FullName}' is now private.");
                }
            }

            Console.WriteLine("All owned (non-forked) repositories have been processed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}