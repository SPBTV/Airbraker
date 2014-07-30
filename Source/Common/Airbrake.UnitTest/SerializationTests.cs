using Airbraker.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Airbraker.UnitTests
{
    [TestClass]
    public class SerializationTests
    {
        [TestMethod]
        public void SerializeAirbrakeNoticeTest()
        {
            var notice = new AirbrakeNotice
            {
                Version = "2.3",
                ApiKey = "123",
                Notifier = new AirbrakeNotifier("1", "2", "3"),
                ServerEnvironment = new AirbrakeServerEnvironment()
                {
                    AppVersion = "1.0",
                    Environment = "none",
                    Hostname = "youhost",
                    Project = "unit-test"
                },
                Error = new AirbrakeError
                {
                    Class = "Runtime",
                    Message = "Example message",
                    TraceLines = new[]
                    {
                        new AirbrakeTraceLine("someMethod","someFile",0)
                    }
                }
            };
            var result = notice.ToArray();
            Assert.IsTrue(result.Length > 0, "Serialized notice data is empty.");
        }
    }
}
