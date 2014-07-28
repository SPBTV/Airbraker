using Airbraker.Data;
using Airbraker.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

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
            var notifier = new AirbrakeNotifier("AirbreakerUnitTest", "1.0", "https://github.com/bagabont/airbraker");

            // Configure airbreak.
            _airbrake = AirbrakeClient.Default;
            _airbrake.Configure(config, notifier);
        }

        [TestMethod]
        public async Task AirbreakerSendAsyncTest()
        {
            Task<bool> sendTask = null;
            try
            {
                var divResult = Divide(4, 2);

                divResult = Divide(divResult, 0); // Divide by zero

                Assert.Fail("Divide by zero did not throw an exception. Division result: {0}", divResult);
            }
            catch (Exception ex)
            {
                sendTask = ex.AirbrakeAsync();
            }
            var result = await sendTask; // Make sure that the airbrake notice was sent.
            Assert.IsTrue(result);
        }

        private static int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
