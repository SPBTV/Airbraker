using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents a current user info class.
    /// </summary>
    [XmlType(TypeName = "current-user")]
    [XmlRoot("current-user")]
    public class AirbrakeCurrentUser
    {
        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        [XmlElement("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the user email.
        /// </summary>
        [XmlElement("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the username of the user.
        /// </summary>
        [XmlElement("username")]
        public string Username { get; set; }
    }
}