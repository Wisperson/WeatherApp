using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Security.Policy;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string City = "Almaty";
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={Secrets.API}&units=metric&lang=ru";
            WebRequest request;
            WebResponse response;
            string answer = string.Empty;

            int AvailableY = 200;
            List<WeatherBlock> Blocks = new List<WeatherBlock>();
            Blocks.Add(new WeatherBlock(ref AvailableY, WeatherScrollPanel));
            Blocks.Add(new WeatherBlock(ref AvailableY, WeatherScrollPanel));            

            try
            {
                request = WebRequest.Create(URL);

                request.Method = "POST";
                request.ContentType = "application/x-www.urlencoded";
                response = await request.GetResponseAsync();

                using (Stream s = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(s))
                    {
                        answer = await reader.ReadToEndAsync();
                    }
                }
                response.Close();

                ResponseWriter.Text = answer;

                OpenWeather.OpenWeather OW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);

                ImagePanel.BackgroundImage = OW.Weather[0].Icon;

                WeatherNameLabel.Text = OW.Weather[0].Main;
                WeatherDescriptionLabel.Text = OW.Weather[0].Description;
                WeatherTempLabel.Text = "Средняя температура(°C): " + OW.Main.Temp.ToString("0.##");
                WeatherHumidityLabel.Text = "Влажность: " + OW.Main.Humidity.ToString() + "%";
                WeatherPressureLabel.Text = "Давление(мм р.с.): " + ((int)OW.Main.Pressure).ToString();

                WindSpeedLabel.Text = "Скорость(м/с): " + OW.Wind.Speed.ToString();
                OW.Wind.SetDegString();
                WindDegLabel.Text = "Направление: " + OW.Wind.DegString;
            }
            catch (System.Net.WebException ex)
            {
                ResponseWriter.Text = "Проблема с интернетом";
            }
            catch
            {
                ResponseWriter.Text = "Возникла проблема";
                ResponseWriter.Text = answer;
            }
        }
    }
}
