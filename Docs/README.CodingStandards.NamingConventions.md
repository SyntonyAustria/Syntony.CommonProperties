# [Syntony Coding Standards](README.CodingStandards.md)


## Naming Conventions and Standards<a name="NamingComventions"/>
-----------

>The terms **Pascal Casing** and **Camel Casing** are used throughout this document.
>    - **Pascal Casing** - First character of all words are Upper Case and other characters are lower case.
>    Example: ***BackColor***
>
>    - **Camel Casing** - First character of all words, except the first word are Upper Case and other characters are lower case.
>    Example: ***backColor***


1. Use **Pascal Casing** for ***Class*** names
```csharp
public class **HelloWorld**
{
    ...
}
```
1. Use **Pascal Casing** for ***Method*** and ***Property*** names
```csharp
void SayHello (string name)
{
    ...
}
```
1. Use **Camel Casing** for ***variables*** and method ***parameters***
```
int **totalCount** = 0;
```
```csharp
void SayHello(string name)
{
    string **fullMessage** = "Hello " + name;
    ...
}
```

1. Use the prefix "**I**" with **Camel Casing** for interfaces
```csharp
public interface IWriteHello
{
    void SayHello(string name);
    ...
}
```


Use `print("Hello, world!")` to print a message to the screen.

<div style="margin-left: auto;
            margin-right: auto;
            width: auto">

| Item         | Price | # In stock |
|--------------|:-----:|-----------:|
| Juicy Apples |  1.99 |        739 |
| Bananas      |  1.89 |          6 |

</div>

<sub><sub>Copyright &copy; 2017 - 2023 by Syntony&reg; / Ing. Josef Hahnl, MBA - syntony@aon.at - All rights reserved.</sub></sub>
