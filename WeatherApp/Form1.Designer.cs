﻿namespace WeatherApp
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
            this.WeatherScrollPanel = new System.Windows.Forms.Panel();
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
            // WeatherScrollPanel
            // 
            this.WeatherScrollPanel.AutoScroll = true;
            this.WeatherScrollPanel.Location = new System.Drawing.Point(12, 16);
            this.WeatherScrollPanel.Name = "WeatherScrollPanel";
            this.WeatherScrollPanel.Size = new System.Drawing.Size(400, 433);
            this.WeatherScrollPanel.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ResponseWriter;
        private System.Windows.Forms.Panel WeatherScrollPanel;
    }
}

