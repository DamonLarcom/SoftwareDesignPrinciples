using CommandPatternLab.Commands;
using CommandPatternLab.Interface;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Media;

namespace CommandPatternLab
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IReceiver
    {

        private int rectX = 0;
        private int rectY = 0;

        private List<Invoker> invokers = new List<Invoker>();
        private List<Invoker> executed = new List<Invoker>();

        private Invoker upInvoker;
        private Invoker downInvoker;
        private Invoker leftInvoker;
        private Invoker rightInvoker;
        private Invoker redInvoker;
        private Invoker blueInvoker;
        private Invoker greenInvoker;

        public MainWindow()
        {
            InitializeComponent();
            upInvoker = new Invoker(new MoveUpCommand(this));
            downInvoker = new Invoker(new MoveDownCommand(this));
            leftInvoker = new Invoker(new MoveLeftCommand(this));
            rightInvoker = new Invoker(new MoveRightCommand(this));
            redInvoker = new Invoker(new SetColorCommand(this, Brushes.Red.Color, ((SolidColorBrush)rect.Fill).Color));
            blueInvoker = new Invoker(new SetColorCommand(this, Brushes.Blue.Color, ((SolidColorBrush)rect.Fill).Color));
            greenInvoker = new Invoker(new SetColorCommand(this, Brushes.Green.Color, ((SolidColorBrush)rect.Fill).Color));
        }

        public void MakeTranslation(TranslateTransform ttf)
        {
            var shape = rect;
            rect.RenderTransform = ttf;
            commandCanvas.Children.Remove(rect);
            commandCanvas.Children.Add(shape);
        }

        public void MoveDown()
        {
            rectY += 20;
            MakeTranslation(new TranslateTransform(rectX, rectY));
            Console.WriteLine("Moved down 20 pixels.");
        }

        public void MoveLeft()
        {
            rectX -= 20;
            MakeTranslation(new TranslateTransform(rectX, rectY));
            Console.WriteLine("Moved left 20 pixels.");
        }

        public void MoveRight()
        {
            rectX += 20;
            MakeTranslation(new TranslateTransform(rectX, rectY));
            Console.WriteLine("Moved right 20 pixels.");
        }

        public void MoveUp()
        {
            rectY -= 20;
            MakeTranslation(new TranslateTransform(rectX, rectY));
            Console.WriteLine("Moved up 20 pixels.");
        }

        public void SetBlue()
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Blue.Color;
            rect.Fill = brush;
            Console.WriteLine("Color set to blue");
        }

        public void SetGreen()
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Green.Color;
            rect.Fill = brush;
            Console.WriteLine("Color set to green");
        }

        public void SetRed()
        {
            SolidColorBrush brush = new SolidColorBrush();
            brush.Color = Brushes.Red.Color;
            rect.Fill = brush;
        }

        private void RedClick(object sender, RoutedEventArgs e)
        {
            invokers.Add(redInvoker);
        }

        private void GreenClick(object sender, RoutedEventArgs e)
        {
            invokers.Add(greenInvoker);
        }

        private void BlueClick(object sender, RoutedEventArgs e)
        {
            invokers.Add(blueInvoker);
        }

        private void leftBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!(rectX - 20 < 0))
                invokers.Add(leftInvoker);
        }

        private void rightBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!(rectX + 20 > commandCanvas.Width - rect.Width))
                invokers.Add(rightInvoker);
        }

        private void downBtn_Click(object sender, RoutedEventArgs e)
        {
            if(!(rectY + 20 > commandCanvas.Height - rect.Height))
                invokers.Add(downInvoker);
        }

        private void upBtn_Click(object sender, RoutedEventArgs e)
        {
            if (!(rectY - 20 < 0))
                invokers.Add(upInvoker);
        }

        private void RunCommands_Click(object sender, RoutedEventArgs e)
        {
            foreach(Invoker i in invokers)
            {
                i.ExecuteCommand();
                executed.Add(i);
            }
            invokers.Clear();
        }

        private void UndoCommands_Click(object sender, RoutedEventArgs e)
        {
            //run list of invokers in reverse
            for(int i = executed.Count - 1; i >= 0; i--)
            {
                executed[i].UndoCommand();
            }
            executed.Clear();
        }
    }
}
