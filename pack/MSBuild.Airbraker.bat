@ECHO OFF
ECHO Building ...

call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Source\portable-net403+sl40+wp71\Airbraker.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

ECHO Building ...

call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Source\portable-net45+sl50+win+wpa81+wp80\Airbraker.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

PAUSE
