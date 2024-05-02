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

namespace lab_rab_2_mdk01._01
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Calc_Click(object sender, RoutedEventArgs e)
        {
            double side1 = double.Parse(side1TextBox.Text);
            double side2 = double.Parse(side2TextBox.Text);
            double side3 = double.Parse(side3TextBox.Text);

            double perimeter = side1 + side2 + side3;

            double halfPerimeter = perimeter / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - side1) * (halfPerimeter - side2) * (halfPerimeter - side3));
            if (perimeterCheckBox.IsChecked == true && areaCheckBox.IsChecked == true)
            {
                MessageBox.Show("Периметр: " + perimeter + "\nОбласть: " + area, "Результат");
                
            }
            else if (areaCheckBox.IsChecked == true)
            {
                MessageBox.Show($"Периметр: Гaлочка не поставлена \nОбласть: {area}", "Результат");
            }
            else if (perimeterCheckBox.IsChecked.Value == true)
            {
                MessageBox.Show("Периметр: " + perimeter + "\nОбласть: Гaлочка не поставлена", "Результат");
            }
            else
            {
                MessageBox.Show($"Периметр: Гaлочка не поставлена \nОбласть: Гaлочка не поставлена", "Результат");
            }
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}
