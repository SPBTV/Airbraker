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

Name                | Description                                                
------------------- | ---------------------------------------------------------- 
[AirbrakeClient][3] | Initializes a new instance of the **AirbrakeClient** class 


Methods
-------

Name                                                                | Description                                                                                                                                                
------------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Configure(AirbrakeConfig, AirbrakeNotifier)][4]                    | Configures the **AirbrakeClient**.                                                                                                                         
[Configure(AirbrakeConfig, AirbrakeNotifier, IStackTraceParser)][5] | Configures the **AirbrakeClient**.                                                                                                                         
[Equals][6]                                                         | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][7]                                                       | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][8]                                                    | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][9]                                                        | Gets the [Type][10] of the current instance. (Inherited from [Object][1].)                                                                                 
[MemberwiseClone][11]                                               | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[SendAsync][12]                                                     | Sends an error tracking information to the server.                                                                                                         
[ToString][13]                                                      | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name          | Description                                                          
------------- | -------------------------------------------------------------------- 
[Default][14] | Gets the default singleton instance of the **AirbrakeClient** class. 


See Also
--------

### Reference
[Airbraker Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: Configure.md
[5]: Configure_1.md
[6]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[7]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[8]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[9]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[10]: http://msdn.microsoft.com/en-us/library/42892f65
[11]: http://msdn.microsoft.com/en-us/library/57ctke0a
[12]: SendAsync.md
[13]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[14]: Default.md