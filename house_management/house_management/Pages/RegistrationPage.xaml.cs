using house_management.Classes;
using house_management.Model;
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

namespace house_management.Pages
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавление аккаунта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Account registration = new Account()
            {
                Email = txbEmail.Text,
                Password = txbPassword.Password
            };
            dbContext.db.Account.Add(registration);
            dbContext.db.SaveChanges();
            MessageBox.Show("Вы успешно создали аккаунт", "Регистрация", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Открытие страницы входа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Avtorization_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AvtorizationPage());
        }
    }
}
