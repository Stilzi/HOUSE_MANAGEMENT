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
    /// Логика взаимодействия для HouseInsertxaml.xaml
    /// </summary>
    public partial class HouseInsertxaml : Page
    {
        public HouseInsertxaml()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Вернуться на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        /// <summary>
        /// Добавлние данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            House insertHouse = new House() 
            {
                Number = Convert.ToInt32(txbNumber.Text)
            };
            dbContext.db.House.Add(insertHouse);
            dbContext.db.SaveChanges();
            MessageBox.Show("Добавдено", "Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
