# update-git-for-windows

### Steps to Update Git for Windows

1. **Open Git Bash:**
   Open the Git Bash application on your Windows machine.

2. **Run the Update Command:**
   Enter the following command in the Git Bash terminal:
   ```sh
   git update-git-for-windows
   ```

3. **Follow the Prompts:**
   The command will check for updates and, if an update is available, it will guide you through the installation process.

### Example Usage

Here is how you can run the command in Git Bash:

```sh
$ git update-git-for-windows
Checking for updates...
Downloading Git for Windows update...
Installing update...
```

After the installation is complete, you can verify the update by checking the Git version:

```sh
$ git --version
git version <latest_version>
```

This will display the version of Git that is now installed on your system.

### Alternative Method

If the `git update-git-for-windows` command does not work or you prefer to update manually, you can follow these steps:

1. **Download the Latest Installer:**
   Go to the [Git for Windows](https://gitforwindows.org/) website and download the latest installer.

2. **Run the Installer:**
   Double-click the downloaded `.exe` file and follow the installation instructions. The installer will update your existing Git installation.

After updating, you can verify the installation by running `git --version` as shown above.
