AirbrakeClient Class
====================
Represents an Airbrake client that sends error tracking information to a server.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **AirbrakerAirbrakeClient**  

**Namespace:** [Airbraker][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeClient
```

The **AirbrakeClient** type exposes the following members.


Constructors
------------

Name                                                                     | Description                                                                                                                 
------------------------------------------------------------------------ | --------------------------------------------------------------------------------------------------------------------------- 
[AirbrakeClient(AirbrakeConfig)][3]                                      | Creates a new instance of the **AirbrakeClient** class, and configures it to use the [RegexStackTraceLineParser][4] parser. 
[AirbrakeClient(AirbrakeConfig, AirbrakeNotifier)][5]                    | Creates a new instance of the **AirbrakeClient** class, and configures it to use the [RegexStackTraceLineParser][4] parser. 
[AirbrakeClient(AirbrakeConfig, AirbrakeNotifier, IStackTraceParser)][6] | Creates a new instance of the **AirbrakeClient** class.                                                                     


Methods
-------

Name                                                                | Description                                                                                                                                                
------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Configure(AirbrakeConfig, AirbrakeNotifier)][7]                    | Configures the **AirbrakeClient**, using the [RegexStackTraceLineParser][4] parser.                                                                        
[Configure(AirbrakeConfig, AirbrakeNotifier, IStackTraceParser)][8] | Configures the **AirbrakeClient**.                                                                                                                         
[Equals][9]                                                         | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][10]                                                      | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][11]                                                   | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][12]                                                       | Gets the [Type][13] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][14]                                               | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[OnReportFailed][15]                                                | Fires the [ReportFailed][16] event.                                                                                                                        
[OnReportSucceeded][17]                                             | Fires the [ReportSucceeded][18] event.                                                                                                                     
[Send][19]                                                          | Sends an error tracking information to the server.                                                                                                         
[ToString][20]                                                      | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Events
------

Name                  | Description                                                    
--------------------- | -------------------------------------------------------------- 
[ReportFailed][16]    | Fired when the notice to the Airbrake server fails to be send. 
[ReportSucceeded][18] | Fired when the notice to the Airbrake is sent successfully.    


See Also
--------

### Reference
[Airbraker Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: ../RegexStackTraceLineParser/README.md
[5]: _ctor_1.md
[6]: _ctor_2.md
[7]: Configure.md
[8]: Configure_1.md
[9]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[10]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[11]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[12]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[13]: http://msdn.microsoft.com/en-us/library/42892f65
[14]: http://msdn.microsoft.com/en-us/library/57ctke0a
[15]: OnReportFailed.md
[16]: ReportFailed.md
[17]: OnReportSucceeded.md
[18]: ReportSucceeded.md
[19]: Send.md
[20]: http://msdn.microsoft.com/en-us/library/7bxwbwt2