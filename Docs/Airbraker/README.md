Airbraker Namespace
===================


Classes
-------

Class                          | Description                                                                           
------------------------------ | ------------------------------------------------------------------------------------- 
[AirbrakeClient][1]            | Represents an Airbrake client that sends error tracking information to a server.      
[AirbrakeConfig][2]            | Represents an [AirbrakeClient][1] configuration.                                      
[RegexStackTraceLineParser][3] | Represents a simple parser of stack trace information.                                
[ReportCompletedEventArgs][4]  | Represents an [EventArgs][5] implementation to be passed in report completion events. 


Interfaces
----------

Interface              | Description                     
---------------------- | ------------------------------- 
[IStackTraceParser][6] | Represents a stack trace parser 

[1]: AirbrakeClient/README.md
[2]: AirbrakeConfig/README.md
[3]: RegexStackTraceLineParser/README.md
[4]: ReportCompletedEventArgs/README.md
[5]: http://msdn.microsoft.com/en-us/library/118wxtk3
[6]: IStackTraceParser/README.md
