import org.eclipse.jgit.api.Git;
import org.eclipse.jgit.revwalk.RevCommit;

public class GitExample {
    public static void main(String[] args) throws Exception {
        try (Git git = Git.open(new File("path/to/repo"))) {
            Iterable<RevCommit> commits = git.log().call();
            for (RevCommit commit : commits) {
                System.out.println(commit.getFullMessage());
            }
        }
    }
}
