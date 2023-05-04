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
using System.Windows.Shapes;

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для StatusWindow.xaml
    /// </summary>
    public partial class StatusWindow : Window
    {
        public long ZakazID;
        public StatusWindow(long zakazID)
        {
            InitializeComponent();
            this.ZakazID = zakazID;

        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            if (StatusComboBox.Text!= "Не указан")
            {
                (from zakaz in App.DB.Zakaz
                 where zakaz.ID_zakaza == ZakazID
                 select zakaz).Single().Status = StatusComboBox.Text;
                App.DB.SaveChanges();
            }
           
            
            this.Close();
        }
        private static string stat;
        public delegate void RefreshList();
        public event RefreshList RefreshListEvent;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                stat = (from zakaz in App.DB.Zakaz
                        where zakaz.ID_zakaza == ZakazID
                        select zakaz).First().Status;
                stat = stat!=null? stat.ToString() : "Не указан";
                StatusComboBox.Text = stat.ToString();
            }
            catch { }
           
            var query = (from status in App.DB.Status
                         select status);

            StatusComboBox.ItemsSource = query.ToList();
        }
    }
}
