using FigthClubWPF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


namespace FigthClub_LabEZ
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    { 
        //static string connectionString = @"data source=IRBIS-NB78;initial catalog=FigthClub;integrated security=True";
        static string connectionString = @"data source=lab116-p;initial catalog=FigthClub;user id=sa;password=12345";
        SqlConnection cnn = new SqlConnection(connectionString);
        static int id = 0;

        static bool visWW = false;
        static bool visBoxer = false;
        static bool visBaby = false;
        static bool visCrus = false;
        static bool visSmirn = false;
        static bool visWW2 = false;
        static bool visBoxer2 = false;
        static bool visBaby2 = false;
        static bool visCrus2 = false;
        static bool visSmirn2 = false;

        public MenuPage(int userId)
        {
            InitializeComponent();
           

            cnn.Open();
            List<string> userRole = new List<string>();
            List<string> userName = new List<string>();
            id = userId;
            try
            {
                userRole = AppData.db.Users.Where(a => a.Код_пользователя == userId).Select(b => b.Роль).ToList();
                if (userRole[0] == "admin")
                {
                    SmirnovButton.IsEnabled = true;
                    SmirnovButton.Visibility = Visibility.Visible;
                }

                userName = AppData.db.Users.Where(a => a.Код_пользователя == userId).Select(b => b.Никнейм).ToList();
                NickNameTB.Text = Convert.ToString(userName[0]);
            }
            catch
            {
                return;
            }
        }

        private void BoxerButton_Click(object sender, RoutedEventArgs e)
        {
            if(ChooseButton.IsVisible)
            {
                GridWW1.Visibility = Visibility.Hidden;
                GridBabyFigther.Visibility = Visibility.Hidden;
                GridSmirnov.Visibility = Visibility.Hidden;
                GridCrus.Visibility = Visibility.Hidden;
                GridBoxer1.Visibility = Visibility.Visible;

                visBoxer = true;
                visWW = false;
                visSmirn = false;
                visCrus = false;
                visBaby = false;
            }
            else
            {
                GridWW2.Visibility = Visibility.Hidden;
                GridBabyFigther2.Visibility = Visibility.Hidden;
                GridSmirnov2.Visibility = Visibility.Hidden;
                GridCrus2.Visibility = Visibility.Hidden;
                GridBoxer2.Visibility = Visibility.Visible;

                visBoxer2 = true;
                visWW2 = false;
                visSmirn2 = false;
                visCrus2 = false;
                visBaby2 = false;
            }

            string query = $@"Select Сила, Выносливость, Здоровье From Charecter Where Имя_персонажа = 'Boxer'";
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = query;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                StrengProgressBarBox1.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarBox1.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarBox1.Value = Convert.ToDouble(r.GetValue(2));
                StrengProgressBarBox2.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarBox2.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarBox2.Value = Convert.ToDouble(r.GetValue(2));
            }
            r.Close();

        }

        private void WalterButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChooseButton.IsVisible)
            {
                GridBoxer1.Visibility = Visibility.Hidden;
                GridBabyFigther.Visibility = Visibility.Hidden;
                GridSmirnov.Visibility = Visibility.Hidden;
                GridCrus.Visibility = Visibility.Hidden;
                GridWW1.Visibility = Visibility.Visible;

                visBoxer = false;
                visWW = true;
                visSmirn = false;
                visCrus = false;
                visBaby = false;
            }
            else
            {
                GridBoxer2.Visibility = Visibility.Hidden;
                GridBabyFigther2.Visibility = Visibility.Hidden;
                GridSmirnov2.Visibility = Visibility.Hidden;
                GridCrus2.Visibility = Visibility.Hidden;
                GridWW2.Visibility = Visibility.Visible;

                visBoxer2 = false;
                visWW2 = true;
                visSmirn2 = false;
                visCrus2 = false;
                visBaby2 = false;
            }

            string query = $@"Select Сила, Выносливость, Здоровье From Charecter Where Имя_персонажа = 'Walter White'";
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = query;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                StrengProgressBar1.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBar1.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBar1.Value = Convert.ToDouble(r.GetValue(2));
                StrengProgressBar2.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBar2.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBar2.Value = Convert.ToDouble(r.GetValue(2));
            }
            r.Close();
        }

        private void BabyFigtherButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChooseButton.IsVisible)
            {
                GridBoxer1.Visibility = Visibility.Hidden;
                GridWW1.Visibility = Visibility.Hidden;
                GridSmirnov.Visibility = Visibility.Hidden;
                GridCrus.Visibility = Visibility.Hidden;
                GridBabyFigther.Visibility = Visibility.Visible;

                visBoxer = false;
                visWW = false;
                visSmirn = false;
                visCrus = false;
                visBaby = true;
            }
            else
            {
                GridBoxer2.Visibility = Visibility.Hidden;
                GridBabyFigther2.Visibility = Visibility.Visible;
                GridSmirnov2.Visibility = Visibility.Hidden;
                GridCrus2.Visibility = Visibility.Hidden;
                GridWW2.Visibility = Visibility.Hidden;

                visBoxer2 = false;
                visWW2 = false;
                visSmirn2 = false;
                visCrus2 = false;
                visBaby2 = true;
            }

            string query = $@"Select Сила, Выносливость, Здоровье From Charecter Where Имя_персонажа = 'Baby Figther'";
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = query;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                StrengProgressBarBaby1.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarBaby1.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarBaby1.Value = Convert.ToDouble(r.GetValue(2));
                StrengProgressBarBaby2.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarBaby2.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarBaby2.Value = Convert.ToDouble(r.GetValue(2));
            }
            r.Close();
        }

        private void SmirnovButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChooseButton.IsVisible)
            {
                GridBoxer1.Visibility = Visibility.Hidden;
                GridWW1.Visibility = Visibility.Hidden;
                GridBabyFigther.Visibility = Visibility.Hidden;
                GridCrus.Visibility = Visibility.Hidden;
                GridSmirnov.Visibility = Visibility.Visible;

                visBoxer = false;
                visWW = false;
                visSmirn = true;
                visCrus = false;
                visBaby = false;
            }
            else
            {
                GridBoxer2.Visibility = Visibility.Hidden;
                GridBabyFigther2.Visibility = Visibility.Hidden;
                GridSmirnov2.Visibility = Visibility.Visible;
                GridCrus2.Visibility = Visibility.Hidden;
                GridWW2.Visibility = Visibility.Hidden;

                visBoxer2 = false;
                visWW2 = false;
                visSmirn2 = true;
                visCrus2 = false;
                visBaby2 = false;
            }

            string query = $@"Select Сила, Выносливость, Здоровье From Charecter Where Имя_персонажа = 'Smirnov'";
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = query;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                StrengProgressBarSmirnov1.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarSmirnov1.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarSmirnov1.Value = Convert.ToDouble(r.GetValue(2));
                StrengProgressBarSmirnov2.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarSmirnov2.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarSmirnov2.Value = Convert.ToDouble(r.GetValue(2));
            }
            r.Close();
        }

        private void CrusButton_Click(object sender, RoutedEventArgs e)
        {
            if (ChooseButton.IsVisible)
            {
                GridBoxer1.Visibility = Visibility.Hidden;
                GridBabyFigther.Visibility = Visibility.Hidden;
                GridSmirnov.Visibility = Visibility.Hidden;
                GridWW1.Visibility = Visibility.Hidden;
                GridCrus.Visibility = Visibility.Visible;

                visBoxer = false;
                visWW = false;
                visSmirn = false;
                visCrus = true;
                visBaby = false;
            }
            else
            {
                GridBoxer2.Visibility = Visibility.Hidden;
                GridBabyFigther2.Visibility = Visibility.Hidden;
                GridSmirnov2.Visibility = Visibility.Hidden;
                GridCrus2.Visibility = Visibility.Visible;
                GridWW2.Visibility = Visibility.Hidden;

                visBoxer2 = false;
                visWW2 = false;
                visSmirn2 = false;
                visCrus2 = true;
                visBaby2 = false;
            }

            string query = $@"Select Сила, Выносливость, Здоровье From Charecter Where Имя_персонажа = 'Crus'";
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = query;
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                StrengProgressBarCrus1.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarCrus1.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarCrus1.Value = Convert.ToDouble(r.GetValue(2));
                StrengProgressBarCrus2.Value = Convert.ToDouble(r.GetValue(0));
                StatimaProgressBarCrus2.Value = Convert.ToDouble(r.GetValue(1));
                HealthProgressBarCrus2.Value = Convert.ToDouble(r.GetValue(2));
            }
            r.Close();
        }


        private void PlayButton_Click_1(object sender, RoutedEventArgs e)
        {
            if (GridBabyFigther2.Visibility == Visibility.Visible || GridBoxer2.Visibility == Visibility.Visible || GridCrus2.Visibility == Visibility.Visible ||
    GridWW2.Visibility == Visibility.Visible || GridSmirnov2.Visibility == Visibility.Visible)
            {
                NavigationService.Navigate(new Ring(id, visWW, visBaby, visBoxer, visCrus, visSmirn, visWW2, visBaby2, visBoxer2, visCrus2, visSmirn2));
            }
            else
            {
                MessageBox.Show("Выберите бойца!", "Предупреждение!");
            }
        }

        private void ChooseButton_Click(object sender, RoutedEventArgs e)
        {
            if (GridBabyFigther.Visibility == Visibility.Visible || GridBoxer1.Visibility == Visibility.Visible || GridCrus.Visibility == Visibility.Visible ||
                GridWW1.Visibility == Visibility.Visible || GridSmirnov.Visibility == Visibility.Visible)
            {
                MessageBox.Show("Выбираем второго бойца!");
                ChooseButton.Visibility = Visibility.Hidden;
                PlayButton.Visibility = Visibility.Visible;
            }
            else
            {
                MessageBox.Show("Выберите бойца!", "Предупреждение!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new LogInPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выбираем первого бойца!");
        }
    }
}
