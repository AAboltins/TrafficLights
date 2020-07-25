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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // RedLight
            // 
            this.RedLight.Location = new System.Drawing.Point(49, 86);
            this.RedLight.Name = "RedLight";
            this.RedLight.Size = new System.Drawing.Size(150, 150);
            this.RedLight.TabIndex = 0;
            this.RedLight.TabStop = false;
            // 
            // YellowLight
            // 
            this.YellowLight.Location = new System.Drawing.Point(49, 254);
            this.YellowLight.Name = "YellowLight";
            this.YellowLight.Size = new System.Drawing.Size(150, 150);
            this.YellowLight.TabIndex = 1;
            this.YellowLight.TabStop = false;
            // 
            // GreenLight
            // 
            this.GreenLight.Location = new System.Drawing.Point(49, 428);
            this.GreenLight.Name = "GreenLight";
            this.GreenLight.Size = new System.Drawing.Size(150, 150);
            this.GreenLight.TabIndex = 2;
            this.GreenLight.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ResetClock);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 612);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GreenLight);
            this.Controls.Add(this.YellowLight);
            this.Controls.Add(this.RedLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YellowLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GreenLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox RedLight;
        private System.Windows.Forms.PictureBox YellowLight;
        private System.Windows.Forms.PictureBox GreenLight;
        private System.Windows.Forms.Button button1;
    }
}

