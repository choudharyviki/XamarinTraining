using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace iOSTraining.Model
{
    public class ApiHelper 
    {

        
        public ApiHelper()
        {
        }
        async public static Task<string> GetAsync()
        {
            var rr = WebRequest.CreateHttp("http://reqres.in/api/unknown");
            rr.Method = "GET";
            rr.ContentType = "application/JSON";
             rr.BeginGetResponse(ResponeseComplete, rr);
            return null;
        }

        private static void ResponeseComplete(IAsyncResult ar)
        {
            try
            {
                var request = ar.AsyncState as HttpWebRequest;

                if (request != null)
                {
                    var result = request;
                }
            }
            catch (Exception e)
            { }
        }
    }
}
