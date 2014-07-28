AirbrakeServerEnvironment Class
===============================
Represents a server environment.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **Airbraker.DataAirbrakeServerEnvironment**  

**Namespace:** [Airbraker.Data][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeServerEnvironment
```

The **AirbrakeServerEnvironment** type exposes the following members.


Constructors
------------

Name                           | Description                                                           
------------------------------ | --------------------------------------------------------------------- 
[AirbrakeServerEnvironment][3] | Initializes a new instance of the **AirbrakeServerEnvironment** class 


Methods
-------

Name                 | Description                                                                                                                                                
-------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][4]          | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][5]        | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][6]     | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][7]         | Gets the [Type][8] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][9] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][10]       | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name              | Description                                                                                                                                                                                                                                   
----------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[AppVersion][11]  | Optional. The version of the application that this error came from. If the App Version is set on the project, then errors older than the project's app version will be ignored. This version field uses Semantic Versioning style versioning. 
[Environment][12] | Required. The name of the server environment in which the error occurred, such as "staging" or "production."                                                                                                                                  
[Hostname][13]    | Gets or sets the environment hostname.                                                                                                                                                                                                        
[Project][14]     | Gets or sets the project root name, where the error occurred.                                                                                                                                                                                 


See Also
--------

### Reference
[Airbraker.Data Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[5]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[6]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[7]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[8]: http://msdn.microsoft.com/en-us/library/42892f65
[9]: http://msdn.microsoft.com/en-us/library/57ctke0a
[10]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[11]: AppVersion.md
[12]: Environment.md
[13]: Hostname.md
[14]: Project.md