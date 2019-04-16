using System;
using System.Collections.Specialized;
using System.Net.Http;

namespace OpenFaaS.FunctionSDK
{
    public class FunctionContext<T> where T : class
    {
        public T Body { get; set; }
        public NameValueCollection QueryString { get; set; }
        public HttpMethod Method { get; set; }
        public NameValueCollection Headers { get; set; }
    }
}
