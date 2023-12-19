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
            DynamicWeatherContainer DWC = new DynamicWeatherContainer(WeatherScrollPanel);
            DWC.Add(new WeatherBlock(DWC.AvailableY, WeatherScrollPanel));           
        }

        public class DynamicWeatherContainer
        {
            public Panel WeatherScrollPanel { get; set; }
            public int AvailableY { get; set; }
            public List<WeatherBlock> Blocks { get; set; }
            public DynamicWeatherContainer(Panel WeatherScrollPanel)
            {
                this.WeatherScrollPanel = WeatherScrollPanel;
                AvailableY = 0;
                Blocks = new List<WeatherBlock>();
            }
            public void Add(WeatherBlock block)
            {
                Blocks.Add(block);
                AvailableY += 200;
            }
        }
    }
}
