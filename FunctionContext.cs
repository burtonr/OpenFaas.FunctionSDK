using System;
using System.Collections.Specialized;
using System.Net.Http;

namespace OpenFaaS.FunctionSDK
{
    public class FunctionContext
    {
        public object Body { get; set; }
        public NameValueCollection QueryString { get; set; }
        public HttpMethod Method { get; set; }
        public NameValueCollection Headers { get; set; }
    }
}
