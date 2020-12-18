using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Timer = System.Timers.Timer;

namespace AutoClicker
{
    /// <summary>
    /// Interaction logic for Delay.xaml
    /// </summary>
    public partial class Delay : UserControl, IAction
    {
        public Delay()
        {
            InitializeComponent();
        }

        public void Action()
        {
            Thread.Sleep(Convert.ToInt32(NumberBox.Value));
        }
    }
}
