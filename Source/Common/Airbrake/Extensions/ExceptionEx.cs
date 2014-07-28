using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Airbraker.Data;

namespace Airbraker.Extensions
{
    /// <summary>
    /// Represents an extension class for exceptions.
    /// </summary>
    public static class ExceptionEx
    {
        /// <summary>
        /// Sends an exception to the Airbake server.
        /// </summary>
        /// <param name="exception">Exception that occurred an needs to be send.</param>
        /// <param name="method">Method in which the exception occurred.</param>
        /// <param name="file">File in which the exception occurred.</param>
        /// <param name="lineNumber">Line number on which the exception occurred.</param>
        /// <returns></returns>
        public static async Task<bool> AirbrakeAsync(this Exception exception,
            [CallerMemberName] string method = null,
            [CallerFilePath] string file = null,
            [CallerLineNumber] int lineNumber = 0)
        {
            return await AirbrakeClient.Default.SendAsync(exception, new AirbrakeTraceLine(method, file, lineNumber));
        }
    }
}
