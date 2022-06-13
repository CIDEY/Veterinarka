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

namespace Veterinarka.Pages
{
    /// <summary>
    /// Логика взаимодействия для ServiceList.xaml
    /// </summary>
    public partial class ServiceList : Page
    {
        public ServiceList()
        {
            InitializeComponent();
            table.ItemsSource = App.db.Services.ToList();
        }

        private void dltService(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Вы уверены аннулировать данную запись?", "Да, аннулировать", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (table.SelectedItem == null)
                {
                    MessageBox.Show("Ошибка", "Выберите аннулировать запись!");
                }

                else
                {
                    App.db.Services.Remove(table.SelectedItem as Service);
                    MessageBox.Show("Данная запись аннулирована", "Аннулирование");
                    App.db.SaveChanges();
                    table.ItemsSource = App.db.Services.ToList();
                }
            }
        }

        private void goToAddService(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate( new AddService());
        }
    }
}
