RegexStackTraceLineParser Class
===============================
Represents a simple parser of stack trace information.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **AirbrakerRegexStackTraceLineParser**  

**Namespace:** [Airbraker][2]  
**Assembly:**

Syntax
------

```csharp
public class RegexStackTraceLineParser : IStackTraceParser
```

The **RegexStackTraceLineParser** type exposes the following members.


Constructors
------------

Name                                  | Description                                                                                                                                                          
------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[RegexStackTraceLineParser][3]        | Creates a new instance of the **RegexStackTraceLineParser** class. Default regex expression is set to: @"at (?&lt;method>.*) in (?&lt;file>.*):line (?&lt;line>\d*)" 
[RegexStackTraceLineParser(Regex)][4] | Creates a new instance of the **RegexStackTraceLineParser** class.                                                                                                   


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][5]           | Determines whether the specified [Object][1] is equal to the current [Object][1]. (Inherited from [Object][1].)                                            
[Finalize][6]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][1].) 
[GetHashCode][7]      | Serves as a hash function for a particular type. (Inherited from [Object][1].)                                                                             
[GetType][8]          | Gets the [Type][9] of the current instance. (Inherited from [Object][1].)                                                                                  
[MemberwiseClone][10] | Creates a shallow copy of the current [Object][1]. (Inherited from [Object][1].)                                                                           
[Parse][11]           | Parses a stack trace string into [AirbrakeTraceLine][12] enumeration.                                                                                      
[ToString][13]        | Returns a string that represents the current object. (Inherited from [Object][1].)                                                                         


See Also
--------

### Reference
[Airbraker Namespace][2]  

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
[11]: Parse.md
[12]: ../../Airbraker.Data/AirbrakeTraceLine/README.md
[13]: http://msdn.microsoft.com/en-us/library/7bxwbwt2