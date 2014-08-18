using System.Reflection;
using Airbraker.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace Airbraker
{
    /// <summary>
    /// Represents an Airbrake client that sends error tracking information to a server.
    /// </summary>
    public class AirbrakeClient
    {
        #region Events

        /// <summary>
        /// Fired when the notice to the Airbrake is sent successfully.
        /// </summary>
        public event EventHandler<ReportCompletedEventArgs> ReportSucceeded;

        /// <summary>
        /// Fires the <see cref="ReportSucceeded"/> event.
        /// </summary>
        protected virtual void OnReportSucceeded(ReportCompletedEventArgs e)
        {
            var handler = ReportSucceeded;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// Fired when the notice to the Airbrake server fails to be send.
        /// </summary>
        public event EventHandler<ReportCompletedEventArgs> ReportFailed;

        /// <summary>
        /// Fires the <see cref="ReportFailed"/> event.
        /// </summary>
        protected virtual void OnReportFailed(ReportCompletedEventArgs e)
        {
            var handler = ReportFailed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        #endregion

        #region Fields

        private AirbrakeConfig _config;
        private AirbrakeNotifier _notifier;
        private IStackTraceParser _stackParser;
        private AirbrakeServerEnvironment _environment;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeClient"/> class.
        /// </summary>
        /// <param name="config">Configuration data.</param>
        /// <param name="notifier">Notifier instance.</param>
        /// <param name="stackParser">Stack parser instance.</param>
        public AirbrakeClient(AirbrakeConfig config, AirbrakeNotifier notifier, IStackTraceParser stackParser)
        {
            Configure(config, notifier, stackParser);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeClient"/> class, and configures it 
        /// to use the <see cref="RegexStackTraceLineParser"/> parser.
        /// </summary>
        /// <param name="config">Configuration data.</param>
        /// <param name="notifier">Notifier instance.</param>        
        public AirbrakeClient(AirbrakeConfig config, AirbrakeNotifier notifier)
        {
            Configure(config, notifier);
        }

        /// <summary>
        /// Creates a new instance of the <see cref="AirbrakeClient"/> class, and configures it 
        /// to use the <see cref="RegexStackTraceLineParser"/> parser.
        /// </summary>
        /// <param name="config">Configuration data.</param>        
        public AirbrakeClient(AirbrakeConfig config)
        {
            string name = GetType().Assembly.FullName;
            var asmName = new AssemblyName(name);
            var version = asmName.Version.Major + "." + asmName.Version.Minor;
            var notifier = new AirbrakeNotifier("Airbraker", version, "https://github.com/SPBTV/Airbraker");
            Configure(config, notifier);
        }

        #endregion

        #region Methods

        /// <summary>
        /// Configures the <see cref="AirbrakeClient"/>, using the <see cref="RegexStackTraceLineParser"/> parser.
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
        /// <param name="method">Name of the method in which the error occurred.</param>
        /// <param name="file">File in which the error occurred.</param>
        /// <param name="lineNumber">Number of the line on which the error occurred.</param>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="AirbrakeClient"/> instance is not configured properly.</exception>
        public void Send(Exception exception, string method, string file, int lineNumber)
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
                Error = CreateAirbrakeError(exception, method, file, lineNumber)
            };
            Send(notice);
        }

        /// <summary>
        /// Sends an error tracking information to the server.
        /// </summary>
        /// <param name="notice">Notice to be send.</param>
        /// <exception cref="InvalidOperationException">Thrown when the <see cref="AirbrakeClient"/> instance is not configured properly.</exception>
        public void Send(AirbrakeNotice notice)
        {
            if (notice == null)
                throw new ArgumentNullException("notice");

            if (_config == null || _notifier == null || _stackParser == null)
                throw new InvalidOperationException("Sending error notice to server failed. Configure Airbraker first.");

            PostAsync(_config.ServerAddress, notice.ToArray());
        }


        private void PostAsync(Uri requestUri, byte[] content)
        {
            var request = (HttpWebRequest)WebRequest.Create(requestUri);
            request.Accept = "text/xml";
            request.ContentType = "text/xml";
            request.Method = "POST";
            var state = new HttpWebRequestState(request, content);
            request.BeginGetRequestStream(GetRequestStreamCallback, state);
        }

        private void GetRequestStreamCallback(IAsyncResult result)
        {
            var state = (HttpWebRequestState)result.AsyncState;
            var request = state.Request;
            using (Stream postStream = request.EndGetRequestStream(result))
            {
                // Write to the request stream.
                postStream.Write(state.PostBuffer, 0, state.PostBuffer.Length);
            }
            // Start the asynchronous operation to get the response
            request.BeginGetResponse(GetResponseCallback, state);
        }

        private void GetResponseCallback(IAsyncResult result)
        {
            var state = (HttpWebRequestState)result.AsyncState;
            var request = state.Request;
            HttpWebResponse response = null;

            try
            {
                response = (HttpWebResponse)request.EndGetResponse(result);
                OnReportSucceeded(new ReportCompletedEventArgs(response));
            }
            catch (WebException exception)
            {
                response = exception.Response as HttpWebResponse;
                OnReportFailed(new ReportCompletedEventArgs(response));
            }
        }

        private AirbrakeError CreateAirbrakeError(Exception exception, string method, string file, int lineNumber)
        {
            if (exception == null)
                throw new ArgumentNullException("exception");

            var lines = new List<AirbrakeTraceLine>
            {
                new AirbrakeTraceLine(method, file, lineNumber)
            };

            // Parse the rest of the trace lines and append them to the data list.
            if (!String.IsNullOrWhiteSpace(exception.StackTrace))
                lines.AddRange(_stackParser.Parse(exception.StackTrace));

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
