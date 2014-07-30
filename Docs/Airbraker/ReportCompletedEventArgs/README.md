ReportCompletedEventArgs Class
==============================
Represents an [EventArgs][1] implementation to be passed in report completion events.


Inheritance Hierarchy
---------------------
[SystemObject][2]  
  [SystemEventArgs][1]  
    **AirbrakerReportCompletedEventArgs**  

**Namespace:** [Airbraker][3]  
**Assembly:**

Syntax
------

```csharp
public class ReportCompletedEventArgs : EventArgs
```

The **ReportCompletedEventArgs** type exposes the following members.


Constructors
------------

Name                          | Description                                                       
----------------------------- | ----------------------------------------------------------------- 
[ReportCompletedEventArgs][4] | Creates a new instance of the **ReportCompletedEventArgs** class. 


Methods
-------

Name                  | Description                                                                                                                                                
--------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Equals][5]           | Determines whether the specified [Object][2] is equal to the current [Object][2]. (Inherited from [Object][2].)                                            
[Finalize][6]         | Allows an object to try to free resources and perform other cleanup operations before it is reclaimed by garbage collection. (Inherited from [Object][2].) 
[GetHashCode][7]      | Serves as a hash function for a particular type. (Inherited from [Object][2].)                                                                             
[GetType][8]          | Gets the [Type][9] of the current instance. (Inherited from [Object][2].)                                                                                  
[MemberwiseClone][10] | Creates a shallow copy of the current [Object][2]. (Inherited from [Object][2].)                                                                           
[ToString][11]        | Returns a string that represents the current object. (Inherited from [Object][2].)                                                                         


Properties
----------

Name           | Description                                                                  
-------------- | ---------------------------------------------------------------------------- 
[Response][12] | Gets the [HttpWebResponse][13], containing the data from the notice request. 


See Also
--------

### Reference
[Airbraker Namespace][3]  

[1]: http://msdn.microsoft.com/en-us/library/118wxtk3
[2]: http://msdn.microsoft.com/en-us/library/e5kfa45b
[3]: ../README.md
[4]: _ctor.md
[5]: http://msdn.microsoft.com/en-us/library/bsc2ak47
[6]: http://msdn.microsoft.com/en-us/library/4k87zsw7
[7]: http://msdn.microsoft.com/en-us/library/zdee4b3y
[8]: http://msdn.microsoft.com/en-us/library/dfwy45w9
[9]: http://msdn.microsoft.com/en-us/library/42892f65
[10]: http://msdn.microsoft.com/en-us/library/57ctke0a
[11]: http://msdn.microsoft.com/en-us/library/7bxwbwt2
[12]: Response.md
[13]: http://msdn.microsoft.com/en-us/library/ww5755y6