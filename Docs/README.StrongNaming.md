##### <sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
# [Syntony.CommonProperties](./../README.md)

<a name="strongNaming"/>[Strong naming](https://learn.microsoft.com/en-us/dotnet/standard/assembly/strong-named)

Strong-naming an assembly creates a unique identity for the assembly, and can prevent assembly conflicts.
Do not rely on strong names for security. They provide a unique identity only.

Both .pfx and .snk files are associated with strong name and code signing in .NET, but they serve different purposes and contain different types of data.

[**.snk**] (Strong Name Key) file: This is a simple key file used by .NET for strong-naming assemblies. It contains just the key pair (public and private keys) that's used to sign an assembly and doesn't have any associated certificate or metadata. Strong names are used to uniquely identify an assembly and prevent DLL Hell, but they don't provide any security or trust guarantees.

[**.pfx**] (Personal Information Exchange) file: This is a certificate file that can be used for code signing. It contains not only the key pair, but also the certificate that vouches for the identity of the key owner. This certificate can be issued by a trusted certificate authority (CA), which allows others to verify the identity of the key owner and trust the signed code. PFX files are protected by a password to secure the private key.

In summary, if you just want to strong-name your assemblies, you can use a .snk file. If you want to sign your code and provide trust guarantees, you need a .pfx file with a certificate issued by a trusted CA.

For .NET Framework, strong-named assemblies are useful in the following scenarios:

* You want to enable your assemblies to be referenced by strong-named assemblies, or you want to give friend access to your assemblies from other strong-named assemblies. 

* An app needs access to different versions of the same assembly. This means you need different versions of an assembly to load side by side in the same app domain without conflict. For example, if different extensions of an API exist in assemblies that have the same simple name, strong-naming provides a unique identity for each version of the assembly. 

* You do not want to negatively affect performance of apps using your assembly, so you want the assembly to be domain neutral. This requires strong-naming because a domain-neutral assembly must be installed in the global assembly cache.

* You want to centralize servicing for your app by applying publisher policy, which means the assembly must be installed in the global assembly cache.

For .NET Core and .NET 5+, strong-named assemblies do not provide material benefits. The runtime never validates the strong-name signature, nor does it use the strong-name for assembly binding.
