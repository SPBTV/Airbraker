using Airbraker.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Airbraker
{
    /// <summary>
    /// Represents a simple parser of stack trace information.
    /// </summary>
    public class RegexStackTraceLineParser : IStackTraceParser
    {
        private readonly Regex _regex;

        /// <summary>
        /// Creates a new instance of the <see cref="RegexStackTraceLineParser"/> class. Default regex expresion is set to: <![CDATA[ @"at (?<method>.*) in (?<file>.*):line (?<line>\d*)" ]]>
        /// </summary>
        public RegexStackTraceLineParser()
        {
            _regex = new Regex(@"at (?<method>.*) in (?<file>.*):line (?<line>\d*)");
        }

        /// <summary>
        /// Creates a new instance of the <see cref="RegexStackTraceLineParser"/> class.
        /// </summary>
        /// <param name="regex">Regex expression that matches the stack trace line description.</param>
        public RegexStackTraceLineParser(Regex regex)
        {
            if (regex == null)
            {
                throw new ArgumentNullException("regex");
            }
            _regex = regex;
        }

        /// <summary>
        /// Parses a stack trace string into <see cref="AirbrakeTraceLine"/> enumeration.
        /// </summary>
        /// <param name="stackTrace">String data containing the stack trace information.</param>
        /// <returns><see cref="IEnumerable{T}"/> of <see cref="AirbrakeTraceLine"/></returns>
        public IEnumerable<AirbrakeTraceLine> Parse(string stackTrace)
        {
            IList<AirbrakeTraceLine> traceLines = new List<AirbrakeTraceLine>();
            if (String.IsNullOrWhiteSpace(stackTrace))
            {
                return traceLines;
            }

            var matches = _regex.Matches(stackTrace);
            if (!matches.OfType<Match>().Any())
            {
                return traceLines;
            }

            foreach (Match match in matches)
            {
                if (match.Success)
                {
                    var method = match.Groups["method"].Value;
                    var file = match.Groups["file"].Value;
                    var line = match.Groups["line"].Value;
                    traceLines.Add(new AirbrakeTraceLine(method, file, Int32.Parse(line)));
                }
            }
            return traceLines;
        }
    }
}