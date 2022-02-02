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

namespace paintingProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public int changeRedCol = 0;
        public int changeGreenCol = 0;
        public int changeBlueCol = 0;
        public double changePen = 0;

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Canvy.Strokes.Clear();
        }

        /*private void Pen_Color_Click(object sender, RoutedEventArgs e)
        {
            changeCol++;

            if (changeCol > 2)
            {
                changeCol = 0;
            }

            if (changeCol == 0)
            {
                Canvy.DefaultDrawingAttributes.Color = Colors.Black;
            }

            else if (changeCol == 1)
            {
                Canvy.DefaultDrawingAttributes.Color = Colors.BlueViolet;
            }
            else if (changeCol == 2)
            {
                Canvy.DefaultDrawingAttributes.Color = Colors.Green;
            }

        }*/


        private void Pen_Red_Click(object sender, RoutedEventArgs e)
        {
            changeRedCol++;

            if (changeRedCol == 2)
            {
                changeRedCol = 0;
            }

            if (changeRedCol == 0)
            {
                Canvy.DefaultDrawingAttributes.Color = Canvy.DefaultDrawingAttributes.Color - Color.FromRgb(255, 0, 0);
            }

            else if (changeRedCol == 1)
            {
                Canvy.DefaultDrawingAttributes.Color = Canvy.DefaultDrawingAttributes.Color + Color.FromRgb(255, 0, 0);
            }

        }

        private void Pen_Green_Click(object sender, RoutedEventArgs e)
        {
            changeGreenCol++;

            if (changeGreenCol == 2)
            {
                changeGreenCol = 0;
            }

            if (changeGreenCol == 0)
            {
                Canvy.DefaultDrawingAttributes.Color = Canvy.DefaultDrawingAttributes.Color - Color.FromRgb(0, 255, 0);
            }

            else if (changeGreenCol == 1)
            {
                Canvy.DefaultDrawingAttributes.Color = Canvy.DefaultDrawingAttributes.Color + Color.FromRgb(0, 255, 0);
            }

        }

        private void Pen_Blue_Click(object sender, RoutedEventArgs e)
        {
            changeBlueCol++;

            if (changeBlueCol == 2)
            {
                changeBlueCol = 0;
            }

            if (changeBlueCol == 0)
            {
                Canvy.DefaultDrawingAttributes.Color = Canvy.DefaultDrawingAttributes.Color - Color.FromRgb(0, 0, 255);
            }

            else if (changeBlueCol == 1)
            {
                Canvy.DefaultDrawingAttributes.Color = Canvy.DefaultDrawingAttributes.Color + Color.FromRgb(0, 0, 255);
            }

        }

        private void Pen_ColReset_Click(object sender, RoutedEventArgs e)
        {
            
            Canvy.DefaultDrawingAttributes.Color = Color.FromRgb(0, 0, 0);
           
        }


        private void Thickness_Click(object sender, RoutedEventArgs e)
        {
            // Canvy

            changePen = changePen + 0.5;

            if (changePen > 5){
                changePen = 0.5;
            }

            Canvy.DefaultDrawingAttributes.Width = changePen;
            Canvy.DefaultDrawingAttributes.Height = changePen;


        }

        private void Thickness_Reset_Click(object sender, RoutedEventArgs e)
        {
            changePen = 1;
        }

        
    }
}
