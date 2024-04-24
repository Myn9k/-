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

namespace Lab_7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        lab7_2 Lab7_2 = new lab7_2();
        lab7_3 Lab7_3 = new lab7_3();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_lab_7_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Lab7_2.Show();
        }

        private void Button_Click_lab_7_3(object sender, RoutedEventArgs e)
        {
            this.Close();
            Lab7_3.Show();
        }
    }
}
