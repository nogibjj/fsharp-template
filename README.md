
# live-coding-csharp (Can use as a GitHub Codespaces Template for .NET 7 with F#)

### Lesson 2:  Checkout building the app into something that accepts arguments

See this library:https://github.com/fsprojects/Argu
To Do:  Build an Application that repeats a phrase five times.

### Lesson 1:  Setup F# and Run Hello Works

#### Interactive Mode
1. To start interactive mode: `dotnet fsi`
2. To get help:  `#help;;`
3. To quit do the following:  `#q;;`

#### Running FSX Scripts

put this in a file: `printfn "Hello World!"` called `hello.fsx`

`dotnet fsi hello.fsx`

#### Create an F# Application using a Template

Reference: https://learn.microsoft.com/en-us/training/modules/fsharp-first-steps/7-fsharp-build-application

`dotnet new console --language F# -o MyFSharpApp` and cd into directory

To run it:  `dotnet run`




## References

* [tutorial microsoft](https://dotnet.microsoft.com/en-us/learn/fsharp)
* [hello world tutorial](https://dotnet.microsoft.com/en-us/learn/languages/fsharp-hello-world-tutorial/modify)
* [setup environment](https://learn.microsoft.com/en-us/training/modules/fsharp-first-steps/4-set-up-development-environment-exercise)
