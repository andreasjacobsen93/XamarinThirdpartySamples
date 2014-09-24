using System;
using System.IO;
using System.Net;
using Android.Util;

namespace Metro
{
    public class HttpServiceHelper
    {
        public static void GetAppSettings(string address, string parameters, Action<string> onResponseGot)
        {
            var uri = new Uri(address);
            var r = (HttpWebRequest)WebRequest.Create(uri);
            r.Method = "POST";
            r.ContentType = "application/json";

            r.BeginGetRequestStream(delegate(IAsyncResult req)
            {
                var outStream = r.EndGetRequestStream(req);

                using (var w = new StreamWriter(outStream))
                    w.Write(parameters);

                r.BeginGetResponse(delegate(IAsyncResult result)
                {
                    try
                    {
                        var response = (HttpWebResponse)r.EndGetResponse(result);

                        using (var stream = response.GetResponseStream())
                        {
                            using (var reader = new StreamReader(stream))
                            {
                                onResponseGot(reader.ReadToEnd());
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error("Track", ex.ToString());
                    }

                }, null);

            }, null);
        }
    }
}