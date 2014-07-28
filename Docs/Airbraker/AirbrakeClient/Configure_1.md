AirbrakeClientConfigure Method (AirbrakeConfig, AirbrakeNotifier, IStackTraceParser)
====================================================================================
Configures the [AirbrakeClient][1].

**Namespace:** [Airbraker][2]  
**Assembly:**

Syntax
------

```csharp
public void Configure(
	AirbrakeConfig config,
	AirbrakeNotifier notifier,
	IStackTraceParser stackParser
)
```

### Parameters

#### *config*
Type: [AirbrakerAirbrakeConfig][3]  
Configuration data.

#### *notifier*
Type: [Airbraker.DataAirbrakeNotifier][4]  
Notifier instance.

#### *stackParser*
Type: [AirbrakerIStackTraceParser][5]  
Stack parser instance.


See Also
--------

### Reference
[AirbrakeClient Class][1]  
[Airbraker Namespace][2]  

[1]: README.md
[2]: ../README.md
[3]: ../AirbrakeConfig/README.md
[4]: ../../Airbraker.Data/AirbrakeNotifier/README.md
[5]: ../IStackTraceParser/README.md