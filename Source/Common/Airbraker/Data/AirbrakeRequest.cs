using System.Xml.Serialization;

namespace Airbraker.Data
{
    /// <summary>
    /// Represents a class that describes a request that caused an error.
    /// </summary>
    [XmlRoot("request")]
    public class AirbrakeRequest
    {
        /// <summary>
        /// Required only if there is a request element. The URL at which the error occurred.
        /// </summary>
        [XmlElement("url")]
        public string Url { get; set; }

        /// <summary>
        /// Required only if there is a request element. The component in which the error occurred. In model-view-controller frameworks like Rails, this
        /// should be set to the controller. Otherwise, this can be set to a route or other request category.
        /// </summary>
        [XmlElement("component")]
        public string Component { get; set; }

        /// <summary>
        /// Optional. The action in which the error occurred. If each request is routed to a controller action, this should be set here. Otherwise, this can be
        /// set to a method or other request subcategory.
        /// </summary>
        [XmlElement("action")]
        public string Action { get; set; }

        /// <summary>
        /// Optional. A list of var elements describing request parameters from the query string, POST body, routing, and other inputs. See the section on
        /// var elements below.
        /// </summary>
        [XmlArray("params"), XmlArrayItem("var", IsNullable = false)]
        public AirbrakeVar[] Params { get; set; }

        /// <summary>
        /// Optional. A list of var elements describing session variables from the request. See the section on var elements below.
        /// </summary>
        [XmlArray("session"), XmlArrayItem("var", IsNullable = false)]
        public AirbrakeVar[] Session { get; set; }

        /// <summary>
        /// Optional. A list of var elements describing CGI variables from the request, such as SERVER_NAME and REQUEST_URI. See the section on var
        /// elements below.
        /// </summary>
        [XmlArray("cgi-data"), XmlArrayItem("var", IsNullable = false)]
        public AirbrakeVar[] CgiData { get; set; }
    }
}