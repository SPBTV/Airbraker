AirbrakeRequest Class
=====================
Represents a class that describes a request that caused an error.


Inheritance Hierarchy
---------------------
[SystemObject][1]  
  **Airbraker.DataAirbrakeRequest**  

**Namespace:** [Airbraker.Data][2]  
**Assembly:**

Syntax
------

```csharp
publicclassAirbrakeRequest
```

The **AirbrakeRequest** type exposes the following members.


Constructors
------------

Name                 | Description                                                 
-------------------- | ----------------------------------------------------------- 
[AirbrakeRequest][3] | Initializes a new instance of the **AirbrakeRequest** class 


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

Name            | Description                                                                                                                                                                                                                                    
--------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- 
[Action][11]    | Optional. The action in which the error occurred. If each request is routed to a controller action, this should be set here. Otherwise, this can be set to a method or other request subcategory.                                              
[CgiData][12]   | Optional. A list of var elements describing CGI variables from the request, such as SERVER_NAME and REQUEST_URI. See the section on var elements below.                                                                                        
[Component][13] | Required only if there is a request element. The component in which the error occurred. In model-view-controller frameworks like Rails, this should be set to the controller. Otherwise, this can be set to a route or other request category. 
[Params][14]    | Optional. A list of var elements describing request parameters from the query string, POST body, routing, and other inputs. See the section on var elements below.                                                                             
[Session][15]   | Optional. A list of var elements describing session variables from the request. See the section on var elements below.                                                                                                                         
[Url][16]       | Required only if there is a request element. The URL at which the error occurred.                                                                                                                                                              


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
[11]: Action.md
[12]: CgiData.md
[13]: Component.md
[14]: Params.md
[15]: Session.md
[16]: Url.md