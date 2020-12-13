using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class Delay : UserControl, IClickerAction
    {
        public Delay()
        {
            InitializeComponent();
            numericUpDown1.Maximum = int.MaxValue;
        }

        public void Action()
        {
            Thread.Sleep(Convert.ToInt32(numericUpDown1.Value));
        }
    }
}
