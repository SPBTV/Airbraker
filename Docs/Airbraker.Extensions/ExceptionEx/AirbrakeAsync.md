ExceptionExAirbrakeAsync Method
===============================
Sends an exception to the Airbake server.

**Namespace:** [Airbraker.Extensions][1]  
**Assembly:**

Syntax
------

```csharp
public static Task<bool> AirbrakeAsync(
	this Exception exception,
	string method = null,
	string file = null,
	int lineNumber = 0
)
```

### Parameters

#### *exception*
Type: [SystemException][2]  
Exception that occurred an needs to be send.

#### *method* (Optional)
Type: [SystemString][3]  
Method in which the exception occurred.

#### *file* (Optional)
Type: [SystemString][3]  
File in which the exception occurred.

#### *lineNumber* (Optional)
Type: [SystemInt32][4]  
Line number on which the exception occurred.

### Return Value
Type: [Task][5][Boolean][6]  

[Missing &lt;returns> documentation for "M:Airbraker.Extensions.ExceptionEx.AirbrakeAsync(System.Exception,System.String,System.String,System.Int32)"]

### Usage Note
In Visual Basic and C#, you can call this method as an instance method on any object of type [Exception][2]. When you use instance method syntax to call this method, omit the first parameter. For more information, see [Extension Methods (Visual Basic)][7] or [Extension Methods (C# Programming Guide)][8].

See Also
--------

### Reference
[ExceptionEx Class][9]  
[Airbraker.Extensions Namespace][1]  

[1]: ../README.md
[2]: http://msdn.microsoft.com/en-us/library/c18k6c59
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/td2s409d
[5]: http://msdn.microsoft.com/en-us/library/dd321424
[6]: http://msdn.microsoft.com/en-us/library/a28wyd50
[7]: http://msdn.microsoft.com/en-us/library/bb384936.aspx
[8]: http://msdn.microsoft.com/en-us/library/bb383977.aspx
[9]: README.md