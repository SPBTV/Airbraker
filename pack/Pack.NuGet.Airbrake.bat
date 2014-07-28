REM Update at first
.nuget\nuget.exe update -self

REM Pack the project
.nuget\nuget.exe pack ..\Source\Profile104\Airbraker\Airbraker.csproj -prop configuration=release
.nuget\nuget.exe pack ..\Source\Profile344\Airbraker\Airbraker.csproj -prop configuration=release

PAUSE