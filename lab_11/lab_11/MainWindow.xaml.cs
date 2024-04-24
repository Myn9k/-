using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab_11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            two.ImgLabel.Content = "C:\\Users\\ыыыы\\source\\repos\\lab_11\\img\\3.jpg";
            three.ImgLabel.Content = "C:\\Users\\ыыыы\\source\\repos\\lab_11\\img\\4.jpg";
            four.ImgLabel.Content = "C:\\Users\\ыыыы\\source\\repos\\lab_11\\img\\5.jpg";
            five.ImgLabel.Content = "C:\\Users\\ыыыы\\source\\repos\\lab_11\\img\\6.jpg";
            six.ImgLabel.Content = "C:\\Users\\ыыыы\\source\\repos\\lab_11\\img\\8.jpg";
        }
    }
}






