AirbrakeErrorTraceLines Property
================================
Required. This element can occur more than once. Each line element describes one code location or frame in the backtrace when the error occurred, and requires @file and @number attributes. If the location includes a method or function, the @method attribute should be used.

**Namespace:** [Airbraker.Data][1]  
**Assembly:**

Syntax
------

```csharp
public AirbrakeTraceLine[] TraceLines { get; set; }
```

### Property Value
Type: [AirbrakeTraceLine][2]

See Also
--------

### Reference
[AirbrakeError Class][3]  
[Airbraker.Data Namespace][1]  

[1]: ../README.md
[2]: ../AirbrakeTraceLine/README.md
[3]: README.md