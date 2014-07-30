using System;
using System.Net;

namespace Airbraker
{
    /// <summary>
    /// Represents an <see cref="EventArgs"/> implementation to be passed in report completion events.
    /// </summary>
    public class ReportCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Gets the <see cref="HttpWebResponse"/>, containing the data from the notice request.
        /// </summary>
        public HttpWebResponse Response { get; private set; }

        /// <summary>
        /// Creates a new instance of the <see cref="ReportCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="response">Response of the notice request.</param>
        public ReportCompletedEventArgs(HttpWebResponse response)
        {
            Response = response;
        }
    }
}
