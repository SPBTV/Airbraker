using System.Net;
using Airbraker.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading;

namespace Airbraker.UnitTests
{
    [TestClass]
    public class AirbrakerTests
    {
        private AirbrakeClient _airbrake;
        private const string ApiKey = "76fdb93ab2cf276ec080671a8b3d3866";

        [TestInitialize]
        [TestMethod]
        public void InitializeAirbrakeClient()
        {
            var config = new AirbrakeConfig
            {
                ApiKey = ApiKey,
                Environment = "UnitTest",
                AppVersion = "1.0",
                ProjectName = "Airbraker.UnitTests"
            };

            // Initialize Airbrake client.
            _airbrake = new AirbrakeClient(config);
        }

        [TestMethod]
        public void SendToAirbrakeTest()
        {
            var done = new ManualResetEvent(false);
            HttpWebResponse response = null;
            _airbrake.ReportSucceeded += (s, e) =>
            {
                response = e.Response;
                if (response.StatusCode != HttpStatusCode.OK)
                {
                    Assert.Fail("Status code must be equal to HttpStatusCode.OK");
                }
                done.Set();
            };

            _airbrake.ReportFailed += (s, e) =>
            {
                response = e.Response;
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Assert.Fail("Status code must NOT be equal to HttpStatusCode.OK");
                }
                done.Set();
            };

            try
            {
                var divResult = Divide(4, 2);
                divResult = Divide(divResult, 0); // Divide by zero
                Assert.Fail("Divide by zero did not throw an exception. Division result: {0}", divResult);
            }
            catch (Exception ex)
            {
                // Try to send to airbrake server.
                _airbrake.Send(ex);
            }
            // Wait 2 sec. to get the response.
            done.WaitOne(2000);
            Assert.IsTrue(response != null);
        }

        private static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
