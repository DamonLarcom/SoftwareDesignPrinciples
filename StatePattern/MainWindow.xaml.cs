using StatePattern.Interfaces;
using StatePattern.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace StatePattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IState currentState;
        private DispatcherTimer timer;

        public MainWindow()
        {
            InitializeComponent();
            this.currentState = new RedState(this);
            timer = new DispatcherTimer();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(GetState() is RedState)
            {
                //change to green
                this.currentState.ToggleGreen();
                ResetTimer();
            } else if(GetState() is YellowState)
            {
                //change to red if state is yellow
                this.currentState.ToggleRed();
                ResetTimer();
            } else
            {
                //state is green
                this.currentState.ToggleYellow();
                ResetTimer();
            }
        }

        public void ResetTimer()
        {
            timer.Stop();
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }

        public IState GetState()
        {
            return this.currentState;
        }

        public void SetState(IState state)
        {
            this.currentState = state;
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            this.currentState.ToggleRed();
        }
        
        private void Yellow_Click(object sender, RoutedEventArgs e)
        {
            this.currentState.ToggleYellow();
        }

        private void Green_Click(object sender, RoutedEventArgs e)
        {
            this.currentState.ToggleGreen();
        }
    }
}
