using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;


namespace Clicker
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);
        //Mouse actions
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown1.Value = 2000;

            timer.Elapsed += Timer_Elapsed;

            Text = "Auto Clicker";
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            DoMouseClick();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                button1.Text = "Start";
                numericUpDown1.Enabled = true;
            }
            else
            {
                timer.Interval = Convert.ToDouble(numericUpDown1.Value);
                timer.Start();
                button1.Text = "Stop";
                numericUpDown1.Enabled = false;
            }
        }

        public void DoMouseClick()
        {
            //Call the imported function with the cursor's current position
            uint X = (uint)Cursor.Position.X;
            uint Y = (uint)Cursor.Position.Y;
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
        }

    }
}
