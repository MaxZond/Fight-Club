using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
using System.Windows.Threading;

namespace FigthClubWPF
{
    /// <summary>
    /// Логика взаимодействия для Register.xaml
    /// </summary>
    public partial class Register : Page
    {
        private DispatcherTimer _timer;

        public Register()
        {
            InitializeComponent();
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 3);
            _timer.Tick += IdleTick;
            _timer.Start();
        }

        private void IdleTick(object sender, EventArgs e)
        {
            var idle = GetIdle();
            if (idle.Seconds >= 10)
            {
                NavigationService?.Navigate(new LogInPage());
            }
        }

        TimeSpan GetIdle()
        {
            var lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (uint)Marshal.SizeOf(lastInputInfo);

            GetLastInputInfo(ref lastInputInfo);

            var lastInput = DateTime.Now.AddMilliseconds(
                -(Environment.TickCount - lastInputInfo.dwTime));
            return DateTime.Now - lastInput;
        }

        [DllImport("User32.dll")]
        private static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        [StructLayout(LayoutKind.Sequential)]
        internal struct LASTINPUTINFO
        {
            public uint cbSize;
            public uint dwTime;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTB.Text) || string.IsNullOrEmpty(PasswordBox.Password))
            {
                MessageBox.Show("Введите логин и пароль!", "Ошибка!");
                return;
            }

            if (PasswordBox.Password == ConfirmPassword.Password)
            {
                Users u = new Users();
                List<string> userLogin = new List<string>();
                List<string> userEmail = new List<string>();
                u.Электронная_почта = EmailTB.Text;
                u.Никнейм = NickNameTB.Text;
                u.Логин = LoginTB.Text;
                u.Пароль = PasswordBox.Password;
                u.Роль = RoleTB.Text;
                userLogin = AppData.db.Users.Where(a => a.Логин == LoginTB.Text).Select(b => b.Логин).ToList();
                userEmail = AppData.db.Users.Where(a => a.Электронная_почта == EmailTB.Text).Select(b => b.Электронная_почта).ToList();
                if (userLogin.Count == 0 && userEmail.Count == 0 )
                {
                    AppData.db.Users.Add(u);
                    AppData.db.SaveChanges();
                    NavigationService?.Navigate(new LogInPage());
                }
                else
                {
                    MessageBox.Show("Пользователь с такими данными уже существует!");
                    LoginTB.Clear();
                    EmailTB.Clear();
                }
            }
            else
            {
                MessageBox.Show("Password Error!");
                PasswordBox.Clear();
                ConfirmPassword.Clear();
            }
        }
    }
}
