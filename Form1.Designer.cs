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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connectDBButton = new System.Windows.Forms.Button();
            this.schemaTextField = new System.Windows.Forms.TextBox();
            this.usernameTextField = new System.Windows.Forms.TextBox();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.serverTextField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.ageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connectDBButton);
            this.groupBox1.Controls.Add(this.schemaTextField);
            this.groupBox1.Controls.Add(this.usernameTextField);
            this.groupBox1.Controls.Add(this.passwordTextField);
            this.groupBox1.Controls.Add(this.serverTextField);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database Connection";
            // 
            // connectDBButton
            // 
            this.connectDBButton.Location = new System.Drawing.Point(136, 143);
            this.connectDBButton.Name = "connectDBButton";
            this.connectDBButton.Size = new System.Drawing.Size(75, 23);
            this.connectDBButton.TabIndex = 2;
            this.connectDBButton.Text = "Connect";
            this.connectDBButton.UseVisualStyleBackColor = true;
            this.connectDBButton.Click += new System.EventHandler(this.connectDBButton_Click);
            // 
            // schemaTextField
            // 
            this.schemaTextField.Location = new System.Drawing.Point(78, 111);
            this.schemaTextField.Name = "schemaTextField";
            this.schemaTextField.Size = new System.Drawing.Size(235, 20);
            this.schemaTextField.TabIndex = 1;
            // 
            // usernameTextField
            // 
            this.usernameTextField.Location = new System.Drawing.Point(78, 53);
            this.usernameTextField.Name = "usernameTextField";
            this.usernameTextField.Size = new System.Drawing.Size(235, 20);
            this.usernameTextField.TabIndex = 1;
            // 
            // passwordTextField
            // 
            this.passwordTextField.Location = new System.Drawing.Point(78, 82);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.Size = new System.Drawing.Size(235, 20);
            this.passwordTextField.TabIndex = 1;
            // 
            // serverTextField
            // 
            this.serverTextField.Location = new System.Drawing.Point(78, 24);
            this.serverTextField.Name = "serverTextField";
            this.serverTextField.Size = new System.Drawing.Size(235, 20);
            this.serverTextField.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Schema";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Location = new System.Drawing.Point(171, 211);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(35, 13);
            this.countLabel.TabIndex = 2;
            this.countLabel.Text = "label5";
            // 
            // ageChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ageChart.Legends.Add(legend1);
            this.ageChart.Location = new System.Drawing.Point(371, 194);
            this.ageChart.Name = "ageChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ageChart.Series.Add(series1);
            this.ageChart.Size = new System.Drawing.Size(300, 300);
            this.ageChart.TabIndex = 3;
            this.ageChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 525);
            this.Controls.Add(this.ageChart);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox schemaTextField;
        private System.Windows.Forms.TextBox usernameTextField;
        private System.Windows.Forms.TextBox passwordTextField;
        private System.Windows.Forms.TextBox serverTextField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectDBButton;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart ageChart;
    }
}

