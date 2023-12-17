using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WebLogic
    {
        public async static Task<WebRequestResult> GetWebRequestResult(string City)
        {
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={Secrets.API}&units=metric&lang=ru";
            WebRequest request;
            WebResponse response;
            string answer = string.Empty;
            try
            {
                request = WebRequest.Create(URL);
                request.Method = "POST";
                request.ContentType = "application/x-www.urlencoded";

                Task<WebResponse> ResponseTask = request.GetResponseAsync();
                Task TimeoutTask = Task.Delay(TimeSpan.FromSeconds(5));
                Task ComplitedTask = Task.WhenAny(ResponseTask, TimeoutTask);

                if (ComplitedTask == ResponseTask)
                {
                    response = await ResponseTask;
                    using (Stream s = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(s))
                        {
                            answer = await reader.ReadToEndAsync();
                        }
                    }
                    response.Close();
                    return new WebRequestResult(true, answer);
                }
                else
                {
                    return new WebRequestResult(false, "Couldn't connect to OpenWeatherMap.org");
                }
            }
            catch
            {
                return new WebRequestResult(false, "Net Error");
            }


        }

        public class WebRequestResult
        {
            public bool IsSuccess { get; set; }
            public string Message { get; set; }
            public WebRequestResult(bool IsSuccess, string Message)
            {
                this.IsSuccess = IsSuccess;
                this.Message = Message;
            }
        }
    }
}
