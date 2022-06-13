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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void EnterToAccount(object sender, RoutedEventArgs e)
        {
            var userFromDb = (from account in App.db.Accounts where account.Login == loginBox.Text && account.Password == passBox.Password select account).FirstOrDefault();
            if (userFromDb == null)
            {
                MessageBox.Show("Вы неправильно ввели логин или пароль, пожалуйста проверьте правильность введенных данных");
            }
            else if (userFromDb != null)
            {
                MessageBox.Show("Вход", "Вы успешно вошли в аккаунт!");
                var useFromDb = (from account in App.db.Accounts where account.Login == loginBox.Text && account.Password == passBox.Password select account.Login).FirstOrDefault();
                App.nameClientOnPage = useFromDb;
                NavigationService.Navigate(new MainPage());

            }
        }
    }
}
