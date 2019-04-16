using System.Collections.Specialized;
using System.Net;

namespace OpenFaaS.FunctionSDK
{
    public class FunctionResponse<T> where T : class
    {
        public HttpStatusCode StatusCode { get; set; }
        public T Body { get; set; }
        public NameValueCollection Headers { get; set; }
    }
}