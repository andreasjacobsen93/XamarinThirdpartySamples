using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using XamarinWeatherCloneApp.Events;
using XamarinWeatherCloneApp.Response;

namespace XamarinWeatherCloneApp.Client
{
    public delegate void RequestCompletedEventHandler(object sender, RequestEventArgs e);
    public delegate void RequestErrorEventHandler(object sender, RequestEventArgs e);

    public class WeatherHttpClient
    {
        public event RequestCompletedEventHandler RequestCompleted;
        public event RequestErrorEventHandler RequestError;

        public void Request(string location)
        {
            try
            {
                var request = HttpWebRequest.Create(@"http://api.openweathermap.org/data/2.5/weather?q=" + location);
                request.Method = "GET";
                var result = (IAsyncResult)request.BeginGetResponse(ResponseCallback, request);
            }
            catch (Exception ex)
            {
                if (RequestError != null)
                {
                    //Raise Request Error (with custom Exception during response call back)
                    RequestError(this, new RequestEventArgs()
                    {
                        IsError = true,
                        ErrorMessage = Constants.REQUEST_EXCEPTION,
                        Exception = ex
                    });
                }
            }
        }

        private void ResponseCallback(IAsyncResult result)
        {
            try
            {
                var request = (HttpWebRequest)result.AsyncState;
                var response = request.EndGetResponse(result);

                using (var stream = response.GetResponseStream())
                using (var reader = new StreamReader(stream))
                {
                    string contents = reader.ReadToEnd();
                    ParseJson(contents);
                }
            }
            catch (Exception ex)
            {
                if (RequestError != null)
                {
                    //Raise Sync Error (Custom Exception during response call back)
                    RequestError(this, new RequestEventArgs()
                    {
                        IsError = true,
                        ErrorMessage = Constants.REQUEST_CALLBACK_EXCEPTION,
                        Exception = ex
                    });
                }
            }
        }

        private void ParseJson(string jsonString)
        {
            try
            {
                RootObject rootObject = new RootObject();
                rootObject = JsonConvert.DeserializeObject<RootObject>(jsonString);

                if(RequestCompleted!= null)
                {
                    RequestCompleted(this, new RequestEventArgs()
                    {
                        IsError = false,
                        ErrorMessage = string.Empty,
                        Exception = new NotSupportedException(Constants.GRACEFUL_EXECUTION_MESSAGE),
                        RootObject = rootObject
                    });
                }
            }
            catch (Exception ex)
            {
                if(RequestError!= null)
                {
                    //Raise Sync Error (Custom Exception during parsing)
                    RequestError(this, new RequestEventArgs()
                    {
                        IsError = true,
                        ErrorMessage = Constants.REQUEST_PARSE_JSON_EXCEPTION,
                        Exception = ex
                    });
                }
            }
        }
    }
}