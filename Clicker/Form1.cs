using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Timers.Timer;


namespace Clicker
{
    public partial class Form1 : Form
    {
        

        Timer timer = new Timer();
        List<Action> actions = new List<Action>();

        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown1.Value = 10000;
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (Action action in actions)
            {
                this.Invoke(new MethodInvoker(action));
            }
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
                flpActions.Enabled = true;
                btnAddClick.Enabled = true;
                btnAddDelay.Enabled = true;
                btnClr.Enabled = true;
                btnRem.Enabled = true;
            }
            else
            {
                actions = getActions();
                timer.Interval = Convert.ToDouble(numericUpDown1.Value);
                timer.Start();
                button1.Text = "Stop";
                numericUpDown1.Enabled = false;
                flpActions.Enabled = false;
                btnAddClick.Enabled = false;
                btnAddDelay.Enabled = false;
                btnClr.Enabled = false;
                btnRem.Enabled = false;
            }
        }

        private void btnAddClick_Click(object sender, EventArgs e)
        {
            flpActions.Controls.Add(new MouseClick());
        }

        private void btnAddDelay_Click(object sender, EventArgs e)
        {
            flpActions.Controls.Add(new Delay());
        }

        private List<Action> getActions()
        {
            List<Action> outList = new List<Action>();
            foreach (IClickerAction obj in flpActions.Controls)
            {
                outList.Add(obj.Action);
            }

            return outList;
        }

        private void btnRem_Click(object sender, EventArgs e)
        {
            if (flpActions.Controls.Count > 0)
            {
                flpActions.Controls.RemoveAt(flpActions.Controls.Count - 1);
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            flpActions.Controls.Clear();
        }
    }
}
