##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="gitattributes"/>[**.gitattributes**](https://git-scm.com/docs/gitattributes)

The **.gitattributes** file is a text file that you can place in your repository's root directory or in any subdirectory. 
It allows you to define attributes on a per-path basis. These attributes can affect the way Git handles certain files. 

Here are some common uses of the  file:

**Line Endings:** You can use the **.gitattributes** file to normalize line endings to a standard style. 
This can be helpful when working on a project across different operating systems.
```
* text=auto
```

**Language Statistics:** GitHub uses the **.gitattributes** file to determine the language statistics of a repository. 
You can override these statistics using the linguist-generated attribute.
```
*.generated linguist-generated=true
```

**Merge Strategies:** You can specify a custom merge driver for specific files or file types
```
*.java merge=javaMerge
```

**Diff Rendering:** You can customize how git diff command outputs differences of specific files.
```
 *.java diff=javaDiff
```

Git will check the first 8,000 bytes of a file to see if it contains a NUL character. If it does, the file is assumed to be binary.
From git's [source code:](https://github.com/git/git/blob/9c9b961d7eb15fb583a2a812088713a68a85f1c0/xdiff-interface.c#L187-L193)
```
#define FIRST_FEW_BYTES 8000
int buffer_is_binary(const char *ptr, unsigned long size)
{
    if (FIRST_FEW_BYTES < size)
        size = FIRST_FEW_BYTES;
    return !!memchr(ptr, 0, size);
}
```

Git uses the **.gitattributes** file to control the behavior of certain Git operations. The **.gitattributes** file is usually placed in the root directory of the repository, but it can also be placed in subdirectories. 

Here's how Git searches for **.gitattributes** files:

1. Local **.gitattributes** file: Git first looks for a **.gitattributes** file in the same directory as the file being checked. This file applies to the files in the same directory and any subdirectories.

2. Parent directories' **.gitattributes** files: If the local **.gitattributes** file does not exist or does not specify whether to ignore the file, Git then looks for **.gitattributes** files in the parent directories of the file, up to the root of the repository. These files also apply to the files in their directories and any subdirectories.

3. Repository's **.gitattributes** file: If none of the above **.gitattributes** files specify whether to ignore the file, Git then looks for a **.gitattributes** file in the root of the repository. This file applies to all files in the repository.

Please note that unlike [.gitignore](README.Gitignore.md), there is no global **.gitattributes** file that applies to all repositories on the machine. The **.gitattributes** file controls the attribute data that is associated with paths in the repository.
