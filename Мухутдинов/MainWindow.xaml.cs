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
using System.Windows.Threading;
using Мухутдинов.NewFolder1;

namespace Мухутдинов
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer;

        double panelWidth;
        bool hidden;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,0,0,10);
            timer.Tick += Timer_Tick;
            


            panelWidth = sidePanel.Width;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (hidden)
            {
                sidePanel.Width += 2;
                if (sidePanel.Width >= panelWidth)
                {
                    timer.Stop();
                    hidden = false;
                }
            }
            else
            {
                sidePanel.Width -= 2;
                if (sidePanel.Width <= 35)
                {
                    timer.Stop();
                    hidden = true;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            timer.Start();
        }

        private void panelHearder_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) 
            {
                DragMove();
            }
        }

        private void HearderMenu_Selected(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.GlavPage()); 
        }

        private void HearderAvtory_Selected(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.AvtoryPage());
        }

        private void Exit_Selected(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно закрыть программу?", "Подтверждение", MessageBoxButton.YesNo,
                 MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void HearderKnigi_Selected(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.KnigiPage());
        }

        private void HearderIzdatelstvo_Selected(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.IzdatelstvoPage());
        }

        private void ListViewItem_Selected(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.ZakazPage());
        }

        private void ListViewItem_Selected_1(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.RazdeliPage());
        }

        private void ListViewItem_Selected_2(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.PostavshikPage());
        }

        private void ListViewItem_Selected_3(object sender, RoutedEventArgs e)
        {
            Main.Navigate(new NewFolder1.SpisanieknigPage());
        }
    }
}
