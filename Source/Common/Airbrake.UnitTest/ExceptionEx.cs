using Airbraker.Data;
using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Airbraker.UnitTests
{
    /// <summary>
    /// Represents an extension class that allows sending exceptions to Airbrake server.
    /// </summary>
    public static class ExceptionEx
    {
        /// <summary>
        /// Sends error data to Airbrake server.
        /// </summary>
        /// <param name="exception">Exception, that has occurred.</param>
        /// <param name="method">Method in which the exception has occurred.</param>
        /// <param name="file">File in which the exception has occurred.</param>
        /// <param name="lineNumber">Line number on which the exception has occurred.</param>
        /// <returns>Response from the Airbrake server.</returns>
        public static async Task<WebResponse> AirbrakeAsync(this Exception exception,
        [CallerMemberName] string method = null,
        [CallerFilePath] string file = null,
        [CallerLineNumber] int lineNumber = 0)
        {
            return await AirbrakeClient.Default.SendAsync(exception, new AirbrakeTraceLine(method, file, lineNumber));
        }
    }
}
