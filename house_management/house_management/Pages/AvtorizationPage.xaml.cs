using house_management.Classes;
using house_management.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace house_management.Pages
{
    /// <summary>
    /// Логика взаимодействия для AvtorizationPage.xaml
    /// </summary>
    public partial class AvtorizationPage : Page
    {
        public AvtorizationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Avtorizationbtn_Click(object sender, RoutedEventArgs e)
        {
            var avtoriz = dbContext.db.Account.FirstOrDefault(item => item.Email == txbEmail.Text && item.Password == txbPassword.Password);    
            if (avtoriz == null)
            {
                MessageBox.Show("Вы ввели неверные данные авторизации! Пожалуйста, повторите попытку...", "Не верно!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else
            {
                MessageBox.Show("Вы успешно авторизовались", "Авторизация", MessageBoxButton.OK, MessageBoxImage.Information);
                NavigationService.Navigate(new MainPage());
            }
        }
    }
}
