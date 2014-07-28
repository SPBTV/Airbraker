using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents a server environment.
    /// </summary>
    [XmlRoot("server-environment")]
    public class AirbrakeServerEnvironment
    {
        /// <summary>
        /// Gets or sets the project root name, where the error occurred.
        /// </summary>
        [XmlElement("project-root")]
        public string Project { get; set; }

        /// <summary>
        /// Required. The name of the server environment in which the error occurred, such as "staging" or "production."
        /// </summary>
        [XmlElement("environment-name")]
        public string Environment { get; set; }

        /// <summary>
        /// Optional. The version of the application that this error came from. If the App Version is set on the project, then errors older than the project's app
        /// version will be ignored. This version field uses Semantic Versioning style versioning.
        /// </summary>
        [XmlElement("app-version")]
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or sets the environment hostname.
        /// </summary>
        [XmlElement("hostname")]
        public string Hostname { get; set; }
    }
}