using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Airbraker
{
    internal static class WebRequestEx
    {
        public static Task<WebResponse> PostAsync(this WebRequest request, byte[] content)
        {
            request.Method = "POST";
            return request.GetRequestStreamAsync()
                .ContinueWith(task =>
                {
                    using (var stream = task.Result)
                    {
                        stream.Write(content, 0, content.Length);
                    }
                })
                .ContinueWith(_ =>
                    request.GetResponseAsync()).Unwrap();
        }

        private static Task<Stream> GetRequestStreamAsync(this WebRequest request)
        {
            return Task.Factory.FromAsync<Stream>(
                request.BeginGetRequestStream, request.EndGetRequestStream, request);
        }

        private static Task<WebResponse> GetResponseAsync(this WebRequest request)
        {
            return Task.Factory.FromAsync<WebResponse>(
                request.BeginGetResponse, request.EndGetResponse, request);
        }
    }
}
