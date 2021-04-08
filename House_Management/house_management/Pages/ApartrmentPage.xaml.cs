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
    /// Логика взаимодействия для ApartrmentPage.xaml
    /// </summary>
    public partial class ApartrmentPage : Page
    {
        public ApartrmentPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вывод таблицы Apartment в DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ApartmentView.ItemsSource = dbContext.db.Apartment.ToList();
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
        /// Удаление данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            Apartment removeApartment = (Apartment)ApartmentView.SelectedItem;
            dbContext.db.Apartment.Remove(removeApartment);
            dbContext.db.SaveChanges();
            ApartmentView.ItemsSource = dbContext.db.Apartment.ToList();
        }

        /// <summary>
        /// Переход на страницу добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InsertHouseOpen_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ApartmentInsert());
        }
    }
}
