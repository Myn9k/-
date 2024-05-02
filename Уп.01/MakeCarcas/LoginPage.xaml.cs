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

namespace MakeCarcas
{

    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();

        }
        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new RegisterPage());
        }
        public static bool Admin = false;
        private void Loginer_Click(object sender, RoutedEventArgs e)
        {
            var Adm = Polyakov2Entities.GetContext().Users;
            int Try = 3;
            if(Try != 0)
            {
                try
                {
                    var search_user = Polyakov2Entities.GetContext().Users.Where(p => p.User == login.Text && p.Password == password.Password).Single();

                    if (search_user.IsAdmin == "Yes")
                        Admin = true;
                    else
                        Admin = false;

                    Console.WriteLine($"{search_user.IsAdmin}");

                    MainWindow.Loginuspeshen(search_user);
                }
                catch
                {
                    MessageBox.Show("Ошибка, что-то неправильно");
                }
            }

        }
    }
}
