namespace CTDataGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>B
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.connectDBButton = new System.Windows.Forms.Button();
            this.ageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerPerWeekChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPerWeekChart)).BeginInit();
            this.SuspendLayout();
            // 
            // connectDBButton
            // 
            this.connectDBButton.Location = new System.Drawing.Point(499, 12);
            this.connectDBButton.Name = "connectDBButton";
            this.connectDBButton.Size = new System.Drawing.Size(75, 23);
            this.connectDBButton.TabIndex = 2;
            this.connectDBButton.Text = "Connect";
            this.connectDBButton.UseVisualStyleBackColor = true;
            this.connectDBButton.Click += new System.EventHandler(this.connectDBButton_Click);
            // 
            // ageChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ageChart.Legends.Add(legend1);
            this.ageChart.Location = new System.Drawing.Point(268, 69);
            this.ageChart.Name = "ageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ageChart.Series.Add(series1);
            this.ageChart.Size = new System.Drawing.Size(625, 231);
            this.ageChart.TabIndex = 3;
            this.ageChart.Text = "chart1";
            // 
            // timerPerWeekChart
            // 
            chartArea2.Name = "ChartArea1";
            this.timerPerWeekChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.timerPerWeekChart.Legends.Add(legend2);
            this.timerPerWeekChart.Location = new System.Drawing.Point(159, 341);
            this.timerPerWeekChart.Name = "timerPerWeekChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.timerPerWeekChart.Series.Add(series2);
            this.timerPerWeekChart.Size = new System.Drawing.Size(904, 300);
            this.timerPerWeekChart.TabIndex = 4;
            this.timerPerWeekChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 661);
            this.Controls.Add(this.timerPerWeekChart);
            this.Controls.Add(this.connectDBButton);
            this.Controls.Add(this.ageChart);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerPerWeekChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectDBButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart ageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart timerPerWeekChart;
    }
}

