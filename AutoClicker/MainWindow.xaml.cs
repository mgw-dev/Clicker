using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace AutoClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Timer timer = new Timer();
        List<Action> actions = new List<Action>();

        public MainWindow()
        {
            InitializeComponent();
            timer.Elapsed += Timer_Elapsed;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            foreach (Action action in actions)
            {
                Dispatcher.Invoke(action);
            }
        }

        private void AddClick(object sender, RoutedEventArgs e)
        {
            ActionsWrapPanel.Children.Add(new Click());
        }

        private void AddDelay(object sender, RoutedEventArgs e)
        {
            ActionsWrapPanel.Children.Add(new Delay());
        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            if (ActionsWrapPanel.Children.Count > 0)
            {
                ActionsWrapPanel.Children.RemoveAt(ActionsWrapPanel.Children.Count - 1);
            }
        }

        private void Start(object sender, RoutedEventArgs e)
        {

            if (timer.Enabled)
            {
                timer.Stop();
                StartButton.Content = "Start";
                MiliBox.IsEnabled = true;
                ActionScrollViewer.IsEnabled = true;
                AddClickButton.IsEnabled = true;
                AddDelayButton.IsEnabled = true;
                RemoveButton.IsEnabled = true;
                ClearButton.IsEnabled = true;
            }
            else
            {
                actions = GetActions();
                timer.Interval = MiliBox.Value;
                timer.Start();
                StartButton.Content = "Stop";
                MiliBox.IsEnabled = false;
                ActionScrollViewer.IsEnabled = false;
                AddClickButton.IsEnabled = false;
                AddDelayButton.IsEnabled = false;
                RemoveButton.IsEnabled = false;
                ClearButton.IsEnabled = false;
            }
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            ActionsWrapPanel.Children.Clear();
        }

        private List<Action> GetActions()
        {
            return (from IAction obj in ActionsWrapPanel.Children select (Action) obj.Action).ToList();
        }
    }
}
