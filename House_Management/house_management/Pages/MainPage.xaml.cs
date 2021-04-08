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
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Переход к странице с домами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new HousePage());
        }

        /// <summary>
        /// Переход к странице с квартирами
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ApartmentOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ApartrmentPage());
        }

        /// <summary>
        /// Переход к таблице с информацией оплаты
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PaymentOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentPage());
        }
    }
}
