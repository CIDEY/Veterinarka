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
    /// Логика взаимодействия для AddAnimal.xaml
    /// </summary>
    public partial class AddAnimal : Page
    {
        public AddAnimal()
        {
            InitializeComponent();
            typeCmb.ItemsSource = App.db.TypeAnimals.ToList();
        }

        private void addAnimal(object sender, RoutedEventArgs e)
        {
            if (nameTxt.Text == "" || typeCmb.Text == "")
            {
                MessageBox.Show("Ошибка", "Поля пусты. Введите значения!");
            }
            else
            {
                Animal animal = new Animal()
                {
                    TypeAnimal = typeCmb.SelectedItem as TypeAnimal,
                    Name = nameTxt.Text
                };

                App.db.Animals.Add(animal);
                App.db.SaveChanges();
                MessageBox.Show("Добавление питомца", "Питомец ");
                NavigationService.Navigate(new AnimalList());
            }
        }

        private void BackToAnimalList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AnimalList());
        }
    }
}
