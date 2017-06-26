ApiKey=$1
Source=$2

nuget pack ./MangoPay.SDK/MangoPay.SDK.csproj -Build
nuget pack ./MangoPay.SDK/MangoPay.SDK.nuspec -Verbosity detailed
nuget push ./DnDGen.MangoPay.SDK.*.nupkg -Verbosity detailed -ApiKey $ApiKey -Source $Source
