using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents an Airbrake error class.
    /// </summary>
    [XmlRoot("error")]
    public class AirbrakeError
    {
        /// <summary>
        /// Required. The class name or type of error that occurred.
        /// </summary>
        [XmlElement("class")]
        public string Class { get; set; }

        /// <summary>
        /// Optional. A short message describing the error that occurred.
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// Required. This element can occur more than once. Each line element describes one code location or frame in the backtrace when the error
        /// occurred, and requires @file and @number attributes. If the location includes a method or function, the @method attribute should be used.
        /// </summary>
        [XmlArray("backtrace"), XmlArrayItem("line", IsNullable = false)]
        public AirbrakeTraceLine[] TraceLines { get; set; }
    }
}