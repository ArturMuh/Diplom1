using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для AddZakaz.xaml
    /// </summary>
    public partial class AddZakaz : Window
    {
        StringBuilder errors = new StringBuilder();
        public AddZakaz()
        {
            InitializeComponent();
            ReloadKnigi();
            ReloadZakaz();
            ReloadStatus();
        }

        public delegate void RefreshList();
        public event RefreshList RefreshListEvent;
        public void ReloadKnigi()
        {
            comboboxLocality24.ItemsSource = App.DB.Knigi.ToList();
            comboboxLocality24.Items.Refresh();
        }

        public void ReloadStatus()
        {
            comboboxLocality25.ItemsSource = App.DB.Status.ToList();
            comboboxLocality25.Items.Refresh();
        }

        private void Proverka()
        {
            if (PriceField.Text.Length == 0)
                errors.AppendLine("Поле цена не должно быть пустым;");
        }

        private void addBth_Click(object sender, RoutedEventArgs e)
        {
            if (addBth.Content.ToString() == "Изменить")
            {
                Proverka();
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString()
                        , "Ошибка при проверке данных на соответствие", MessageBoxButton.OK, MessageBoxImage.Error);
                    errors.Clear();
                }
                else
                {
                    try
                    {
                        var item = App.zakaz;
                        item.Nazvanie_knigi = $@"{comboboxLocality24.Text}";
                        item.Date_zakaza = DatezakazayaField.SelectedDate.Value;
                        item.Price = PriceField.Text;
                        item.Kolichestvo = KolichestvoField.Text;
                        item.Status = $@"{comboboxLocality25.Text}";
                        MessageBox.Show("Изменение прошло успешно", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                        App.DB.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
            }
            else
            {
                Proverka();
                if (errors.Length > 0)
                {
                    MessageBox.Show(errors.ToString(), "Ошибка при проверке данных на соответствие", MessageBoxButton.OK, MessageBoxImage.Error);
                    errors.Clear();
                }
                else
                {

                    try
                    {
                        var Zakaz = new Zakaz();

                        Zakaz.ID_zakaza = App.DB.Zakaz.Local.Last().ID_zakaza + 1;
                        Zakaz.Nazvanie_knigi = $@"{comboboxLocality24.Text}";
                        Zakaz.Date_zakaza = DatezakazayaField.SelectedDate.Value;
                        Zakaz.Price = PriceField.Text;
                        Zakaz.Kolichestvo = KolichestvoField.Text;
                        Zakaz.Status = $@"{comboboxLocality25.Text}";
                        App.DB.Zakaz.Add(Zakaz);
                        App.DB.SaveChanges();
                        ReloadZakaz();
                        this.Close();
                        MessageBox.Show("Поле добавлено", "Успешно", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка", "Ошибка добавления");
                    }
                }
            }
        }

        private void ReloadZakaz()
        {
            
        }

        private void PriceField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        private void KolichestvoField_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }
    }
}
