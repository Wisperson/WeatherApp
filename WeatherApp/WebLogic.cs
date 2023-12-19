using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp
{
    public class WebRequestResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public WebRequestResult() { }

        public async Task Init(string City)
        {
            await GetWebRequestResult(City);
        }

        private async Task GetWebRequestResult(string City)
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
               
                try
                {
                    response = await request.GetResponseAsync();
                    using (Stream s = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(s))
                        {
                            answer = await reader.ReadToEndAsync();
                        }
                    }
                    response.Close();
                    IsSuccess = true;
                    Message = answer;
                    return;
                }
                catch
                {
                    IsSuccess = false;
                    Message = "Request timeout";
                    return;
                }
            }
            catch
            {
                IsSuccess = false;
                Message = "Net Error";
                return;
            }
        }
    }
}
