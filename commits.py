import git

repo = git.Repo('path/to/repo')
for commit in repo.iter_commits():
    print(commit.message)
