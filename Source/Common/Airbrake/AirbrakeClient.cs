using Airbraker.Data;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace Airbraker
{
    /// <summary>
    /// Represents an Airbrake client that sends error tracking information to a server.
    /// </summary>
    public class AirbrakeClient
    {
        #region Fields

        private static readonly object _lockObject = new Object();
        private AirbrakeConfig _config;
        private AirbrakeNotifier _notifier;
        private IStackTraceParser _stackParser;
        private AirbrakeServerEnvironment _environment;

        #endregion

        #region Default

        private static volatile AirbrakeClient _default;

        /// <summary>
        /// Gets the default singleton instance of the <see cref="AirbrakeClient"/> class.
        /// </summary>
        public static AirbrakeClient Default
        {
            get
            {
                if (_default == null)
                {
                    lock (_lockObject)
                    {
                        if (_default == null)
                        {
                            _default = new AirbrakeClient();
                        }
                    }
                }
                return _default;
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Configures the <see cref="AirbrakeClient"/>.
        /// </summary>
        /// <param name="config">Configuration data.</param>
        /// <param name="notifier">Notifier instance.</param>
        public void Configure(AirbrakeConfig config, AirbrakeNotifier notifier)
        {
            Configure(config, notifier, new RegexStackTraceLineParser());
        }

        /// <summary>
        /// Configures the <see cref="AirbrakeClient"/>.
        /// </summary>
        /// <param name="config">Configuration data.</param>
        /// <param name="notifier">Notifier instance.</param>
        /// <param name="stackParser">Stack parser instance.</param>
        public void Configure(AirbrakeConfig config, AirbrakeNotifier notifier, IStackTraceParser stackParser)
        {
            _config = config;
            _notifier = notifier;
            _stackParser = stackParser;
            _environment = new AirbrakeServerEnvironment
            {
                AppVersion = _config.AppVersion,
                Environment = _config.Environment,
                Project = _config.ProjectName,
                Hostname = _config.Hostname
            };
        }

        /// <summary>
        /// Sends an error tracking information to the server.
        /// </summary>
        /// <param name="exception">Exception containing the error information.</param>
        /// <param name="traceLine">Trace line where the exception has occurred.</param>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="AirbrakeClient"/> instance is not configured properly.</exception>
        public Task<WebResponse> SendAsync(Exception exception, AirbrakeTraceLine traceLine)
        {
            if (_config == null || _notifier == null || _stackParser == null)
            {
                throw new InvalidOperationException("Sending error notice to server failed. Configure Airbraker first.");
            }

            var notice = new AirbrakeNotice
            {
                Version = "2.3",
                ApiKey = _config.ApiKey,
                Notifier = _notifier,
                ServerEnvironment = _environment,
                Error = CreateAirbrakeError(exception, traceLine)
            };

            var request = (HttpWebRequest)WebRequest.Create(_config.ServerAddress);
            request.Accept = "text/xml";
            request.ContentType = "text/xml";

            return request.PostAsync(notice.ToArray());
        }

        private AirbrakeError CreateAirbrakeError(Exception exception, AirbrakeTraceLine traceLine)
        {
            if (exception == null)
            {
                throw new ArgumentNullException("exception");
            }
            var lines = new List<AirbrakeTraceLine>();

            // Add newest trace line on top of all.
            if (traceLine != null)
            {
                lines.Add(traceLine);
            }

            // Parse the rest of the trace lines and append them to the data list.
            if (!String.IsNullOrWhiteSpace(exception.StackTrace))
            {
                lines.AddRange(_stackParser.Parse(exception.StackTrace));
            }
            var error = new AirbrakeError
            {
                Class = exception.GetType().FullName,
                Message = exception.GetType().Name + ": " + exception.Message,
                TraceLines = lines.ToArray()
            };
            return error;
        }

        #endregion
    }
}
