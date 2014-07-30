using System.Net;

namespace Airbraker
{
    internal class HttpWebRequestState
    {
        public byte[] PostBuffer { get; set; }
        public HttpWebRequest Request { get; set; }

        public HttpWebRequestState(HttpWebRequest request, byte[] postBuffer)
        {
            PostBuffer = postBuffer;
            Request = request;
        }
    }
}
