$name = "Calculator"
$name = "Budget"

dotnet new web -n $name -o "./src/$name"
dotnet new xunit -n "$name.Tests" -o "./test/$name.Tests"

dotnet sln "./Exmpl.sln" add "./src/$name/$name.csproj"
dotnet sln "./Exmpl.sln" add "./test/$name.Tests/$name.Tests.csproj"