using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace StatePattern.States
{
    class YellowState : IState
    {
        private MainWindow context;

        public YellowState(MainWindow context)
        {
            this.context = context;
        }
        public void ToggleGreen()
        {
            //Cannot go backwards from yellow to green, do nothing
        }

        public void ToggleRed()
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Red.Color;
            context.redLight.Fill = brush;

            SolidColorBrush brush2 = new SolidColorBrush();
            brush2.Color = Brushes.Gray.Color;
            context.yellowLight.Fill = brush2;
            context.SetState(new RedState(context));
        }

        public void ToggleYellow()
        {
            //Do nothing, current state is already yellow
        }
    }
}
