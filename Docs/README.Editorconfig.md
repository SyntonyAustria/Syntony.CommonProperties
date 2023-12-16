##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](..\README.md)

<a name="editorconfig"/>[**.editorconfig**](https://editorconfig.org/)

When opening a file, EditorConfig plugins look for a file named **.editorconfig** in the directory of the opened file and in every parent directory.
A search for .editorconfig files will stop if the root filepath is reached or an EditorConfig file with **root=true** is found.
An **.editorconfig** file is used to define and maintain consistent coding styles for different editors and IDEs. 
It's a text file that contains a collection of code style settings. It supports a wide range of languages and can be used in almost any text editor or IDE. 
In .NET projects, you can use **.editorconfig** to enforce specific conventions related to naming, layout, and language features. 
For example, you can specify whether to use tabs or spaces for indentation, the maximum line length, and so on. When an **.editorconfig** file is placed in a directory, it applies to all applicable files in that directory and its subdirectories. Multiple **.editorconfig** files can be used in a project, with settings in closer files taking precedence.


As a starting point, you can copy the [dotnet/docs repo's](https://github.com/dotnet/docs/blob/main/.editorconfig) to use Microsoft style.
