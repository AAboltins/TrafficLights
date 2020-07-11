namespace TrafficLights
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
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
            this.RedLight = new System.Windows.Forms.PictureBox();
            this.YellowLight = new System.Windows.Forms.PictureBox();
            this.GreenLight = new System.Windows.Forms.PictureBox();
            this.redInterval = new System.Windows.Forms.TextBox();
            this.yellowInterval = new System.Windows.Forms.TextBox();
            this.greenInterval = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(53, 23);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(150, 150);
            this.RedLight.TabIndex = 0;
            this.RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(53, 191);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(150, 150);
            this.YellowLight.TabIndex = 1;
            this.YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(53, 365);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(150, 150);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.TabStop = false;
            // 
            // redInterval
            // 
            this.redInterval.Location = new System.Drawing.Point(232, 77);
            this.redInterval.Name = "redInterval";
            this.redInterval.Size = new System.Drawing.Size(62, 20);
            this.redInterval.TabIndex = 3;
            this.redInterval.Text = "1";
            // 
            // yellowInterval
            // 
            this.yellowInterval.Location = new System.Drawing.Point(232, 258);
            this.yellowInterval.Name = "yellowInterval";
            this.yellowInterval.Size = new System.Drawing.Size(62, 20);
            this.yellowInterval.TabIndex = 4;
            // 
            // greenInterval
            // 
            this.greenInterval.Location = new System.Drawing.Point(232, 428);
            this.greenInterval.Name = "greenInterval";
            this.greenInterval.Size = new System.Drawing.Size(62, 20);
            this.greenInterval.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 543);
            this.Controls.Add(this.greenInterval);
            this.Controls.Add(this.yellowInterval);
            this.Controls.Add(this.redInterval);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox YellowLight;
        private System.Windows.Forms.PictureBox GreenLight;
        private System.Windows.Forms.TextBox redInterval;
        private System.Windows.Forms.TextBox yellowInterval;
        private System.Windows.Forms.TextBox greenInterval;
    }
}

