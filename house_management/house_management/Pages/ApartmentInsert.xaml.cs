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
    /// <summary>
    /// Логика взаимодействия для ApartmentInsert.xaml
    /// </summary>
    public partial class ApartmentInsert : Page
    {
        public ApartmentInsert()
        {
            InitializeComponent();
            Housecmb.ItemsSource = dbContext.db.House.Select(item => item.IdHouse).ToList();
            Paymentcmb.ItemsSource = dbContext.db.Payment.Select(item => item.IdPayment).ToList();
        }

        /// <summary>
        /// Добавление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            Apartment insertApartment = new Apartment() 
            {
                HouseId = Convert.ToInt32(Housecmb.SelectedItem),
                QuantityLodgers = Convert.ToInt32(txbQuantityLodgers.Text),
                Square = Convert.ToInt32(txbSquare.Text),
                PaymentId = Convert.ToInt32(Paymentcmb.SelectedItem)
            };
            dbContext.db.Apartment.Add(insertApartment);
            dbContext.db.SaveChanges();
            MessageBox.Show("Добавдено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        /// <summary>
        /// Возвращение на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
