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
            this.connectDBButton = new System.Windows.Forms.Button();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 661);
            this.Controls.Add(this.connectDBButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button connectDBButton;
    }
}

