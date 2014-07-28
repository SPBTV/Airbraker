AirbrakeClientSendAsync Method
==============================
Sends an error tracking information to the server.

**Namespace:** [Airbraker][1]  
**Assembly:**

Syntax
------

```csharp
public Task<bool> SendAsync(
	Exception exception,
	params AirbrakeTraceLine[] traceLines
)
```

### Parameters

#### *exception*
Type: [SystemException][2]  
Exception containing the error information.

#### *traceLines*
Type: [Airbraker.DataAirbrakeTraceLine][3]  
Additional trace lines.

### Return Value
Type: [Task][4][Boolean][5]  
True if data was send successfully, otherwise false.

Exceptions
----------

Exception                      | Condition                                                                
------------------------------ | ------------------------------------------------------------------------ 
[InvalidOperationException][6] | Thrown when the [AirbrakeClient][7] instance is not configured properly. 


See Also
--------

### Reference
[AirbrakeClient Class][7]  
[Airbraker Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/c18k6c59
[3]: ../../Airbraker.Data/AirbrakeTraceLine/README.md
[4]: http://msdn.microsoft.com/en-us/library/dd321424
[5]: http://msdn.microsoft.com/en-us/library/a28wyd50
[6]: http://msdn.microsoft.com/en-us/library/2asft85a
[7]: README.md