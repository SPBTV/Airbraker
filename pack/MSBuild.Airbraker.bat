call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Source\pcl-403\Airbraker.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

call %windir%\Microsoft.NET\Framework\v4.0.30319\msbuild.exe ..\Source\pcl-45\Airbraker.sln ^
/m /clp:ErrorsOnly /t:Clean,Build /p:Configuration=Release /p:Platform="Any CPU" 

PAUSE
