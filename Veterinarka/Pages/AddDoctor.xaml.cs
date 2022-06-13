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
    /// Логика взаимодействия для AddOwner.xaml
    /// </summary>
    public partial class AddOwner : Page
    {
        public AddOwner()
        {
            InitializeComponent();
        }

        private void addNewDoc(object sender, RoutedEventArgs e)
        {
            if (fNameTxt.Text == "" || lnameTxt.Text == "" )
            {
                MessageBox.Show("Ошибка", "Поля пусты. Введите значения!");
            }
            else
            {
                Doctor doc = new Doctor()
                {
                    FirstName = fNameTxt.Text,
                    LastName = lnameTxt.Text
                };

                App.db.Doctors.Add(doc);
                App.db.SaveChanges();
                MessageBox.Show("Регистрация врача", "Новый врач зарегистрирован в системе.");
                NavigationService.Navigate(new DoctorList());
            }
        }
    }
}
