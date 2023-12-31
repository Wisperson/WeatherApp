﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.OpenWeather
{
    public class Main
    {
        /*private double _Temp;
        public double Temp
        {
            get
            {
                return _Temp;
            }
            set
            {
                _Temp = value - 273.15;
            }
        }*/
        public double Temp;
        /*private double _Temp_min;
        public double Temp_min
        {
            get
            {
                return _Temp_min;
            }
            set
            {
                _Temp_min = value - 273.15;
            }
        }*/
        public double Temp_min;
        /*private double _Temp_max;
        public double Temp_max
        {
            get
            {
                return _Temp_max;
            }
            set
            {
                _Temp_max = value - 273.15;
            }
        }*/
        public double Temp_max;
        /*private double _Feels_like;
        public double Feels_like
        {
            get
            {
                return _Feels_like;
            }
            set
            {
                _Feels_like = value - 273.15;
            }
        }*/
        public double Feels_like;
        private double _Pressure;
        public double Pressure
        {
            get
            {
                return _Pressure;
            }
            set
            {
                _Pressure = value * 0.75;
            }
        }
        public double Humidity;
    }
}
