using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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

namespace Isrpo_lab
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var context = pr4_PolyakovEntities.GetContext();
            context.Пользователь.Add(new Пользователь
            {
                Фамилия = lName.Text,
                Имя = name.Text,
                ЭлектронныйАдрес = eMail.Text,
                Пароль = passw.Password,
                КодовоеСлово = word.Text,
                ОтветНаСекретныйВопрос = otvet.Text,
                КодСекретногоВопроса = context.СекретныйВопрос.Where(i => i.СекретныйВопрос1 == qwest.Text).Select(i => i.КодСекретногоВопроса).FirstOrDefault()
            });
            context.SaveChanges();
            MessageBox.Show($"Пользователь {lName.Text} добавлен");
        }

        private void Go_Click(object sender, RoutedEventArgs e)
        {

        }

        private void LName_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            qwest.ItemsSource = pr4_PolyakovEntities.GetContext().СекретныйВопрос.Select(i => i.СекретныйВопрос1).ToList();
        }
    }
}
    