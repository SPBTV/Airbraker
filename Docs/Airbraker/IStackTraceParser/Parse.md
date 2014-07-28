IStackTraceParserParse Method
=============================
Parses a stack trace string into [AirbrakeTraceLine][1] enumeration.

**Namespace:** [Airbraker][2]  
**Assembly:**

Syntax
------

```csharp
IEnumerable<AirbrakeTraceLine> Parse(
	string stackTrace
)
```

### Parameters

#### *stackTrace*
Type: [SystemString][3]  
String data containing the stack trace information.

### Return Value
Type: [IEnumerable][4][AirbrakeTraceLine][1]  
[IEnumerableT][4] of [AirbrakeTraceLine][1]

See Also
--------

### Reference
[IStackTraceParser Interface][5]  
[Airbraker Namespace][2]  

[1]: ../../Airbraker.Data/AirbrakeTraceLine/README.md
[2]: ../README.md
[3]: http://msdn.microsoft.com/en-us/library/s1wwdcbf
[4]: http://msdn.microsoft.com/en-us/library/9eekhta0
[5]: README.md