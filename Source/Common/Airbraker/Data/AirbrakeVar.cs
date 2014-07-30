using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// The params, session, and cgi-data elements can contain one or more var elements for each parameter or variable that was set when the error
    /// occurred. Each var element should have a @key attribute for the name of the variable, and element text content for the value of the variable.
    /// </summary>
    [XmlRoot("var")]
    public class AirbrakeVar
    {
        /// <summary>
        /// Gets or sets the array of variables.
        /// </summary>
        [XmlElement("var")]
        public AirbrakeVar[] VarArray { get; set; }

        /// <summary>
        /// Gets or sets the text content for the value of the variable.
        /// </summary>
        [XmlText]
        public string[] Text { get; set; }

        /// <summary>
        /// Gets or sets the key attribute for the name of the variable.
        /// </summary>
        [XmlAttribute("key")]
        public string Key { get; set; }
    }
}