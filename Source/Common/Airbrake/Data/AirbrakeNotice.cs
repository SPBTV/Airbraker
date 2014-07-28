using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents an Airbrake notice class.
    /// </summary>
    [XmlRoot("notice", Namespace = "", IsNullable = false)]
    public class AirbrakeNotice
    {
        /// <summary>
        /// Required. The API key for the project that this error belongs to. The API key can be found by viewing the edit project form on the Airbrake site.
        /// </summary>
        [XmlElement("api-key")]
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="AirbrakeNotifier"/> for the notice.
        /// </summary>
        [XmlElement("notifier")]
        public AirbrakeNotifier Notifier { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="AirbrakeError"/> error.
        /// </summary>
        [XmlElement("error")]
        public AirbrakeError Error { get; set; }

        /// <summary>
        /// Optional. If this error occurred during an HTTP request, the children of this element can be used to describe the request that caused the error.
        /// </summary>
        [XmlElement("request")]
        public AirbrakeRequest Request { get; set; }

        /// <summary>
        /// Optional. The path to the project in which the error occurred, such as RAILS_ROOT or DOCUMENT_ROOT.
        /// </summary>
        [XmlElement("server-environment")]
        public AirbrakeServerEnvironment ServerEnvironment { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="AirbrakeCurrentUser"/> data.
        /// </summary>
        [XmlElement("current-user")]
        public AirbrakeCurrentUser CurrentUser { get; set; }

        /// <summary>
        /// Required. The version of the API being used. Should be set to "2.3"
        /// </summary>
        [XmlAttribute("version")]
        public string Version { get; set; }

        /// <summary>
        /// Serializes the <see cref="Airbraker"/> object to byte array.
        /// </summary>
        /// <returns></returns>
        public byte[] ToArray()
        {
            var serializer = new XmlSerializer(typeof(AirbrakeNotice));
            using (var ms = new MemoryStream())
            {
                using (var xmlWriter = XmlWriter.Create(ms))
                {
                    serializer.Serialize(xmlWriter, this);
                    return ms.ToArray();
                }
            }
        }
    }
}