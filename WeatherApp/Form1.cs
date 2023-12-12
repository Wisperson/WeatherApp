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
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={Secrets.API}";
            WebRequest request = WebRequest.Create(URL);

            request.Method = "POST";
            request.ContentType = "application/x-www.urlencoded";
            WebResponse response = await request.GetResponseAsync();

            string answer = string.Empty;

            using(Stream s = response.GetResponseStream())
            {
                using(StreamReader reader = new StreamReader(s))
                {
                    answer = await reader.ReadToEndAsync();
                }
            }
            response.Close();

            richTextBox1.Text = answer;
        }
    }
}
