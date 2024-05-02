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
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        private void BtnEdit_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AdminPanelPage((sender as Button).DataContext as Users));
        }

        private void BtnAdd_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AdminPanelPage(null));
        }

        private void BtnDelete_click(object sender, RoutedEventArgs e)
        {
            var UserForRemoving = DGridUser.SelectedItems.Cast<Users>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {UserForRemoving.Count()} элементов ?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Polyakov2Entities.GetContext().Users.RemoveRange(UserForRemoving);
                    Polyakov2Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удаленны!");

                    DGridUser.ItemsSource = Polyakov2Entities.GetContext().Users.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void DGridUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Polyakov2Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridUser.ItemsSource = Polyakov2Entities.GetContext().Users.ToList();
            }
        }
    }
}
