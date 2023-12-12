using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.OpenWeather
{
    public class Wind
    {
        public double Speed;

        public double Deg;

        public string DegString;

        public void SetDegString()
        {
            Deg %= 360;
            double[] Directions = { 22.5, 67.5, 112.5, 157.5, 202.5, 247.5, 292.5, 337.5, 360.0 };
            string[] DirectionNames = { "С", "СВ", "В", "ЮВ", "Ю", "ЮЗ", "З", "СЗ", "С" };
            string[] ReverseDirectionNames = { "Ю", "ЮЗ", "З", "СЗ", "С", "СВ", "В", "ЮВ", "Ю" };

            int i = 0;

            while (Deg > Directions[i])
            {
                i++;
            }

            DegString = DirectionNames[i].ToString() + " -> " + ReverseDirectionNames[i].ToString();
        }

        public double Gust;
    }
}
