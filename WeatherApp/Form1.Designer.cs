namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ResponseWriter = new System.Windows.Forms.RichTextBox();
            this.WeatherPanel = new System.Windows.Forms.GroupBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.WindPanel = new System.Windows.Forms.GroupBox();
            this.WindDegLabel = new System.Windows.Forms.Label();
            this.WindSpeedLabel = new System.Windows.Forms.Label();
            this.WeatherPressureLabel = new System.Windows.Forms.Label();
            this.WeatherHumidityLabel = new System.Windows.Forms.Label();
            this.WeatherTempLabel = new System.Windows.Forms.Label();
            this.WeatherDescriptionLabel = new System.Windows.Forms.Label();
            this.WeatherNameLabel = new System.Windows.Forms.Label();
            this.ImagePanel = new System.Windows.Forms.Panel();
            this.WeatherScrollPanel = new System.Windows.Forms.Panel();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.InitializeWeatherPanelButton = new System.Windows.Forms.Button();
            this.WeatherPanel.SuspendLayout();
            this.WindPanel.SuspendLayout();
            this.WeatherScrollPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResponseWriter
            // 
            this.ResponseWriter.Location = new System.Drawing.Point(418, 19);
            this.ResponseWriter.Name = "ResponseWriter";
            this.ResponseWriter.ReadOnly = true;
            this.ResponseWriter.Size = new System.Drawing.Size(354, 430);
            this.ResponseWriter.TabIndex = 0;
            this.ResponseWriter.Text = "";
            // 
            // WeatherPanel
            // 
            this.WeatherPanel.Controls.Add(this.InitializeWeatherPanelButton);
            this.WeatherPanel.Controls.Add(this.CityTextBox);
            this.WeatherPanel.Controls.Add(this.CloseButton);
            this.WeatherPanel.Controls.Add(this.WindPanel);
            this.WeatherPanel.Controls.Add(this.WeatherPressureLabel);
            this.WeatherPanel.Controls.Add(this.WeatherHumidityLabel);
            this.WeatherPanel.Controls.Add(this.WeatherTempLabel);
            this.WeatherPanel.Controls.Add(this.WeatherDescriptionLabel);
            this.WeatherPanel.Controls.Add(this.WeatherNameLabel);
            this.WeatherPanel.Controls.Add(this.ImagePanel);
            this.WeatherPanel.Location = new System.Drawing.Point(0, 0);
            this.WeatherPanel.Margin = new System.Windows.Forms.Padding(0);
            this.WeatherPanel.Name = "WeatherPanel";
            this.WeatherPanel.Size = new System.Drawing.Size(380, 180);
            this.WeatherPanel.TabIndex = 1;
            this.WeatherPanel.TabStop = false;
            this.WeatherPanel.Text = "Погода";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(349, 14);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(25, 25);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // WindPanel
            // 
            this.WindPanel.Controls.Add(this.WindDegLabel);
            this.WindPanel.Controls.Add(this.WindSpeedLabel);
            this.WindPanel.Location = new System.Drawing.Point(7, 116);
            this.WindPanel.Name = "WindPanel";
            this.WindPanel.Size = new System.Drawing.Size(200, 58);
            this.WindPanel.TabIndex = 6;
            this.WindPanel.TabStop = false;
            this.WindPanel.Text = "Ветер";
            // 
            // WindDegLabel
            // 
            this.WindDegLabel.AutoSize = true;
            this.WindDegLabel.Location = new System.Drawing.Point(7, 37);
            this.WindDegLabel.Name = "WindDegLabel";
            this.WindDegLabel.Size = new System.Drawing.Size(35, 13);
            this.WindDegLabel.TabIndex = 1;
            this.WindDegLabel.Text = "label7";
            // 
            // WindSpeedLabel
            // 
            this.WindSpeedLabel.AutoSize = true;
            this.WindSpeedLabel.Location = new System.Drawing.Point(7, 20);
            this.WindSpeedLabel.Name = "WindSpeedLabel";
            this.WindSpeedLabel.Size = new System.Drawing.Size(35, 13);
            this.WindSpeedLabel.TabIndex = 0;
            this.WindSpeedLabel.Text = "label6";
            // 
            // WeatherPressureLabel
            // 
            this.WeatherPressureLabel.AutoSize = true;
            this.WeatherPressureLabel.Location = new System.Drawing.Point(103, 88);
            this.WeatherPressureLabel.Name = "WeatherPressureLabel";
            this.WeatherPressureLabel.Size = new System.Drawing.Size(35, 13);
            this.WeatherPressureLabel.TabIndex = 5;
            this.WeatherPressureLabel.Text = "label5";
            // 
            // WeatherHumidityLabel
            // 
            this.WeatherHumidityLabel.AutoSize = true;
            this.WeatherHumidityLabel.Location = new System.Drawing.Point(103, 71);
            this.WeatherHumidityLabel.Name = "WeatherHumidityLabel";
            this.WeatherHumidityLabel.Size = new System.Drawing.Size(35, 13);
            this.WeatherHumidityLabel.TabIndex = 4;
            this.WeatherHumidityLabel.Text = "label4";
            // 
            // WeatherTempLabel
            // 
            this.WeatherTempLabel.AutoSize = true;
            this.WeatherTempLabel.Location = new System.Drawing.Point(103, 54);
            this.WeatherTempLabel.Name = "WeatherTempLabel";
            this.WeatherTempLabel.Size = new System.Drawing.Size(35, 13);
            this.WeatherTempLabel.TabIndex = 3;
            this.WeatherTempLabel.Text = "label3";
            // 
            // WeatherDescriptionLabel
            // 
            this.WeatherDescriptionLabel.AutoSize = true;
            this.WeatherDescriptionLabel.Location = new System.Drawing.Point(103, 37);
            this.WeatherDescriptionLabel.Name = "WeatherDescriptionLabel";
            this.WeatherDescriptionLabel.Size = new System.Drawing.Size(35, 13);
            this.WeatherDescriptionLabel.TabIndex = 2;
            this.WeatherDescriptionLabel.Text = "label2";
            // 
            // WeatherNameLabel
            // 
            this.WeatherNameLabel.AutoSize = true;
            this.WeatherNameLabel.Location = new System.Drawing.Point(103, 20);
            this.WeatherNameLabel.Name = "WeatherNameLabel";
            this.WeatherNameLabel.Size = new System.Drawing.Size(35, 13);
            this.WeatherNameLabel.TabIndex = 1;
            this.WeatherNameLabel.Text = "label1";
            // 
            // ImagePanel
            // 
            this.ImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ImagePanel.Location = new System.Drawing.Point(6, 19);
            this.ImagePanel.Name = "ImagePanel";
            this.ImagePanel.Size = new System.Drawing.Size(90, 90);
            this.ImagePanel.TabIndex = 0;
            // 
            // WeatherScrollPanel
            // 
            this.WeatherScrollPanel.AutoScroll = true;
            this.WeatherScrollPanel.Controls.Add(this.WeatherPanel);
            this.WeatherScrollPanel.Location = new System.Drawing.Point(12, 16);
            this.WeatherScrollPanel.Name = "WeatherScrollPanel";
            this.WeatherScrollPanel.Size = new System.Drawing.Size(400, 433);
            this.WeatherScrollPanel.TabIndex = 2;
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(210, 19);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(100, 20);
            this.CityTextBox.TabIndex = 8;
            this.CityTextBox.Text = "City name here";
            // 
            // InitializeWeatherPanelButton
            // 
            this.InitializeWeatherPanelButton.Location = new System.Drawing.Point(235, 44);
            this.InitializeWeatherPanelButton.Name = "InitializeWeatherPanelButton";
            this.InitializeWeatherPanelButton.Size = new System.Drawing.Size(75, 23);
            this.InitializeWeatherPanelButton.TabIndex = 9;
            this.InitializeWeatherPanelButton.Text = "Start";
            this.InitializeWeatherPanelButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.WeatherScrollPanel);
            this.Controls.Add(this.ResponseWriter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.WeatherPanel.ResumeLayout(false);
            this.WeatherPanel.PerformLayout();
            this.WindPanel.ResumeLayout(false);
            this.WindPanel.PerformLayout();
            this.WeatherScrollPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResponseWriter;
        private System.Windows.Forms.GroupBox WeatherPanel;
        private System.Windows.Forms.Panel ImagePanel;
        private System.Windows.Forms.GroupBox WindPanel;
        private System.Windows.Forms.Label WindDegLabel;
        private System.Windows.Forms.Label WindSpeedLabel;
        private System.Windows.Forms.Label WeatherPressureLabel;
        private System.Windows.Forms.Label WeatherHumidityLabel;
        private System.Windows.Forms.Label WeatherTempLabel;
        private System.Windows.Forms.Label WeatherDescriptionLabel;
        private System.Windows.Forms.Label WeatherNameLabel;
        private System.Windows.Forms.Panel WeatherScrollPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button InitializeWeatherPanelButton;
        private System.Windows.Forms.TextBox CityTextBox;
    }
}

