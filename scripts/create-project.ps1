$name = "Calculator"

dotnet new web -n $name -o "./src/$name"

dotnet sln "./Exmpl.sln" add "./src/$name/$name.csproj"