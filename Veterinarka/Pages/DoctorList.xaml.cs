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
    /// Логика взаимодействия для DoctorList.xaml
    /// </summary>
    public partial class DoctorList : Page
    {
        public DoctorList()
        {
            InitializeComponent();
            table.ItemsSource = App.db.Doctors.ToList();
        }

        private void dltDoc(object sender, RoutedEventArgs e)
        {
            MessageBoxResult messageBoxResult = System.Windows.MessageBox.Show("Вы уверены уволить данного врача?", "Да, убрать", System.Windows.MessageBoxButton.YesNo);
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                if (table.SelectedItem == null)
                {
                    MessageBox.Show("Ошибка", "Выберите врача из списка!");
                }

                else
                {
                    App.db.Doctors.Remove(table.SelectedItem as Doctor);
                    MessageBox.Show("Данный врач уволен со штата", "Увольнение");
                    App.db.SaveChanges();
                    table.ItemsSource = App.db.Doctors.ToList();
                }
            }
        }

        private void addToDoc(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddOwner());
        }
    }
}
