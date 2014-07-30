using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents a line element, that describes one code location or frame in the backtrace when the error occurred.
    /// </summary>
    [XmlRoot("line")]
    public class AirbrakeTraceLine
    {
        /// <summary>
        /// Gets or sets the file in which the error occurred.
        /// </summary>
        [XmlAttribute("file")]
        public string File { get; set; }

        /// <summary>
        /// Gets or sets the line number on which the error occurred.
        /// </summary>
        [XmlAttribute("number")]
        public string LineNumber { get; set; }

        /// <summary>
        /// Gets or sets the method in which the error occurred.
        /// </summary>
        [XmlAttribute("method")]
        public string Method { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeTraceLine"/> class.
        /// </summary>
        public AirbrakeTraceLine()
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeTraceLine"/> class.
        /// </summary>
        /// <param name="method">Name of the method in which the error occurred.</param>
        /// <param name="file">File in which the error occurred.</param>
        /// <param name="lineNumber">Number of the line on which the error occurred.</param>
        public AirbrakeTraceLine(string method, string file, int lineNumber)
        {
            Method = method;
            File = file;
            LineNumber = lineNumber.ToString();
        }
    }
}