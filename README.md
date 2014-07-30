#Airbraker

<img src="http://f.cl.ly/items/0L0G1z0E2A1P3H2O042F/dotnet%2009.19.32.jpg" width=800px>

-----------------------

##Get it now! using NuGet

```powershell
Install-Package Airbraker
```

##Examples

Add the following extension class to your project in order to be able to detect the localtion of the calling routine.
```csharp
using System;
using System.Runtime.CompilerServices;

namespace Airbraker
{
    public static class AirbrakeClientEx
    {
        public static void Send(this AirbrakeClient client, Exception exception,
            [CallerMemberName] string method = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            client.Send(exception, method, file, lineNumber);
        }
    }
}
```

To configure the Airbrake client:

```csharp
        var config = new AirbrakeConfig
        {
            ApiKey = "your-api-key",
            Environment = "dev",
            AppVersion = "1.0",
            ProjectName = "Company.YourProjectName"
        };

        // Initialize Airbrake client.
        _airbrake = new AirbrakeClient(config);
```

Using the client:

```csharp
    try
    {
        //Routine throws an exception
    }
    catch (Exception ex)
    {
        _airbrake.Send(ex);
    }
```

If you cannot access the ```[CallerMemberName]```, ```[CallerFilePath]``` and ```[CallerLineNumber]``` attribtues, then install the __Microsoft BCL Portability Pack__ package. 

From NuGet:

```powershell
PM> Install-Package Microsoft.Bcl
```


##Resources

- [Documentation](Docs)
- [Airbrake Official Website](https://airbrake.io/)


##License

Copyright 2014 SPB TV AG

Licensed under the Apache License, Version 2.0 (the ["License"](License)); you may not use this file except in compliance with the License.

You may obtain a copy of the License at [http://www.apache.org/licenses/LICENSE-2.0](http://www.apache.org/licenses/LICENSE-2.0)

Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 

See the License for the specific language governing permissions and limitations under the License.
