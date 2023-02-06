using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Threading;

namespace FigthClub_LabEZ
{
    /// <summary>
    /// Логика взаимодействия для Ring.xaml
    /// </summary>
    public partial class Ring : Page
    {
        //bool move = true;
        static int id;
        static bool WW = false;
        static bool Baby = false;
        static bool Boxer = false;
        static bool Crus = false;
        static bool Smirn = false;
        static bool WW2 = false;
        static bool Baby2 = false;
        static bool Boxer2 = false;
        static bool Crus2 = false;
        static bool Smirn2 = false;
        public DispatcherTimer timer_figth = new DispatcherTimer();
        public DispatcherTimer timer_stamina_2 = new DispatcherTimer();
        public DispatcherTimer timer_stamina_1 = new DispatcherTimer();
        public Ring(int userId, bool visWW, bool visBaby, bool visBoxer, bool visCrus, bool visSmirn, bool visWW2, bool visBaby2, bool visBoxer2, bool visCrus2, bool visSmirn2)
        {
            InitializeComponent();
            id = userId;
            MenuPage m = new MenuPage(userId);
            
            if(visWW)
            {
                NameTB1.Text = m.WWTBlock1.Text;
                WalterRing.Visibility = Visibility.Visible;

                HealthBar1.Maximum = 15;
                HealthBar1.Value = HealthBar1.Maximum;
                StaminaBar1.Maximum = 20;
                StaminaBar1.Value = StaminaBar1.Maximum;

                HealtTB1.Text = Convert.ToString(HealthBar1.Value);
                StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);
                StrangeTB1.Text = "45";

                WW = true;
                Baby = false;
                Boxer = false;
                Smirn = false;
                Crus = false;
            }
            if (visBaby)
            {
                NameTB1.Text = m.BabyTB1.Text;
                Baby1.Visibility = Visibility.Visible;

                HealthBar1.Maximum = 90;
                HealthBar1.Value = HealthBar1.Maximum;
                StaminaBar1.Maximum = 90;
                StaminaBar1.Value = StaminaBar1.Maximum;

                HealtTB1.Text = Convert.ToString(HealthBar1.Value);
                StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);
                StrangeTB1.Text = "70";

                Baby = true;
                WW = false;
                Boxer = false;
                Smirn = false;
                Crus = false;
            }
            if (visBoxer)
            {
                NameTB1.Text = m.BoxerTB1.Text;
                Boxer1.Visibility = Visibility.Visible;

                HealthBar1.Maximum = 80;
                HealthBar1.Value = HealthBar1.Maximum;
                StaminaBar1.Maximum = 75;
                StaminaBar1.Value = StaminaBar1.Maximum;

                HealtTB1.Text = Convert.ToString(HealthBar1.Value);
                StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);
                StrangeTB1.Text = "90";

