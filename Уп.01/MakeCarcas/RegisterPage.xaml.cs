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
    /// Логика взаимодействия для RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new LoginPage());
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Users newUser = new Users();
            newUser.User = login.Text;
            newUser.Password = password.Password;
            if(Polyakov2Entities.GetContext().Users.Where(p => p.User == newUser.User).Any())
            {
                MessageBox.Show("Такой пользователь уже существует!");
                return;
            }
            try
            {
                Polyakov2Entities.GetContext().Users.Add(newUser);
                Polyakov2Entities.GetContext().SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка регистрации");
            }
            MessageBox.Show("Вы успешно зарегистрировались");
        }
    }
}
