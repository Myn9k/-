using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace lab3
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

        private void ChangeBGWhite(object sender, RoutedEventArgs e)
        {
            FirstGrid.Background = Brushes.White;
        }

        private void ChangeBGRed(object sender, RoutedEventArgs e)
        {
            FirstGrid.Background = Brushes.Red;
        }

        private void ChangeBGBlue(object sender, RoutedEventArgs e)
        {
            FirstGrid.Background = Brushes.Blue;
        }

        private void ChangeBGBlack(object sender, RoutedEventArgs e)
        {
            FirstGrid.Background = Brushes.Black;
        }

        private void DeveloperInfo(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/myn9k1");
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void ColorChanged(object sender, SelectionChangedEventArgs e)
        {
            if(ComboBoxColor.SelectedIndex == 0) 
            {
                FirstGrid.Background = Brushes.White;
            }
            else if (ComboBoxColor.SelectedIndex == 1)
            {
                FirstGrid.Background = Brushes.Red;
            }
            else if (ComboBoxColor.SelectedIndex == 2)
            {
                FirstGrid.Background = Brushes.Blue;
            }
            else if (ComboBoxColor.SelectedIndex == 3)
            {
                FirstGrid.Background = Brushes.Black;
            }
        }
    }
}
