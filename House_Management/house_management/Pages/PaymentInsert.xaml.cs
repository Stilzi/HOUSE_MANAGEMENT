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
    /// Логика взаимодействия для PaymentInsert.xaml
    /// </summary>
    public partial class PaymentInsert : Page
    {
        public PaymentInsert()
        {
            InitializeComponent();
            TypeOfPaymentcmb.ItemsSource = dbContext.db.TypeOfPayment.Select(item => item.Title).ToList();
        }

        /// <summary>
        /// Перейти на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Добавление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            var insertTypeOfPayment = dbContext.db.TypeOfPayment.FirstOrDefault(item => item.Title == TypeOfPaymentcmb.Text);
            Payment insertPayment = new Payment()
            {
                TypeOfPaymentId = insertTypeOfPayment.IdTypeOfPayment,
                SquarePrice = Convert.ToInt32(txbSquarePrice.Text),
                LodgersPrice = Convert.ToInt32(txbLodgersPrice.Text),
                PaymentAmount = Convert.ToInt32(txbPaymentAmount.Text),
                SupposedDatePayment = Convert.ToDateTime(dtSupposedDatePayment.SelectedDate),
                DateOfPayment = Convert.ToDateTime(dtDateOfPayment.SelectedDate)
            };
            dbContext.db.Payment.Add(insertPayment);
            dbContext.db.SaveChanges();
            MessageBox.Show("Добавдено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
