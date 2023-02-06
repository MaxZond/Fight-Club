
using FigthClub_LabEZ;
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

namespace FigthClubWPF
{
    /// <summary>
    /// Логика взаимодействия для LogInPage.xaml
    /// </summary>
    public partial class LogInPage : Page
    {
        public LogInPage()
        {
            InitializeComponent();
        }
        List<int> userCheck = new List<int>();
        List<string> userLogin = new List<string>();
        List<string> userName = new List<string>();
        List<string> userPassword = new List<string>();

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService?.Navigate(new Register());
        }

        private void LogInbutton_Click(object sender, RoutedEventArgs e)
        {

            try
            {

                string user = LoginTB.Text;
                string user2 = PasswordBox.Password;
                userLogin = AppData.db.Users.Where(a => a.Логин == user).Select(b => b.Логин).ToList();
                userCheck = AppData.db.Users.Where(a => a.Логин == LoginTB.Text).Select(b => b.Код_пользователя).ToList();
                userName = AppData.db.Users.Where(a => a.Логин == user).Select(b => b.Никнейм).ToList();
                userPassword = AppData.db.Users.Where(a => a.Пароль == user2).Select(b => b.Пароль).ToList();
               


                if (user == userLogin[0] && user2 == userPassword[0])
                {

                    MessageBox.Show($"Доброго времени суток {Convert.ToString(userName[0])}!");
                    NavigationService?.Navigate(new MenuPage(userCheck[0]));
                }
            }
            catch
            { 
                MessageBox.Show("Пользователь не найден!", "Ошибка!");
            }

        }
    }
}
