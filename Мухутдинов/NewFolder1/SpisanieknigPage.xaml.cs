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

namespace Мухутдинов.NewFolder1
{
    /// <summary>
    /// Логика взаимодействия для SpisanieknigPage.xaml
    /// </summary>
    public partial class SpisanieknigPage : Page
    {
        public SpisanieknigPage()
        {
            InitializeComponent();
        }

        public void ReloadPage()
        {
            SpisanieDataGrid.ItemsSource = (from Spisanie in App.DB.Spisanie
                                    select Spisanie).ToList();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            ReloadPage();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить эти данные", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                var item = SpisanieDataGrid.SelectedItem as Мухутдинов.NewFolder1.Spisanie;
                App.DB.Spisanie.Remove(item);
                App.DB.SaveChanges();
                ReloadPage();
            }
        }
    }
}
