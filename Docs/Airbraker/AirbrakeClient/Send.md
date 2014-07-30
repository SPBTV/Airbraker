AirbrakeClientSend Method
=========================
Sends an error tracking information to the server.

**Namespace:** [Airbraker][1]  
**Assembly:**

Syntax
------

```csharp
public void Send(
	Exception exception,
	string method,
	string file,
	int lineNumber
)
```

### Parameters

#### *exception*
Type: [SystemException][2]  
Exception containing the error information.

#### *method*
Type: [SystemString][3]  
Name of the method in which the error occurred.

#### *file*
Type: [SystemString][3]  
File in which the error occurred.

#### *lineNumber*
Type: [SystemInt32][4]  
Number of the line on which the error occurred.


Exceptions
----------

Exception                      | Condition                                                                
------------------------------ | ------------------------------------------------------------------------ 
[InvalidOperationException][5] | Thrown when the [AirbrakeClient][6] instance is not configured properly. 


See Also
--------

### Reference
[AirbrakeClient Class][6]  
[Airbraker Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/c18k6c59
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/td2s409d
[5]: http://msdn.microsoft.com/en-us/library/2asft85a
[6]: README.md