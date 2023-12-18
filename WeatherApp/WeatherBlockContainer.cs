using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherApp
{
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
        private Button CloseButton;

        private TextBox CityTextBox;
        private Button InitializeWeatherPanelButton;

        private Panel WeatherScrollPanel;

        public WeatherBlock(ref int y, Panel WeatherScrollPanel)
        {
            //Initializing elements in WeatherBlock
            WeatherPanel = new GroupBox();
            ImagePanel = new Panel();
            WindPanel = new GroupBox();
            WindDegLabel = new Label();
            WindSpeedLabel = new Label();
            WeatherPressureLabel = new Label();
            WeatherHumidityLabel = new Label();
            WeatherTempLabel = new Label();
            WeatherDescriptionLabel = new Label();
            WeatherNameLabel = new Label();
            CloseButton = new Button();
            this.WeatherScrollPanel = WeatherScrollPanel;

            CityTextBox = new TextBox();
            InitializeWeatherPanelButton = new Button();

            //Suspending layouts to increase app perfomance
            WeatherScrollPanel.SuspendLayout();
            WeatherPanel.SuspendLayout();
            WindPanel.SuspendLayout();

            //WeatherPanel config
            WeatherPanel.Controls.Add(WindPanel);
            WeatherPanel.Controls.Add(WeatherPressureLabel);
            WeatherPanel.Controls.Add(WeatherHumidityLabel);
            WeatherPanel.Controls.Add(WeatherTempLabel);
            WeatherPanel.Controls.Add(WeatherDescriptionLabel);
            WeatherPanel.Controls.Add(WeatherNameLabel);
            WeatherPanel.Controls.Add(ImagePanel);
            WeatherPanel.Controls.Add(CloseButton);
            WeatherPanel.Controls.Add(CityTextBox);
            WeatherPanel.Controls.Add(InitializeWeatherPanelButton);
            WeatherPanel.Location = new Point(0, y);
            WeatherPanel.Margin = new Padding(0);
            WeatherPanel.Name = "WeatherPanel" + ID++;
            WeatherPanel.Size = new Size(380, 180);
            WeatherPanel.TabIndex = 1;
            WeatherPanel.TabStop = false;
            WeatherPanel.Text = "Погода " + City;

            //CityTextBox config
            CityTextBox.Location = new Point(210, 19);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 20);
            CityTextBox.TabIndex = 8;
            CityTextBox.Text = "City name here";

            //InitializeWeatherPanelButton config
            InitializeWeatherPanelButton.Location = new Point(235, 44);
            InitializeWeatherPanelButton.Name = "InitializeWeatherPanelButton";
            InitializeWeatherPanelButton.Size = new Size(75, 23);
            InitializeWeatherPanelButton.TabIndex = 9;
            InitializeWeatherPanelButton.Text = "Start";
            InitializeWeatherPanelButton.UseVisualStyleBackColor = true;
            InitializeWeatherPanelButton.Click += new EventHandler(InitializeWeatherPanel);

            //CloseButton config
            CloseButton.Location = new Point(349, 14);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Enabled = false;
            CloseButton.Visible = false;

            //WindPanel config
            WindPanel.Controls.Add(WindDegLabel);
            WindPanel.Controls.Add(WindSpeedLabel);
            WindPanel.Location = new Point(7, 116);
            WindPanel.Name = "WindPanel";
            WindPanel.Size = new Size(200, 58);
            WindPanel.TabIndex = 6;
            WindPanel.TabStop = false;
            WindPanel.Text = "Ветер";
            WindPanel.Enabled = false;
            WindPanel.Visible = false;

            //WindDegLabel config
            WindDegLabel.AutoSize = true;
            WindDegLabel.Location = new Point(7, 37);
            WindDegLabel.Name = "WindDegLabel";
            WindDegLabel.Size = new Size(35, 13);
            WindDegLabel.TabIndex = 1;
            WindDegLabel.Text = "label7";
            WindDegLabel.Enabled = false;
            WindDegLabel.Visible = false;

            //WindSpeedLabel config
            WindSpeedLabel.AutoSize = true;
            WindSpeedLabel.Location = new Point(7, 20);
            WindSpeedLabel.Name = "WindSpeedLabel";
            WindSpeedLabel.Size = new Size(35, 13);
            WindSpeedLabel.TabIndex = 0;
            WindSpeedLabel.Text = "label6";
            WindSpeedLabel.Enabled = false;
            WindSpeedLabel.Visible = false;

            //WeatherPressureLabel config
            WeatherPressureLabel.AutoSize = true;
            WeatherPressureLabel.Location = new Point(103, 88);
            WeatherPressureLabel.Name = "WeatherPressureLabel";
            WeatherPressureLabel.Size = new Size(35, 13);
            WeatherPressureLabel.TabIndex = 5;
            WeatherPressureLabel.Text = "label5";
            WeatherPressureLabel.Enabled = false;
            WeatherPressureLabel.Visible = false;

            //WeatherHumidityLabel config
            WeatherHumidityLabel.AutoSize = true;
            WeatherHumidityLabel.Location = new Point(103, 71);
            WeatherHumidityLabel.Name = "WeatherHumidityLabel";
            WeatherHumidityLabel.Size = new Size(35, 13);
            WeatherHumidityLabel.TabIndex = 4;
            WeatherHumidityLabel.Text = "label4";
            WeatherHumidityLabel.Enabled = false;
            WeatherHumidityLabel.Visible = false;

            //WeatherTempLabel config
            WeatherTempLabel.AutoSize = true;
            WeatherTempLabel.Location = new Point(103, 54);
            WeatherTempLabel.Name = "WeatherTempLabel";
            WeatherTempLabel.Size = new Size(35, 13);
            WeatherTempLabel.TabIndex = 3;
            WeatherTempLabel.Text = "label3";
            WeatherTempLabel.Enabled = false;
            WeatherTempLabel.Visible = false;

            //WeatherDescriptionLabel config
            WeatherDescriptionLabel.AutoSize = true;
            WeatherDescriptionLabel.Location = new Point(103, 37);
            WeatherDescriptionLabel.Name = "WeatherDescriptionLabel";
            WeatherDescriptionLabel.Size = new Size(35, 13);
            WeatherDescriptionLabel.TabIndex = 2;
            WeatherDescriptionLabel.Text = "label2";
            WeatherDescriptionLabel.Enabled = false;
            WeatherDescriptionLabel.Visible = false;

            //WeatherNameLabel config
            WeatherNameLabel.AutoSize = true;
            WeatherNameLabel.Location = new Point(103, 20);
            WeatherNameLabel.Name = "WeatherNameLabel";
            WeatherNameLabel.Size = new Size(35, 13);
            WeatherNameLabel.TabIndex = 1;
            WeatherNameLabel.Text = "label1";
            WeatherNameLabel.Enabled = false;
            WeatherNameLabel.Visible = false;

            //ImagePanel config
            ImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
            ImagePanel.Location = new Point(6, 19);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(90, 90);
            ImagePanel.TabIndex = 0;
            ImagePanel.Enabled = false;
            ImagePanel.Visible = false;

            WeatherScrollPanel.Controls.Add(WeatherPanel);

            //Resuming layouts
            WeatherPanel.ResumeLayout(false);
            WeatherPanel.PerformLayout();
            WindPanel.ResumeLayout(false);
            WindPanel.PerformLayout();
            WeatherScrollPanel.ResumeLayout(false);

            y += 200;
        }

        private void InitializeWeatherPanel(object sender, EventArgs e)
        {
            WeatherPanel.SuspendLayout();
            WindPanel.SuspendLayout();

            string City = CityTextBox.Text;

            InitializeWeatherPanelButton.Enabled = false;
            InitializeWeatherPanelButton.Visible = false;
            CityTextBox.Enabled = false;
            CityTextBox.Visible = false;

            CloseButton.Enabled = true;
            CloseButton.Visible = true;
            WindPanel.Enabled = true;
            WindPanel.Visible = true;
            WindDegLabel.Enabled = true;
            WindDegLabel.Visible = true;
            WindSpeedLabel.Enabled = true;
            WindSpeedLabel.Visible = true;
            WeatherPressureLabel.Enabled = true;
            WeatherPressureLabel.Visible = true;
            WeatherHumidityLabel.Enabled = true;
            WeatherHumidityLabel.Visible = true;
            WeatherTempLabel.Enabled = true;
            WeatherTempLabel.Visible = true;
            WeatherDescriptionLabel.Enabled = true;
            WeatherDescriptionLabel.Visible = true;
            WeatherNameLabel.Enabled = true;
            WeatherNameLabel.Visible = true;
            ImagePanel.Enabled = true;
            ImagePanel.Visible = true;

            WeatherPanel.ResumeLayout(false);
            WeatherPanel.PerformLayout();
            WindPanel.ResumeLayout(false);
            WindPanel.PerformLayout();
        }
    }
}
