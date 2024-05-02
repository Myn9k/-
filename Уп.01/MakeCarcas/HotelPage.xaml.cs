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
    /// Логика взаимодействия для HotelPage.xaml
    /// </summary>
    public partial class HotelPage : Page
    {
        public HotelPage()
        {
            InitializeComponent();
            DGridHotels.ItemsSource = Polyakov2Entities.GetContext().Hotel.ToList();
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void BtnEdit_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Hotel));
        }

        private void BtnDelete_click(object sender, RoutedEventArgs e)
        {
            var hotelForRemoving = DGridHotels.SelectedItems.Cast<Hotel>().ToList();

            if (MessageBox.Show($"Вы точно хотите удалить следующие {hotelForRemoving.Count()} элементов ?" , "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    Polyakov2Entities.GetContext().Hotel.RemoveRange(hotelForRemoving);
                    Polyakov2Entities.GetContext().SaveChanges();
                    MessageBox.Show("Данные удаленны!");

                    DGridHotels.ItemsSource = Polyakov2Entities.GetContext().Hotel.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void BtnAdd_click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                Polyakov2Entities.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridHotels.ItemsSource = Polyakov2Entities.GetContext().Hotel.ToList();
            }
        }
        private void DGridHotels_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
