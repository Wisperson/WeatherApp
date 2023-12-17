﻿using System;
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

        private TextBox CityTextBox;
        private Button InitializeWeatherPanelButton;

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
            WeatherPanel.Location = new Point(0, y);
            WeatherPanel.Margin = new Padding(0);
            WeatherPanel.Name = "WeatherPanel" + ID++;
            WeatherPanel.Size = new Size(400, 180);
            WeatherPanel.TabIndex = 1;
            WeatherPanel.TabStop = false;
            WeatherPanel.Text = "Погода " + City;

            //WindPanel config
            WindPanel.Controls.Add(WindDegLabel);
            WindPanel.Controls.Add(WindSpeedLabel);
            WindPanel.Location = new Point(7, 116);
            WindPanel.Name = "WindPanel";
            WindPanel.Size = new Size(200, 58);
            WindPanel.TabIndex = 6;
            WindPanel.TabStop = false;
            WindPanel.Text = "Ветер";

            //WindDegLabel config
            WindDegLabel.AutoSize = true;
            WindDegLabel.Location = new Point(7, 37);
            WindDegLabel.Name = "WindDegLabel";
            WindDegLabel.Size = new Size(35, 13);
            WindDegLabel.TabIndex = 1;
            WindDegLabel.Text = "label7";

            //WindSpeedLabel config
            WindSpeedLabel.AutoSize = true;
            WindSpeedLabel.Location = new Point(7, 20);
            WindSpeedLabel.Name = "WindSpeedLabel";
            WindSpeedLabel.Size = new Size(35, 13);
            WindSpeedLabel.TabIndex = 0;
            WindSpeedLabel.Text = "label6";

            //WeatherPressureLabel config
            WeatherPressureLabel.AutoSize = true;
            WeatherPressureLabel.Location = new Point(103, 88);
            WeatherPressureLabel.Name = "WeatherPressureLabel";
            WeatherPressureLabel.Size = new Size(35, 13);
            WeatherPressureLabel.TabIndex = 5;
            WeatherPressureLabel.Text = "label5";

            //WetherHumidityLabel config
            WeatherHumidityLabel.AutoSize = true;
            WeatherHumidityLabel.Location = new Point(103, 71);
            WeatherHumidityLabel.Name = "WeatherHumidityLabel";
            WeatherHumidityLabel.Size = new Size(35, 13);
            WeatherHumidityLabel.TabIndex = 4;
            WeatherHumidityLabel.Text = "label4";

            //WeatherTempLabel config
            WeatherTempLabel.AutoSize = true;
            WeatherTempLabel.Location = new Point(103, 54);
            WeatherTempLabel.Name = "WeatherTempLabel";
            WeatherTempLabel.Size = new Size(35, 13);
            WeatherTempLabel.TabIndex = 3;
            WeatherTempLabel.Text = "label3";

            //WeatherDescriptionLabel config
            WeatherDescriptionLabel.AutoSize = true;
            WeatherDescriptionLabel.Location = new Point(103, 37);
            WeatherDescriptionLabel.Name = "WeatherDescriptionLabel";
            WeatherDescriptionLabel.Size = new Size(35, 13);
            WeatherDescriptionLabel.TabIndex = 2;
            WeatherDescriptionLabel.Text = "label2";

            //WeatherNameLabel config
            WeatherNameLabel.AutoSize = true;
            WeatherNameLabel.Location = new Point(103, 20);
            WeatherNameLabel.Name = "WeatherNameLabel";
            WeatherNameLabel.Size = new Size(35, 13);
            WeatherNameLabel.TabIndex = 1;
            WeatherNameLabel.Text = "label1";

            // ImagePanel config
            ImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
            ImagePanel.Location = new Point(6, 19);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(90, 90);
            ImagePanel.TabIndex = 0;

            WeatherScrollPanel.Controls.Add(WeatherPanel);

            //Resuming layouts
            WeatherPanel.ResumeLayout(false);
            WeatherPanel.PerformLayout();
            WindPanel.ResumeLayout(false);
            WindPanel.PerformLayout();
            WeatherScrollPanel.ResumeLayout(false);

            y += 200;
        }

        public void InitializeWeatherPanel(ref int y, Panel WeatherScrollPanel)
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
            WeatherPanel.Location = new Point(0, y);
            WeatherPanel.Margin = new Padding(0);
            WeatherPanel.Name = "WeatherPanel" + ID++;
            WeatherPanel.Size = new Size(400, 180);
            WeatherPanel.TabIndex = 1;
            WeatherPanel.TabStop = false;
            WeatherPanel.Text = "Погода " + City;

            //WindPanel config
            WindPanel.Controls.Add(WindDegLabel);
            WindPanel.Controls.Add(WindSpeedLabel);
            WindPanel.Location = new Point(7, 116);
            WindPanel.Name = "WindPanel";
            WindPanel.Size = new Size(200, 58);
            WindPanel.TabIndex = 6;
            WindPanel.TabStop = false;
            WindPanel.Text = "Ветер";

            //WindDegLabel config
            WindDegLabel.AutoSize = true;
            WindDegLabel.Location = new Point(7, 37);
            WindDegLabel.Name = "WindDegLabel";
            WindDegLabel.Size = new Size(35, 13);
            WindDegLabel.TabIndex = 1;
            WindDegLabel.Text = "label7";

            //WindSpeedLabel config
            WindSpeedLabel.AutoSize = true;
            WindSpeedLabel.Location = new Point(7, 20);
            WindSpeedLabel.Name = "WindSpeedLabel";
            WindSpeedLabel.Size = new Size(35, 13);
            WindSpeedLabel.TabIndex = 0;
            WindSpeedLabel.Text = "label6";

            //WeatherPressureLabel config
            WeatherPressureLabel.AutoSize = true;
            WeatherPressureLabel.Location = new Point(103, 88);
            WeatherPressureLabel.Name = "WeatherPressureLabel";
            WeatherPressureLabel.Size = new Size(35, 13);
            WeatherPressureLabel.TabIndex = 5;
            WeatherPressureLabel.Text = "label5";

            //WetherHumidityLabel config
            WeatherHumidityLabel.AutoSize = true;
            WeatherHumidityLabel.Location = new Point(103, 71);
            WeatherHumidityLabel.Name = "WeatherHumidityLabel";
            WeatherHumidityLabel.Size = new Size(35, 13);
            WeatherHumidityLabel.TabIndex = 4;
            WeatherHumidityLabel.Text = "label4";

            //WeatherTempLabel config
            WeatherTempLabel.AutoSize = true;
            WeatherTempLabel.Location = new Point(103, 54);
            WeatherTempLabel.Name = "WeatherTempLabel";
            WeatherTempLabel.Size = new Size(35, 13);
            WeatherTempLabel.TabIndex = 3;
            WeatherTempLabel.Text = "label3";

            //WeatherDescriptionLabel config
            WeatherDescriptionLabel.AutoSize = true;
            WeatherDescriptionLabel.Location = new Point(103, 37);
            WeatherDescriptionLabel.Name = "WeatherDescriptionLabel";
            WeatherDescriptionLabel.Size = new Size(35, 13);
            WeatherDescriptionLabel.TabIndex = 2;
            WeatherDescriptionLabel.Text = "label2";

            //WeatherNameLabel config
            WeatherNameLabel.AutoSize = true;
            WeatherNameLabel.Location = new Point(103, 20);
            WeatherNameLabel.Name = "WeatherNameLabel";
            WeatherNameLabel.Size = new Size(35, 13);
            WeatherNameLabel.TabIndex = 1;
            WeatherNameLabel.Text = "label1";

            // ImagePanel config
            ImagePanel.BackgroundImageLayout = ImageLayout.Zoom;
            ImagePanel.Location = new Point(6, 19);
            ImagePanel.Name = "ImagePanel";
            ImagePanel.Size = new Size(90, 90);
            ImagePanel.TabIndex = 0;

            WeatherScrollPanel.Controls.Add(WeatherPanel);

            //Resuming layouts
            WeatherPanel.ResumeLayout(false);
            WeatherPanel.PerformLayout();
            WindPanel.ResumeLayout(false);
            WindPanel.PerformLayout();
            WeatherScrollPanel.ResumeLayout(false);

            y += 200;
        }
    }
}
