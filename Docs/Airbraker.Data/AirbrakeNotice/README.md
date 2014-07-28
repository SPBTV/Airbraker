AirbrakeNotice Class
====================
Represents an Airbrake notice class.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **Airbraker.DataAirbrakeNotice**  

**Namespace:** [Airbraker.Data][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeNotice
```

The **AirbrakeNotice** type exposes the following members.


Constructors
------------

Name                | Description                                                
------------------- | ---------------------------------------------------------- 
[AirbrakeNotice][3] | Initializes a new instance of the **AirbrakeNotice** class 


Methods
-------

Name                 | Description                                                                                                                                                
-------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][4]          | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][5]        | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][6]     | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][7]         | Gets the [Type][8] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][9] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToArray][10]        | Serializes the [Airbraker][11] object to byte array.                                                                                                       
[ToString][12]       | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name                    | Description                                                                                                                                       
----------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------- 
[ApiKey][13]            | Required. The API key for the project that this error belongs to. The API key can be found by viewing the edit project form on the Airbrake site. 
[CurrentUser][14]       | Gets or sets the [AirbrakeCurrentUser][15] data.                                                                                                  
[Error][16]             | Gets or sets the [AirbrakeError][17] error.                                                                                                       
[Notifier][18]          | Gets or sets the [AirbrakeNotifier][19] for the notice.                                                                                           
[Request][20]           | Optional. If this error occurred during an HTTP request, the children of this element can be used to describe the request that caused the error.  
[ServerEnvironment][21] | Optional. The path to the project in which the error occurred, such as RAILS_ROOT or DOCUMENT_ROOT.                                               
[Version][22]           | Required. The version of the API being used. Should be set to "2.3"                                                                               


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
[10]: ToArray.md
[11]: ../../Airbraker/README.md
[12]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[13]: ApiKey.md
[14]: CurrentUser.md
[15]: ../AirbrakeCurrentUser/README.md
[16]: Error.md
[17]: ../AirbrakeError/README.md
[18]: Notifier.md
[19]: ../AirbrakeNotifier/README.md
[20]: Request.md
[21]: ServerEnvironment.md
[22]: Version.md