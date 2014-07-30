using System;
using System.Runtime.CompilerServices;

namespace Airbraker.UnitTests
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
