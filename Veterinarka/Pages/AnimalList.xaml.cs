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
    /// Логика взаимодействия для AnimalList.xaml
    /// </summary>
    public partial class AnimalList : Page
    {
        public AnimalList()
        {
            InitializeComponent();
            table.ItemsSource = App.db.Animals.ToList();
        }

        private void goAddAnimal(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddAnimal());
        }
    }
}
