using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            string API = "";
            string City = "Almaty";
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={API}";
            //WebRequest request = WebRequest.Create(URL);

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string response = await client.GetStringAsync(URL);

                    Console.WriteLine(response);
                }
                catch(HttpRequestException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}
