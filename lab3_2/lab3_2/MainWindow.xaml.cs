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

namespace lab3_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeSize5(object sender, RoutedEventArgs e)
        {
            Brush.Height = 5;
            Brush.Width = 5;
        }

        private void ChangeSize8(object sender, RoutedEventArgs e)
        {
            Brush.Height = 8;
            Brush.Width = 8;
        }

        private void ChangeSize2(object sender, RoutedEventArgs e)
        {
            Brush.Height = 2;
            Brush.Width = 2;
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ChangeColorBlack(object sender, RoutedEventArgs e)
        {
            Brush.Color = Colors.Black;
        }

        private void ChangeColorRed(object sender, RoutedEventArgs e)
        {
            Brush.Color = Colors.Red;
        }

        private void ChangeColorBlue(object sender, RoutedEventArgs e)
        {
            Brush.Color = Colors.Blue;
        }

        private void ChangeColorGreen(object sender, RoutedEventArgs e)
        {
            Brush.Color = Colors.Green;
        }
        private void ChangeColorYellow(object sender, RoutedEventArgs e)
        {
            Brush.Color = Colors.Yellow;
        }

        private void ChangeSize16(object sender, RoutedEventArgs e)
        {
            Brush.Height = 16;
            Brush.Width = 16;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (Brush != null) {
                Brush.Height = SliderSize.Value;
                Brush.Width = SliderSize.Value;
            }  
        }

        private void ChangeColorWhite(object sender, RoutedEventArgs e)
        {
            Brush.Color = Colors.White; 
        }
        private void ChangeBGBlack(object sender, RoutedEventArgs e)
        {
            Paint.Background = Brushes.Black;
        }
        private void ChangeBGWhite(object sender, RoutedEventArgs e)
        {
            Paint.Background = Brushes.White;
        }
        private void ChangeBGBlue(object sender, RoutedEventArgs e)
        {
            Paint.Background = Brushes.Blue;
        }
        private void ChangeBGYellow(object sender, RoutedEventArgs e)
        {
            Paint.Background = Brushes.Yellow;
        }
        private void ChangeBGRed(object sender, RoutedEventArgs e)
        {
            Paint.Background = Brushes.Red;
        }
        private void ChangeBGGreen(object sender, RoutedEventArgs e)
        {
            Paint.Background = Brushes.Green;
        }
    }
}
