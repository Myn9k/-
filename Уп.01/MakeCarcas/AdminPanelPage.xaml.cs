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
    /// Логика взаимодействия для AdminPanelPage.xaml
    /// </summary>
    public partial class AdminPanelPage : Page
    {
        private Users _currentUser = new Users();
        public AdminPanelPage(Users selectedUser)
        {
            InitializeComponent();

            if (_currentUser != null)
                _currentUser = selectedUser;

            DataContext = _currentUser;
        }

        private void BtnSave_click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentUser.User))
                errors.AppendLine("Укажите Имя пользователя");
            if (string.IsNullOrWhiteSpace(_currentUser.Password))
                errors.AppendLine("Укажите Пароль пользователя");
            if (_currentUser.IsAdmin == null)
                errors.AppendLine("Выберите Права пользователя");
            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentUser.id == 0)
                Polyakov2Entities.GetContext().Users.Add(_currentUser);
            try
            {
                Polyakov2Entities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
