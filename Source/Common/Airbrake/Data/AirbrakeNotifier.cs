using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents an Airbrake notifier class.
    /// </summary>
    [XmlRoot("notifier")]
    public class AirbrakeNotifier
    {
        /// <summary>
        /// Required. The name of the notifier client submitting the request, such as "hoptoad4j" or "rack-hoptoad."
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Required. The version number of the notifier client submitting the request.
        /// </summary>
        [XmlElement("version")]
        public string Version { get; set; }

        /// <summary>
        /// Required. A URL at which more information can be obtained concerning the notifier client.
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeNotifier"/> class.
        /// </summary>
        public AirbrakeNotifier()
        {
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeNotifier"/> class.
        /// </summary>
        /// <param name="name">Name of the notifier.</param>
        /// <param name="version">Version of the notifier.</param>
        /// <param name="url">Description url of the notifier.</param>
        public AirbrakeNotifier(string name, string version, string url)
        {
            Name = name;
            Version = version;
            Url = url;
        }
    }
}