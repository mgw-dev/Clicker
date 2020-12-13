using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clicker
{
    public partial class MouseClick : UserControl, IClickerAction
    {
        public MouseClick()
        {
            InitializeComponent();
        }

        private void MouseClick_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = Enum.GetValues(typeof(Mouse.Button));
        }


        public void Action()
        {
            Mouse.Click((Mouse.Button)comboBox1.SelectedIndex);
        }
    }
}
