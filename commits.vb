Imports LibGit2Sharp

Module Module1
    Sub Main()
        Using repo As New Repository("path/to/repo")
            For Each commit As Commit In repo.Commits
                Console.WriteLine(commit.Message)
            Next
        End Using
    End Sub
End Module
