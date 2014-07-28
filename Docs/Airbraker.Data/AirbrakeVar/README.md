AirbrakeVar Class
=================
The params, session, and cgi-data elements can contain one or more var elements for each parameter or variable that was set when the error occurred. Each var element should have a @key attribute for the name of the variable, and element text content for the value of the variable.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **Airbraker.DataAirbrakeVar**  

**Namespace:** [Airbraker.Data][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeVar
```

The **AirbrakeVar** type exposes the following members.


Constructors
------------

Name             | Description                                             
---------------- | ------------------------------------------------------- 
[AirbrakeVar][3] | Initializes a new instance of the **AirbrakeVar** class 


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

Name           | Description                                                  
-------------- | ------------------------------------------------------------ 
[Key][11]      | Gets or sets the key attribute for the name of the variable. 
[Text][12]     | Gets or sets the text content for the value of the variable. 
[VarArray][13] | Gets or sets the array of variables.                         


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
[11]: Key.md
[12]: Text.md
[13]: VarArray.md