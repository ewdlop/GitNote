import org.eclipse.jgit.api.Git
import java.io.File

fun main() {
    val repo = File("path/to/repo")
    Git.open(repo).use { git ->
        val commits = git.log().call()
        for (commit in commits) {
            println(commit.fullMessage)
        }
    }
}
