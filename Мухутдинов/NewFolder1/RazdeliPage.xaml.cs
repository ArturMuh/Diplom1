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
    /// Логика взаимодействия для RazdeliPage.xaml
    /// </summary>
    public partial class RazdeliPage : Page
    {
        public RazdeliPage()
        {
            InitializeComponent();
            ReloadRazdeli();
        }

        public void ReloadRazdeli()
        {
            var query = (from o in App.DB.Razdeli select o);

            if (!string.IsNullOrWhiteSpace(RazdeliNameSearchField.Text))
            {
                var q = RazdeliNameSearchField.Text;
                query = (from r in App.DB.Razdeli
                         where
                         r.Razdel.Contains(q)
                         select r);
            }
            RazdeliDataGrid.ItemsSource = query.ToList();
            RazdeliDataGrid.Items.Refresh();
        }

        private void RazdeliSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadRazdeli();
        }

        private void RazdeliDataGrid_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}
