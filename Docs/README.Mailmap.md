##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="mailmap"/>[**.mailmap**](https://git-scm.com/docs/gitmailmap)

A **.mailmap** file is used in a Git repository to handle inconsistencies in commit author names and email addresses. It's a mechanism to map each author's various names and email addresses to a single, canonical representation.
The **.mailmap**  file is typically placed in the root directory of a Git repository.

The **.mailmap** file is used by Git to map author and committer names and email addresses to canonical real names and email addresses. This can be useful when a contributor has used different names or email addresses in different commits.

Git looks for the **.mailmap** file in the root directory of the repository. The **.mailmap** file affects the entire repository, so it is not searched for in subdirectories or parent directories like the .gitignore or .gitattributes files.

Here's an example of how you might use a **.mailmap** file:

```
 # .mailmap
John Doe <john.doe@example.com>
Jane Doe <jane.doe@other-example.com> <jane.doe@example.com>
```
In this example, all commits by <john.doe@example.com> will be attributed to John Doe, and all commits by <jane.doe@example.com> will be attributed to Jane Doe <jane.doe@other-example.com>.

Please note that the **.mailmap** file does not change the actual commits in the repository. It only affects how the commit information is displayed by certain Git commands, like git log or git shortlog.
