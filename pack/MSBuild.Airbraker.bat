@ECHO OFF
ECHO Building ...

call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Source\pcl.40\Airbraker.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

ECHO Building ...

call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Source\pcl.45\Airbraker.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

PAUSE
