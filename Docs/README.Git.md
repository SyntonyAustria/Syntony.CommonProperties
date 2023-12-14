##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="git"/>[**git**](https://git-scm.com/)

Git is a distributed version control system. It allows developers to track changes to their code over time, and enables multiple developers to work on the same codebase without overwriting each other's changes.

Git is a command-line tool that is installed and run on a developer's local machine. It does not provide a user interface or hosting for repositories.

Git is open-source and can be used with any type of project, regardless of the programming languages or tools used.

Here are some key concepts and operations in Git:

1. **Repository**: A repository (or "repo") is a directory where Git has been initialized to start version controlling your files.

2. **Commit**: When you make changes to your files, Git can track those changes. You can then "commit" those changes, which takes a snapshot of your files at that point in time.

3. **Branch**: A branch is a parallel version of a repository. It is contained within the repository, but does not affect the primary or master branch allowing you to work freely without disrupting the live version. When you've made the changes you want to, you can merge your branch back into the master branch to publish your changes.

4. **Clone**: If you want to get a copy of an existing Git repository, you "clone" it. This creates a new directory on your computer with all the repository's files and history.

5. **Pul**l: If you have cloned a repository and want to get the latest changes that others have committed to the repository, you "pull" the changes.

6. **Push**: After you have committed changes to your local repository, you can "push" those changes back up to the remote repository so others can see and access them.

7. **Merge**: When you have finished working on a branch, you can merge your changes back to the master branch, which makes them a permanent part of the project.


In Git, the `amend` command is used to modify the most recent commit. It allows you to combine staged changes with the previous commit instead of creating a new commit. It can also be used to edit the commit message of the most recent commit.

Here's how you can use it:

- If you've made changes to your files and staged them with `git add`, you can include those changes in the previous commit with `git commit --amend`. This will open your text editor and let you change the previous commit's message, and the new changes will be included in that commit.

- If you just want to change the commit message of the most recent commit, you can use `git commit --amend` without making any new changes. This will open your text editor and let you change the commit message.

Please note that amending a commit effectively replaces the previous commit with a new one that includes the amended changes or message. This changes the commit history, which can cause problems if you've already pushed your commits to a shared repository. In general, you should only amend commits that have not been pushed to a shared repository.

This is a very basic overview of Git. Git is a very powerful system with many more advanced features.
