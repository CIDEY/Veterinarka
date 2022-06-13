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
    /// Логика взаимодействия для AddService.xaml
    /// </summary>
    public partial class AddService : Page
    {
        public AddService()
        {
            InitializeComponent();
            ownerCmb.ItemsSource = App.db.Owners.ToList();
            animalCmb.ItemsSource = App.db.Animals.ToList();
            doctorCmb.ItemsSource = App.db.Doctors.ToList();
            vaccinaCmb.ItemsSource = App.db.Vaccinations.ToList();
        }

        private void BackToServiceList(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ServiceList());
        }

        private void AddToService(object sender, RoutedEventArgs e)
        {
            if (ownerCmb.Text == "" || animalCmb.Text == "" || doctorCmb.Text == "" || vaccinaCmb.Text == "")
            {
                MessageBox.Show("Ошибка", "Поля пусты. Введите значения!");
            }
            else
            {
                //Animal animal = new Animal()
                //{
                //    TypeAnimal = typeCmb.SelectedItem as TypeAnimal,
                //    Name = nameTxt.Text
                //};

                //App.db.Animals.Add(animal);
                //App.db.SaveChanges();
                //MessageBox.Show("Добавление питомца", "Питомец ");
                //NavigationService.Navigate(new AnimalList());

                Service service = new Service()
                {
                    Owner = ownerCmb.SelectedItem as Owner,
                    Animal = animalCmb.SelectedItem as Animal,
                    Doctor = doctorCmb.SelectedItem as Doctor,
                    Vaccination = vaccinaCmb.SelectedItem as Vaccination
                };

                App.db.Services.Add(service);
                App.db.SaveChanges();
                MessageBox.Show("Запись Оформлена");
                NavigationService.Navigate(new ServiceList());
            }
        }
    }
}
