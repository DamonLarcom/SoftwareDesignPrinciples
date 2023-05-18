using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace StatePattern.States
{
    class RedState : IState
    {
        MainWindow context;
        public RedState(MainWindow context)
        {
            this.context = context;
        }
        public void ToggleGreen()
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Green.Color;
            context.greenLight.Fill = brush;

            SolidColorBrush brush2 = new SolidColorBrush();
            brush2.Color = Brushes.Gray.Color;
            context.redLight.Fill = brush2;
            context.SetState(new GreenState(context));
        }

        public void ToggleRed()
        {
            //state is already red, loop back to red
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Red.Color;
            context.redLight.Fill = brush;
            context.SetState(new RedState(context));
        }

        public void ToggleYellow()
        {
            //Cannot go from red to yellow
        }
    }
}
