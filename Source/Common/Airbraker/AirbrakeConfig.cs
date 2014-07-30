using System;

namespace Airbraker
{
    /// <summary>
    /// Represents an <see cref="AirbrakeClient"/> configuration.
    /// </summary>
    public class AirbrakeConfig
    {
        /// <summary>
        /// Gets the Airbrake server address.
        /// </summary>
        public Uri ServerAddress { get; private set; }

        /// <summary>
        /// Gets or sets the project api key.
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Gets or sets the runtime environment (such as 'staging' or 'production').
        /// </summary>
        public string Environment { get; set; }

        /// <summary>
        /// Gets or sets the project root name.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        /// Gets or sets the application version.
        /// </summary>
        public string AppVersion { get; set; }

        /// <summary>
        /// Gets or sets the hostname.
        /// </summary>
        public string Hostname { get; set; }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeConfig"/> class, and initializes the server address to API 2.3 value.
        /// </summary>
        public AirbrakeConfig()
        {
            ServerAddress = new Uri("https://api.airbrake.io/notifier_api/v2/notices");
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeConfig"/> class.
        /// </summary>
        /// <param name="serverAddress">Server address.</param>
        public AirbrakeConfig(Uri serverAddress)
        {
            ServerAddress = serverAddress;
        }
    }
}
