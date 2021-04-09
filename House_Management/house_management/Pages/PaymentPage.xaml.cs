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
    public partial class PaymentPage : Page
    {
        public PaymentPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вывод таблицы Payment в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            PaymentView.ItemsSource = dbContext.db.Payment.ToList();
        }

        /// <summary>
        /// Редактирование данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            dbContext.db.SaveChanges();
        }

        /// <summary>
        /// Возвращение в главное меню
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Удаления данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Payment removePayment = (Payment)PaymentView.SelectedItem;
            dbContext.db.Payment.Remove(removePayment);
            dbContext.db.SaveChanges();
            PaymentView.ItemsSource = dbContext.db.Payment.ToList();
        }

        /// <summary>
        /// Переход на страницу добавления данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertHouseOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PaymentInsert());
        }
    }
}
