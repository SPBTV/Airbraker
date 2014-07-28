using Airbraker.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        private static readonly object _syncRoot = new Object();
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
                    lock (_syncRoot)
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
        /// <param name="traceLines">Additional trace lines.</param>
        /// <returns>True if data was send successfully, otherwise false.</returns>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="AirbrakeClient"/> instance is not configured properly.</exception>
        public async Task<bool> SendAsync(Exception exception, params AirbrakeTraceLine[] traceLines)
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
                Error = CreateAirbrakeError(exception, traceLines)
            };

            try
            {
                var response = await PostAsync(_config.ServerAddress, notice.ToArray());
                return response.StatusCode == HttpStatusCode.OK;
            }
            catch (WebException)
            {
                return false;
            }
        }

        private AirbrakeError CreateAirbrakeError(Exception exception, params AirbrakeTraceLine[] traceLines)
        {
            if (exception == null)
            {
                throw new ArgumentNullException("exception");
            }
            var lines = new List<AirbrakeTraceLine>();
            if (traceLines != null && traceLines.Any())
            {
                lines.AddRange(traceLines);
            }
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

        private static async Task<HttpWebResponse> PostAsync(Uri requestUri, byte[] content)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.Accept = "text/xml";
            request.ContentType = "text/xml";
            request.Method = "POST";

            using (Stream stream = await request.GetRequestStreamAsync())
            {
                stream.Write(content, 0, content.Length);
            }
            return await request.GetResponseAsync() as HttpWebResponse;
        }

        #endregion
    }
}
