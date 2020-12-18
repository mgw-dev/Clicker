using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoClicker
{
    /// <summary>
    /// Interaction logic for Click.xaml
    /// </summary>
    public partial class Click : UserControl, IAction
    {
        public Click()
        {
            InitializeComponent();
        }

        public void Action()
        {
            Mouse.Click((MouseButton)ComboBox.SelectedItem);
        }
    }
}
