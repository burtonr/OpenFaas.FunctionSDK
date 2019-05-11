using System.Collections.Specialized;
using System.Net;
using System.Net.Mime;

namespace OpenFaaS.FunctionSDK
{
    public class FunctionResponse
    {
        public HttpStatusCode StatusCode { get; set; }
        public object Body { get; set; }
        public NameValueCollection Headers { get; set; }
    }
}