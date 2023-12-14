##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="buildOperation"/>[**Build Opertation**]()

Visual Studio defines several build operations by default. Here are the main ones:

[**Build**]: The Build operation compiles all the project files into executable code. If the project has been built previously, the Build operation only recompiles those files that have been modified since the last build. This makes the build process faster as it doesn't need to recompile all files.

[**Rebuild**]: The Rebuild operation performs a Clean followed by a Build. It deletes all compiled files in the build directory and then compiles all project files regardless of whether they have been modified or not. This ensures that any old or unnecessary compiled files are removed, and all code is compiled from scratch.

[**Clean**]: The Clean operation deletes all compiled files (like DLLs and EXEs) from the build directory. This is useful when you want to ensure that the next build operation is done from scratch and doesn't use any old compiled files.

[**Pack**]: The Pack operation creates a NuGet package (.nupkg file) from the project. This is useful when you want to distribute your project as a NuGet package that can be consumed by other projects.

[**Publish**]: The Publish operation builds the project and deploys the output to a specified location, which could be a folder on your local machine, a network share, or a cloud-based service. This operation is typically used when you're ready to deploy your application to a staging or production environment.

Each of these operations serves a different purpose in the software development lifecycle, and you would use them at different stages of your project.
These operations can be accessed from the Build menu in Visual Studio. Note that not all operations are available for all project types. For example, the Publish operation is not available for class library projects.
