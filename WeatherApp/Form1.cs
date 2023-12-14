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
            try
            {
                request = WebRequest.Create(URL);

                request.Method = "POST";
                request.ContentType = "application/x-www.urlencoded";
                response = await request.GetResponseAsync();

                answer = string.Empty;

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
           

            /*Button helloButton = new Button();
            helloButton.BackColor = Color.LightGray;
            helloButton.ForeColor = Color.DarkGray;
            helloButton.Location = new Point(200, 200);
            helloButton.Text = "Привет";

            groupBox1.Controls.Add(helloButton);*/
        }

        /*private async void AddWeatherBlock()
        {
            string City = "Almaty";
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={Secrets.API}&units=metric&lang=ru";
            WebRequest request = WebRequest.Create(URL);

            request.Method = "POST";
            request.ContentType = "application/x-www.urlencoded";
            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using (Stream s = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();
        }*/

        public class WeatherBlock
        {
            static int ID = 1;
            private string City;
            private GroupBox WeatherPanel;
            private Panel ImagePanel;
            private GroupBox WindPanel;
            private Label WindDegLabel;
            private Label WindSpeedLabel;
            private Label WeatherPressureLabel;
            private Label WeatherHumidityLabel;
            private Label WeatherTempLabel;
            private Label WeatherDescriptionLabel;
            private Label WeatherNameLabel;

            private TextBox CityTextBox;
            private Button InitializeWeatherPanelButton;

            WeatherBlock(int y, Panel WeatherScrollPanel)
            {
                WeatherPanel.Controls.Add(WindPanel);
                WeatherPanel.Controls.Add(WeatherPressureLabel);
                WeatherPanel.Controls.Add(WeatherHumidityLabel);
                WeatherPanel.Controls.Add(WeatherTempLabel);
                WeatherPanel.Controls.Add(WeatherDescriptionLabel);
                WeatherPanel.Controls.Add(WeatherNameLabel);
                WeatherPanel.Controls.Add(ImagePanel);

                WeatherPanel.Location = new Point(0, y);
                WeatherPanel.Margin = new Padding(0);
                WeatherPanel.Name = "WeatherPanel" + ID++;
                WeatherPanel.Size = new Size(400, 180);
                WeatherPanel.TabIndex = 1;
                WeatherPanel.TabStop = false;
                WeatherPanel.Text = "Погода " + City;
            }
        }
    }
}
