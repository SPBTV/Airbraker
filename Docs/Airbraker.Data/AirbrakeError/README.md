AirbrakeError Class
===================
Represents an Airbrake error class.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **Airbraker.DataAirbrakeError**  

**Namespace:** [Airbraker.Data][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeError
```

The **AirbrakeError** type exposes the following members.


Constructors
------------

Name               | Description                                               
------------------ | --------------------------------------------------------- 
[AirbrakeError][3] | Initializes a new instance of the **AirbrakeError** class 


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

Name             | Description                                                                                                                                                                                                                                                                       
---------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Class][11]      | Required. The class name or type of error that occurred.                                                                                                                                                                                                                          
[Message][12]    | Optional. A short message describing the error that occurred.                                                                                                                                                                                                                     
[TraceLines][13] | Required. This element can occur more than once. Each line element describes one code location or frame in the backtrace when the error occurred, and requires @file and @number attributes. If the location includes a method or function, the @method attribute should be used. 


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
[11]: Class.md
[12]: Message.md
[13]: TraceLines.md