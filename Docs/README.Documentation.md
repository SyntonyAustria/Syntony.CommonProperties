##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="documentation"/>**Documentation**

Converting XML documentation to other formats like Markdown (MD), HTML, or DOCX is not a built-in feature of Visual Studio or ReSharper. However, there are several tools and libraries available that can help with this task.

Here are a few options:
1. [**Sandcastle Help File Builder (SHFB)**](https://github.com/EWSoftware/SHFB): This is a Microsoft tool that can generate MSDN-style documentation from .NET XML documentation files. It can output HTML and CHM (Microsoft Compiled HTML Help) files.
2. [**DocFX**](https://dotnet.github.io/docfx/): This is another Microsoft tool that can generate API documentation directly from XML comments in .NET source code. It can output static HTML that you can host on any web server, and it also supports Markdown files.
3. [**Pandoc**](https://pandoc.org/): This is a universal document converter that can convert XML to many other formats including Markdown, HTML, and DOCX. However, it might not understand the structure of .NET XML documentation files out of the box, so you might need to preprocess the XML to a format Pandoc can understand.
4. [**Doxygen**](https://www.doxygen.nl/): Doxygen is a popular documentation system for various programming languages, including C++, C, C#, Objective-C, Python, Java, PHP, and others. It is used to generate documentation from annotated source code.
