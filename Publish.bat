rm -rf packages
nuget restore "Xbim.Essentials.Nuget.sln"
sleep 2
nuget restore "Xbim.Essentials.Nuget.sln"

set buildConfig="%~1"
if "%~1" == "" set buildConfig="Release|Any CPU"

"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe" "Xbim.Essentials.Nuget.sln" /clean %buildConfig%
"C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\devenv.exe" "Xbim.Essentials.Nuget.sln" /build %buildConfig%

nuget pack Xbim.Essentials.nuspec
copy Xbim.*.nupkg ..\LocalPackages
del Xbim.*.nupkg
