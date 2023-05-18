using StatePattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;

namespace StatePattern.States
{
    class GreenState : IState
    {
        private MainWindow context;

        public GreenState(MainWindow context)
        {
            this.context = context;
        }
        public void ToggleGreen()
        {
            //Do nothing, state is already green
        }

        public void ToggleRed()
        {
            //Cant go from Green to red
        }

        public void ToggleYellow()
        {
            //switch to yellow
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Yellow.Color;
            context.yellowLight.Fill = brush;

            SolidColorBrush brush2 = new SolidColorBrush();
            brush2.Color = Brushes.Gray.Color;
            context.greenLight.Fill = brush2;
            context.SetState(new YellowState(context));
        }
    }
}
