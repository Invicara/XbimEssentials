rm -rf packages
nuget restore "Xbim.Essentials.Nuget.sln"
sleep 2
nuget restore "Xbim.Essentials.Nuget.sln"

"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe" "Xbim.Essentials.Nuget.sln" /build "Release|x64"
nuget pack Xbim.Essentials.nuspec
copy Xbim.*.nupkg ..\LocalPackages
del Xbim.*.nupkg
