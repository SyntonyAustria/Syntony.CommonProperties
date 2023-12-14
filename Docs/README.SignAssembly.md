##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="signAssembly"/>[**Sign Asembly**](https://learn.microsoft.com/en-us/dotnet/standard/assembly/sign-strong-name)

In .NET, signing an assembly is not mandatory, but it is a recommended practice. When you sign an assembly, you are adding a digital signature to it that uniquely identifies the assembly and its author. This signature can be used to verify the integrity of the assembly and ensure that it has not been tampered with.
There are several reasons why you might want to sign an assembly:

[**Authenticity**]: Signing an assembly ensures that it is authentic and has not been tampered with.

[**Security**]: Signed assemblies can be placed in the Global Assembly Cache (GAC), which is a central repository for shared assemblies. Signing an assembly guarantees that it cannot be spoofed by someone else.

[**Versioning**]: Strongly named assemblies are tied to a specific version, meaning that you can use binding
redirects or recompile the application if you want to use a different version.

[**Dependency**]: If you sign an executable, then any class libraries it links to also need to be signed.
