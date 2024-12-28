#include <git2.h>
#include <iostream>

int main(int argc, char *argv[])
{
    git_libgit2_init();

    git_repository *repo = nullptr;
    int error = git_repository_open(&repo, "path/to/repo");

    if (error < 0)
    {
        const git_error *e = git_error_last();
        std::cerr << "Error: " << e->message << std::endl;
    }
    else
    {
        std::cout << "Repository opened successfully!" << std::endl;
    }

    git_repository_free(repo);
    git_libgit2_shutdown();

    return 0;
}
