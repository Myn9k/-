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

namespace lab_11
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
            ChangeImage();
        }
        private void ChangeImage()
        {
            ImgLabel.Content = $"C:\\Users\\у\\Desktop\\lab_11\\img\\2.jpg";
        }

        private double rotationAngle = 0;
        private void RotateLeft_Click(object sender, RoutedEventArgs e)
        {
            rotationAngle -= 90;
            if (rotationAngle >= 360) { rotationAngle = 0; }
            imgView.LayoutTransform = new RotateTransform(rotationAngle, 200, 200);
        }
        private void RotateRight_Click(object sender, RoutedEventArgs e)
        {
            rotationAngle += 90;
            if (rotationAngle >= 360) { rotationAngle = 0; }
            imgView.LayoutTransform = new RotateTransform(rotationAngle, 200, 200);
        }
    }
}
