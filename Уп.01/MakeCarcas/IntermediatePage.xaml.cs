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
using System.IO;


namespace MakeCarcas
{
    /// <summary>
    /// Логика взаимодействия для IntermediatePage.xaml
    /// </summary>
    public partial class IntermediatePage : Page
    {
        private Users user;

        public IntermediatePage()
        {
            InitializeComponent();
        }
        public IntermediatePage(Users user)
        {
            InitializeComponent();
            Console.WriteLine($"{user.IsAdmin}");

            if (user.IsAdmin == "Yes")
                BtnAdminPanel.Visibility = Visibility.Visible;
            else
                BtnAdminPanel.Visibility = Visibility.Hidden;
            this.user = user;
        }

        private void BtnHotel_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new HotelPage());

        }

        private void BtnTour_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new TourPage());
        }

        private void BtnAdminPanel_Click(object sender, RoutedEventArgs e)
        {      
            Manager.MainFrame.Navigate(new AdminPage());
        }
    }
}
