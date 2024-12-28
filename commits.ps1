Add-Type -Path "path/to/LibGit2Sharp.dll"
$repo = [LibGit2Sharp.Repository]::new("path/to/repo")
foreach ($commit in $repo.Commits) {
    Write-Host $commit.Message
}
