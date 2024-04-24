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
using System.Windows.Shapes;

namespace lab_6
{
    /// <summary>
    /// Логика взаимодействия для lab6_1.xaml
    /// </summary>
    public partial class lab6_1 : Window
    {
        public lab6_1()
        {
            InitializeComponent();
        }

        private void closes_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
