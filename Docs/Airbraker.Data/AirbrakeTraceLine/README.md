AirbrakeTraceLine Class
=======================
Represents a line element, that describes one code location or frame in the backtrace when the error occurred.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **Airbraker.DataAirbrakeTraceLine**  

**Namespace:** [Airbraker.Data][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeTraceLine
```

The **AirbrakeTraceLine** type exposes the following members.


Constructors
------------

Name                                          | Description                                                
--------------------------------------------- | ---------------------------------------------------------- 
[AirbrakeTraceLine][3]                        | Creates a new instance of the **AirbrakeTraceLine** class. 
[AirbrakeTraceLine(String, String, Int32)][4] | Creates a new instance of the **AirbrakeTraceLine** class. 


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][5]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][6]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][7]      | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][8]          | Gets the [Type][9] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][10] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[ToString][11]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


Properties
----------

Name             | Description                                               
---------------- | --------------------------------------------------------- 
[File][12]       | Gets or sets the file in which the error occurred.        
[LineNumber][13] | Gets or sets the line number on which the error occurred. 
[Method][14]     | Gets or sets the method in which the error occurred.      


See Also
--------

### Reference
[Airbraker.Data Namespace][2]  

[1]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[2]: ../README.md
[3]: _ctor.md
[4]: _ctor_1.md
[5]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[6]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[7]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[8]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[9]: http://msdn.microsoft.com/en-us/library/42892f65
[10]: http://msdn.microsoft.com/en-us/library/57ctke0a
[11]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[12]: File.md
[13]: LineNumber.md
[14]: Method.md