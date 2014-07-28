AirbrakeConfig Class
====================
Represents an [AirbrakeClient][1] configuration.


Inheritance Hierarchy
---------------------
[SystemObject][2]  
  **AirbrakerAirbrakeConfig**  

**Namespace:** [Airbraker][3]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeConfig
```

The **AirbrakeConfig** type exposes the following members.


Constructors
------------

Name                     | Description                                                                                                  
------------------------ | ------------------------------------------------------------------------------------------------------------ 
[AirbrakeConfig][4]      | Creates a new instance of the **AirbrakeConfig** class, and initializes the server address to API 2.3 value. 
[AirbrakeConfig(Uri)][5] | Creates a new instance of the **AirbrakeConfig** class.                                                      


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][6]           | Determines whether the specified [Object][2] is equal to the current [Object][2]. (Inherited from [Object][2].)                                            
[Finalize][7]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][2].) 
[GetHashCode][8]      | Serves as a hash function for a particular type. (Inherited from [Object][2].)                                                                             
[GetType][9]          | Gets the [Type][10] of the current instance. (Inherited from [Object][2].)                                                                                 
[MemberwiseClone][11] | Creates a shallow copy of the current [Object][2]. (Inherited from [Object][2].)                                                                           
[ToString][12]        | Returns a string that represents the current object. (Inherited from [Object][2].)                                                                         


Properties
----------

Name                | Description                                                               
------------------- | ------------------------------------------------------------------------- 
[ApiKey][13]        | Gets or sets the project api key.                                         
[AppVersion][14]    | Gets or sets the application version.                                     
[Environment][15]   | Gets or sets the runtime environment (such as 'staging' or 'production'). 
[Hostname][16]      | Gets or sets the hostname.                                                
[ProjectName][17]   | Gets or sets the project root name.                                       
[ServerAddress][18] | Gets the Airbrake server address.                                         


See Also
--------

### Reference
[Airbraker Namespace][3]  

[1]: ../AirbrakeClient/README.md
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: _ctor_1.md
[6]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[7]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[8]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[9]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[10]: http://msdn.microsoft.com/en-us/library/42892f65
[11]: http://msdn.microsoft.com/en-us/library/57ctke0a
[12]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[13]: ApiKey.md
[14]: AppVersion.md
[15]: Environment.md
[16]: Hostname.md
[17]: ProjectName.md
[18]: ServerAddress.md