rm -rf packages
nuget restore "Xbim.Essentials.Nuget.sln"
sleep 2
nuget restore "Xbim.Essentials.Nuget.sln"

set cputype=%~1
if "%~1" == "" set cputype=x64

"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe" "Xbim.Essentials.Nuget.sln" /build "ReleaseWithPDB|%cputype%"

nuget pack Xbim.Essentials.nuspec
copy Xbim.*.nupkg ..\LocalPackages
del Xbim.*.nupkg
