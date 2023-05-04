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
    /// Логика взаимодействия для ZakazPage.xaml
    /// </summary>
    public partial class ZakazPage : Page
    {
        public ZakazPage()
        {
            InitializeComponent();
            ReloadZakaz();
        }

        public void ReloadZakaz()
        {
            var query = (from o in App.DB.Zakaz select o);

            if (!string.IsNullOrWhiteSpace(ZakazNameSearchField.Text))
            {
                var q = ZakazNameSearchField.Text;
                query = (from z in App.DB.Zakaz
                         where z.Nazvanie_knigi.Contains(q)
                         select z);
            }
            ZakazDataGrid.ItemsSource = query.ToList();
            ZakazDataGrid.Items.Refresh();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Zakaz zakaz = ZakazDataGrid.SelectedItem as Zakaz;
            var StatusWindow = new StatusWindow(zakaz.ID_zakaza);
            StatusWindow.ShowDialog();
            ReloadZakaz();
        }

        private void ZakazSearchButton_Click(object sender, RoutedEventArgs e)
        {
            ReloadZakaz();
        }

        private void ZakazDataGrid_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddZakaz addZakaz = new AddZakaz();
            addZakaz.ShowDialog();
            ZakazDataGrid.ItemsSource = (from ZakazPage in App.DB.Zakaz
                                         select ZakazPage).ToList();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ZakazDataGrid.ItemsSource = (from ZakazPage in App.DB.Zakaz
                                         select ZakazPage).ToList();
        }

        private void edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                App.zakaz = ZakazDataGrid.SelectedItem as Мухутдинов.NewFolder1.Zakaz;
                AddZakaz addZakaz = new AddZakaz();
                addZakaz.ShowDialog();
                addZakaz.addBth.Content = "Редактировать";
                addZakaz.comboboxLocality24.Text = App.zakaz.Nazvanie_knigi;
                addZakaz.PriceField.Text = App.zakaz.Price;
                addZakaz.KolichestvoField.Text = App.zakaz.Kolichestvo;
                addZakaz.comboboxLocality25.Text = App.zakaz.Status;
            }
            catch { }
        }
         

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Zakaz ZakazRow = ZakazDataGrid.SelectedItem as Zakaz;
            Zakaz zakaz = (from z in App.DB.Zakaz
                           where z.ID_zakaza == ZakazRow.ID_zakaza
                           select z).Single();

            MessageBoxResult result = MessageBox.Show("Вы действительно хотите удалить это название?", "подтверждение",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                App.DB.Zakaz.Remove(zakaz);
                try
                {
                    App.DB.SaveChanges();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(
                        $"Произошла ошибка во время удаления: {exception.Message} Обычно, эта ошибка связана с тем,что данное образование был использован", "Ошибка удаления", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                ReloadZakaz();
            }
        }
    }
}
