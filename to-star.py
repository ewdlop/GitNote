import requests

# Replace with your GitHub username and personal access token
GITHUB_USERNAME = 'your-username'
GITHUB_TOKEN = 'your-personal-access-token'
TARGET_USER = 'target-username'  # The GitHub user whose repositories you want to star

def get_repos(user):
    url = f'https://api.github.com/users/{user}/repos'
    response = requests.get(url, auth=(GITHUB_USERNAME, GITHUB_TOKEN))
    response.raise_for_status()  # Raise an error for bad status codes
    return response.json()

def star_repo(owner, repo):
    url = f'https://api.github.com/user/starred/{owner}/{repo}'
    response = requests.put(url, auth=(GITHUB_USERNAME, GITHUB_TOKEN))
    if response.status_code == 204:
        print(f'Successfully starred {owner}/{repo}')
    elif response.status_code == 304:
        print(f'{owner}/{repo} is already starred')
    else:
        print(f'Failed to star {owner}/{repo}: {response.status_code}')

def star_all_user_repos(user):
    repos = get_repos(user)
    for repo in repos:
        star_repo(repo['owner']['login'], repo['name'])

if __name__ == '__main__':
    star_all_user_repos(TARGET_USER)
