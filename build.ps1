Remove-Item -Path ./bin -Recurse -Force
Remove-Item -Path ./*.nupkg -Force
dotnet build --configuration Release
dotnet pack --configuration Release --include-symbols
nuget pack SugarNewsAPI.csproj -Properties Configuration=Release
#dotnet nuget push /Users/danijel-rpc/Projects/sugar-news/SugarNewsAPI/*.nupkg --source https://api.nuget.org/v3/index.json --api-key oy2httfqawtytwnjdwoq2iudovw36pxunkmsjn3p44o5be