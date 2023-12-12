using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp.OpenWeather
{
    public class OpenWeather
    {
        public Coord Coord;

        public Weather Weather;

        [JsonProperty("base")]
        public string Base;

        public Main Main;

        public double Visibility;

        public Wind Wind;

        public Clouds Clouds;

        public double DT;

        public Sys Sys;

        public int ID;

        public string Name;

        public double Cod;

        public int Timezone;
    }
}
