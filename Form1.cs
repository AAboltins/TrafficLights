using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLights
{
    
    public partial class Form1 : Form
    {
        int tick = 0;
        int I = 1000; 
        private Timer timerSwitch;
        public Form1()
        {
            InitializeComponent();
            InitializeIntervals();
            InitializeTrafficLights();
            InitalizetimerSwitch();
        }
        private void InitalizetimerSwitch()
        {
            I = int.Parse(redInterval.Text);
            timerSwitch = new Timer();
            timerSwitch.Interval = I;
            timerSwitch.Tick += new EventHandler(TimerSwitch_Tick);
            timerSwitch.Start();
        }
        private void InitializeTrafficLights()
        { 
            RedLight.BackColor = Color.Gray;
            YellowLight.BackColor = Color.Gray;
            GreenLight.BackColor = Color.Gray;
        }
        private void InitializeIntervals()
        {
            redInterval.Text = "1000";
            yellowInterval.Text = "1000";
            greenInterval.Text = "1000";
        }
        private void TimerSwitch()
        {
            timerSwitch = new Timer();
        }
        private void TimerSwitch_Tick(object sender, EventArgs e)
        {
            int i;
            timerSwitch.Interval = I;
            tick += 1;
            if ( tick == 1)
            {

                RedLight.BackColor = Color.Red;
                if (int.TryParse(yellowInterval.Text, out i) && yellowInterval.Text != "")
                {
                    I = int.Parse(yellowInterval.Text);
                }
                else
                {
                    MessageBox.Show("This is a number only field");
                    I = 1000;
                    yellowInterval.Text = I.ToString();
                }
            }
            else if(tick == 2)
            {
                YellowLight.BackColor = Color.Yellow;
                if (int.TryParse(greenInterval.Text, out i) && greenInterval.Text != "")
                {
                    I = int.Parse(greenInterval.Text);
                }
                else
                {
                    MessageBox.Show("This is a number only field");
                    I = 1000;
                    greenInterval.Text = I.ToString();
                }
            }
            else if ( tick == 3)
            {
                GreenLight.BackColor = Color.Green;
                I = 500;
            }
            else if (tick == 4)
            {
                GreenLight.BackColor = Color.Gray;
                I = 500;
            }
            else if (tick == 5)
            {
                GreenLight.BackColor = Color.Green;
                I = 500;
            }
            else if (tick == 6)
            {
                GreenLight.BackColor = Color.Gray;
                I = 500;
            }
            else if (tick == 7)
            {
                GreenLight.BackColor = Color.Green;
                I = 500;
            }
            else if (tick == 8)
            {
                GreenLight.BackColor = Color.Gray;
                RedLight.BackColor = Color.Gray;
                YellowLight.BackColor = Color.Gray;
                if (int.TryParse(redInterval.Text, out i) && redInterval.Text != "")
                {
                    I = int.Parse(redInterval.Text);
                }
                else
                {
                    MessageBox.Show("This is a number only field");
                    I = 1000;
                    redInterval.Text = I.ToString();
                }
                tick = 0;
            }
            
        }
    }
}
