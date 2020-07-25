using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TrafficLights
{
    
    public partial class Form1 : Form
    {
        private Timer timerSwitch = null;
        private Timer timerBlink = null;
        private int time = 3;
        private Label labelTime = null;
        private int hou = 0, min = 0, sec = 0;
        public Form1()
        {
            InitializeComponent();
            InitializeTrafficLights();
            Initalizetimers();
            InitializeLabelTime();
        }
        private void InitializeLabelTime()
        {
            labelTime = new Label();
            labelTime.Font = new Font("Arial", 18, FontStyle.Bold);
            labelTime.Top = 20;
            labelTime.Width = 150;
            labelTime.Left = 75;
            labelTime.Text = "00:00:00";
            this.Controls.Add(labelTime);
        }
        private void Initalizetimers() 
        {
            timerBlink= new Timer();
            timerSwitch = new Timer();
            timerSwitch.Interval = 1000;
            timerBlink.Interval = 110;
            timerBlink.Tick += new EventHandler(TimerBlink_Tick);
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
            timerBlink.Start();
        }
        private void BlinkGreen()
        {
            if (GreenLight.BackColor == Color.Gray && 10 <= time && time < 13)
            { GreenLight.BackColor = Color.Green;}
            else if (GreenLight.BackColor == Color.Green)
            {GreenLight.BackColor = Color.Gray;}
        }
        private void TimerBlink_Tick(object sender, EventArgs e)
        {
            BlinkGreen();
        }
        private void InitializeTrafficLights()
        { 
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }
        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            UpdateClock();
            SwitchLights();
            UpdateLabelTime();
        }
        private void UpdateClock()
        {
            sec++;
            if (sec == 60)
            {
                min++;
                sec = 0;
            } 
            if(min == 60)
            {
                hou++;
                min = 0;
            }
            if(hou == 24)
            {
                hou = 0;
                min = 0;
                sec = 0;
            }
        }
        private void UpdateLabelTime()
        {
            labelTime.Text = $"{hou.ToString("00")}:{min.ToString("00")}:{sec.ToString("00")}";
        }

        private void ResetClock(object sender, EventArgs e)
        {
            hou = 0;
            min = 0;
            sec = 0;
        }
    

        private void SwitchLights()
        {
            time++;
            switch (time)
            {
                case 4:
                    YellowLight.BackColor = Color.Gray;
                    RedLight.BackColor = Color.Red;
                    break;
                case 7:
                    YellowLight.BackColor = Color.Yellow;
                    break;
                case 10:
                    RedLight.BackColor = Color.Gray;
                    YellowLight.BackColor = Color.Gray;
                    break;
                case 13:
                    GreenLight.BackColor = Color.Gray;
                    YellowLight.BackColor = Color.Yellow;
                    time = 0;
                    break;
            }
        }
    }
}
