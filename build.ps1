dotnet build --configuration Release
dotnet pack --configuration Release --include-symbols
nuget pack SugarNewsAPI.csproj -Properties Configuration=Release
