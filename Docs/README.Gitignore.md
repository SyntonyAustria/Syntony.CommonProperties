##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](..\README.md)

<a name="gitignore"/>[**.gitignore**](https://git-scm.com/docs/gitignore)

The **.gitignore** file is used to specify intentionally untracked files that Git should ignore. Files already tracked by Git are not affected.
The purpose of this file is to ensure that certain files and directories are untracked by Git. 
This is typically because these files are generated from source files that are already tracked, are personal to developers and not needed by others, or are temporary files that don't need to be shared.

Git looks for .gitignore files in several places when determining which files and directories to ignore. The process is as follows:

1. Local **.gitignore** file: Git first looks for a **.gitignore** file in the same directory as the file being checked. This **.gitignore** file applies to the files in the same directory and any subdirectories.

2. Parent directories' **.gitignore** files: If the local **.gitignore** file does not exist or does not specify whether to ignore the file, Git then looks for **.gitignore** files in the parent directories of the file, up to the root of the repository. These **.gitignore** files also apply to the files in their directories and any subdirectories.

3. Repository's **.gitignore** file: If none of the above **.gitignore** files specify whether to ignore the file, Git then looks for a **.gitignore** file in the root of the repository. This **.gitignore** file applies to all files in the repository.

4. Global **.gitignore** file: If none of the above **.gitignore** files specify whether to ignore the file, Git then looks for a global **.gitignore** file. The location of this file is specified by the core.excludesFile configuration option. This **.gitignore** file applies to all files in all repositories on the machine.

In all these **.gitignore** files, the patterns are read line by line, and the first matching pattern (from top to bottom) that matches the file is used to determine whether to ignore the file. If no pattern matches the file, the file is not ignored.
