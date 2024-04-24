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

namespace lab_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        lab_8_2 Lab8_2 = new lab_8_2();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_lab_8_2(object sender, RoutedEventArgs e)
        {
            this.Close();
            Lab8_2.Show();
        }
    }
}
