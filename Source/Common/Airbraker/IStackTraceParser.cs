using Airbraker.Data;
using System.Collections.Generic;

namespace Airbraker
{
    /// <summary>
    /// Represents a stack trace parser
    /// </summary>
    public interface IStackTraceParser
    {
        /// <summary>
        /// Parses a stack trace string into <see cref="AirbrakeTraceLine"/> enumeration.
        /// </summary>
        /// <param name="stackTrace">String data containing the stack trace information.</param>
        /// <returns><see cref="IEnumerable{T}"/> of <see cref="AirbrakeTraceLine"/></returns>
        IEnumerable<AirbrakeTraceLine> Parse(string stackTrace);
    }
}
