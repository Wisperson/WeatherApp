using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WeatherApp.OpenWeather
{
    public class Weather
    {
        public int ID;
        public string Main;
        public string Description;
        private string _Icon;
        public Bitmap Icon
        {
            get
            {
                return new Bitmap(Image.FromFile($"icons/{_Icon}.png"));
            }
        }
    }
}
