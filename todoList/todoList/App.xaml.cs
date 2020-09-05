using System;
using System.IO;
using todoList.Data;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace todoList
{
    public partial class App : Application
    {
        static Database database;
        public static Database Database
        {
            get
            {
                if (database == null)
                {
                    var dbName = "Person.db3";
                    var dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var connect = Path.Combine(dbpath, dbName);
                    database = new Database(connect);
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
