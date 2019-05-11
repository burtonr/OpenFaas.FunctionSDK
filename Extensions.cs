using System.Net;

namespace OpenFaaS.FunctionSDK
{
    public static class Extensions
    {
        public static int ToStatusInt(this HttpStatusCode code)
        {
            var intCode = (int)code;

            return code == 0 ? 200 : intCode;
        }
    }
}