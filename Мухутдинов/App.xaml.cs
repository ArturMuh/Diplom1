using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Мухутдинов.NewFolder1;

namespace Мухутдинов
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Diplom_Мухутдинов1Entities1 DB;
        public static Biblioteka currentUser;
        public static Zakaz zakaz;
        public static MainWindow mainWindow;

        public static object CurrentUser { get; internal set; }
        public static object HeaderFrame { get; internal set; }
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            DB = new Diplom_Мухутдинов1Entities1();
        }
    }
}