                Boxer = true;
                Baby = false;
                WW = false;
                Smirn = false;
                Crus = false;
            }
            if (visSmirn)
            {
                NameTB1.Text = m.SmirnovTB1.Text;
                Smirnov1.Visibility = Visibility.Visible;

                HealthBar1.Maximum = 100;
                HealthBar1.Value = HealthBar1.Maximum;
                StaminaBar1.Maximum = 100;
                StaminaBar1.Value = StaminaBar1.Maximum;

                HealtTB1.Text = Convert.ToString(HealthBar1.Value);
                StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);
                StrangeTB1.Text = "100";

                Smirn = true;
                Boxer = false;
                Baby = false;
                WW = false;
                Crus = false;
            }
            if (visCrus)
            {
                NameTB1.Text = m.CrusTB1.Text;
                CrusRing.Visibility = Visibility.Visible;

                HealthBar1.Maximum = 90;
                HealthBar1.Value = HealthBar1.Maximum;
                StaminaBar1.Maximum = 86;
                StaminaBar1.Value = StaminaBar1.Maximum;

                HealtTB1.Text = Convert.ToString(HealthBar1.Value);
                StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);
                StrangeTB1.Text = "92";

                Crus = true;
                Smirn = false;
                Boxer = false;
                Baby = false;
                WW = false;
            }

            //------------------------------------------------------------

            if (visWW2)
            {
                NameTB2.Text = m.WWTBlock2.Text;
                WalterRing2.Visibility = Visibility.Visible;

                HealthBar2.Maximum = 15;
                HealthBar2.Value = HealthBar2.Maximum;
                StaminaBar2.Maximum = 20;
                StaminaBar2.Value = StaminaBar2.Maximum;

                HealtTB2.Text = Convert.ToString(HealthBar2.Value);
                StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                StrangeTB2.Text = "45";

                WW2 = true;
                Baby2 = false;
                Boxer2 = false;
                Smirn2 = false;
                Crus2 = false;
            }
            if (visBaby2)
            {
                NameTB2.Text = m.BabyTB2.Text;
                BabyRing2.Visibility = Visibility.Visible;

                HealthBar2.Maximum = 90;
                HealthBar2.Value = HealthBar2.Maximum;
                StaminaBar2.Maximum = 90;
                StaminaBar2.Value = StaminaBar2.Maximum;

                HealtTB2.Text = Convert.ToString(HealthBar2.Value);
                StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                StrangeTB2.Text = "70";

                Baby2 = true;
                WW2 = false;
                Boxer2 = false;
                Smirn2 = false;
                Crus2 = false;
            }
            if (visBoxer2)
            {
                NameTB2.Text = m.BoxerTB1.Text;
                BoxerRing2.Visibility = Visibility.Visible;

                HealthBar2.Maximum = 80;
                HealthBar2.Value = HealthBar2.Maximum;
                StaminaBar2.Maximum = 75;
                StaminaBar2.Value = StaminaBar2.Maximum;

                HealtTB2.Text = Convert.ToString(HealthBar2.Value);
                StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                StrangeTB2.Text = "90";

                Boxer2 = true;
                Baby2 = false;
                WW2 = false;
                Smirn2 = false;
                Crus2 = false;
            }
            if (visSmirn2)
            {
                NameTB2.Text = m.SmirnovTB2.Text;
                SmirnovRing2.Visibility = Visibility.Visible;

                HealthBar2.Maximum = 100;
                HealthBar2.Value = HealthBar2.Maximum;
                StaminaBar2.Maximum = 100;
                StaminaBar2.Value = StaminaBar2.Maximum;

                HealtTB2.Text = Convert.ToString(HealthBar2.Value);
                StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                StrangeTB2.Text = "100";

                Smirn2 = true;
                Boxer2 = false;
                Baby2 = false;
                WW2 = false;
                Crus2 = false;
            }
            if (visCrus2)
            {
                NameTB2.Text = m.CrusTB2.Text;
                CrusRing2.Visibility = Visibility.Visible;

                HealthBar2.Maximum = 90;
                HealthBar2.Value = HealthBar2.Maximum;
                StaminaBar2.Maximum = 86;
                StaminaBar2.Value = StaminaBar2.Maximum;

                HealtTB2.Text = Convert.ToString(HealthBar2.Value);
                StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                StrangeTB2.Text = "92";

                Crus2 = true;
                Smirn2 = false;
                Boxer2 = false;
                Baby2 = false;
                WW2 = false;
            }

            GridAfterFigth.Visibility = Visibility.Hidden;

            Check();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Random r = new Random();
            timer_figth.Tick += new EventHandler(timer_Tick_Figth);
            timer_figth.Interval = new TimeSpan(0, 0, r.Next(1, 2));
            timer_figth.Start();

            timer_stamina_2.Tick += new EventHandler(timer_Tick_Stamina2);
            timer_stamina_2.Interval = new TimeSpan(0, 0, 1);
            timer_stamina_2.Start();

            timer_stamina_1.Tick += new EventHandler(timer_Tick_Stamina1);
            timer_stamina_1.Interval = new TimeSpan(0, 0, 1);
            timer_stamina_1.Start();
        }

        public void Check()
        {

            //if (move)
            //{
            //    move = false;
            //    UppercotButton.IsEnabled = true;
            //    UppercotButton.Visibility = Visibility.Visible;
            //    BlockButton.IsEnabled = true;
            //    BlockButton.Visibility = Visibility.Visible;
            //    UppercotButton2.IsEnabled = false;
            //    UppercotButton2.Visibility = Visibility.Hidden;
            //    BlockButton2.IsEnabled = false;
            //    BlockButton2.Visibility = Visibility.Hidden;
            //}
            //else
            //{
            //    move = true;
            //    UppercotButton2.IsEnabled = true;
            //    UppercotButton2.Visibility = Visibility.Visible;
            //    BlockButton2.IsEnabled = true;
            //    BlockButton2.Visibility = Visibility.Visible;
            //    UppercotButton.IsEnabled = false;
            //    UppercotButton.Visibility = Visibility.Hidden;
            //    BlockButton.IsEnabled = false;
            //    BlockButton.Visibility = Visibility.Hidden;
            //}
            if (StaminaBar1.Value <= 0)
            {
                StaminaBar1.Value = 0;
                UppercotButton.IsEnabled = false;
                BlockButton.IsEnabled = false;
                PunchButton.IsEnabled = false;
            }
            if (HealthBar2.Value <= 0)
            {
                HealthBar2.Value = 0;
                UppercotButton.IsEnabled = false;
                BlockButton.IsEnabled = false;
                PunchButton.IsEnabled = false;
                MessageBox.Show($"Победил {NameTB1.Text}");
                GridAfterFigth.Visibility = Visibility.Visible;
                timer_figth.Stop();
                timer_stamina_1.Stop();
                timer_stamina_2.Stop();
            }
            if (HealthBar1.Value <= 0)
            {
                HealthBar1.Value = 0;
                UppercotButton.IsEnabled = false;
                BlockButton.IsEnabled = false;
                PunchButton.IsEnabled = false;
                MessageBox.Show($"Победил {NameTB2.Text}");
                GridAfterFigth.Visibility = Visibility.Visible;
                timer_figth.Stop();
                timer_stamina_1.Stop();
                timer_stamina_2.Stop();
            }
        }

        private void UppercotButton_Click(object sender, RoutedEventArgs e)
        {
            Random r = new Random();

            try
            {
                if (HealthBar2.Value > 20)
                {
                    if (int.Parse(StrangeTB1.Text) >= 0 && int.Parse(StrangeTB1.Text) <= 95) HealthBar2.Value -= r.Next(1, Convert.ToInt32(HealthBar2.Value / 2));

                    if (int.Parse(StrangeTB1.Text) > 95 && int.Parse(StrangeTB1.Text) <= 100) HealthBar2.Value -= r.Next(1, Convert.ToInt32(HealthBar2.Value));
                }
                else HealthBar2.Value -= r.Next(1, Convert.ToInt32(HealthBar2.Value));

                HealtTB2.Text = Convert.ToString(HealthBar2.Value);

                StaminaBar1.Value -= r.Next(1, Convert.ToInt32(StaminaBar1.Value) / 2);
                StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);
            }
            catch
            {

            }

            Check();
        }

        private void HealthBar2_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (HealthBar2.Value < 25)
                HealthBar2.Foreground = Brushes.Red;
        }

        private void HealthBar1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (HealthBar1.Value < 25)
                HealthBar1.Foreground = Brushes.Red;
        }

        private void timer_Tick_Figth(object sender, EventArgs e)
        {
            Random r = new Random();
            if (HealthBar1.Value <= 0)
                Check();
            if (HealthBar1.Value > 0 && HealthBar2.Value > 0)
            {
                if (BlockButton.IsMouseOver == false)
                {
                    if (HealthBar1.Value > 20)
                    {
                        if (int.Parse(StrangeTB2.Text) >= 0 && int.Parse(StrangeTB2.Text) <= 95)
                            HealthBar1.Value -= r.Next(1, Convert.ToInt32(HealthBar1.Value / 4));

                        if (int.Parse(StrangeTB2.Text) > 95 && int.Parse(StrangeTB2.Text) <= 100)
                            HealthBar1.Value -= r.Next(1, Convert.ToInt32(HealthBar1.Value / 2));
                    }
                    else HealthBar1.Value -= r.Next(1, Convert.ToInt32(HealthBar1.Value));

                    HealtTB1.Text = Convert.ToString(HealthBar1.Value);

                    StaminaBar2.Value -= r.Next(1, Convert.ToInt32(StaminaBar2.Value) / 2);
                    StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                }
                else
                {
                    if (HealthBar1.Value > 20)
                    {
                        if (int.Parse(StrangeTB2.Text) >= 0 && int.Parse(StrangeTB2.Text) <= 95)
                            HealthBar1.Value -= r.Next(1, Convert.ToInt32(HealthBar1.Value / 6));

                        if (int.Parse(StrangeTB2.Text) > 95 && int.Parse(StrangeTB2.Text) <= 100)
                            HealthBar1.Value -= r.Next(1, Convert.ToInt32(HealthBar1.Value / 8));
                    }
                    else HealthBar1.Value -= r.Next(1, Convert.ToInt32(HealthBar1.Value));


                    HealtTB1.Text = Convert.ToString(HealthBar1.Value);

                    StaminaBar2.Value -= r.Next(1, Convert.ToInt32(StaminaBar2.Value) / 2);
                    StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);
                }
            }
            else
            {
                timer_figth.Stop();
            }
        }

        private void timer_Tick_Stamina1(object sender, EventArgs e)
        {
            Random r = new Random();
            if (HealthBar2.Value > 0 && HealthBar1.Value > 0)
            {
                if (StaminaBar1.Value != StaminaBar1.Maximum)
                {
                    StaminaBar1.Value += 5;
                    StaminaTB1.Text = Convert.ToString(StaminaBar1.Value);

                    if (StaminaBar1.Value >= Convert.ToInt32(StaminaBar1.Maximum))
                    {
                        StaminaBar1.Value = StaminaBar1.Maximum;
                    }
                }
            }
            else
            {
                timer_stamina_1.Stop();
            }
        }

        private void timer_Tick_Stamina2(object sender, EventArgs e)
        {
            Random r = new Random();
            if (HealthBar2.Value > 0 && HealthBar1.Value > 0)
            {
                if (StaminaBar2.Value != StaminaBar1.Maximum)
                {
                    StaminaBar2.Value += 5;
                    StaminaTB2.Text = Convert.ToString(StaminaBar2.Value);

                    if (StaminaBar2.Value >= Convert.ToInt32(StaminaBar2.Maximum))
                    {
                        StaminaBar2.Value = StaminaBar2.Maximum;
                    }
                }
            }
            else
            {
                timer_stamina_2.Stop();
            }
        }

        private void ResumButton_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Ring(id, WW, Baby, Boxer, Crus, Smirn, WW2, Baby2, Boxer2, Crus2, Smirn2));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MenuPage(id));
        }
    }
}
