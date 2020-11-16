using ColegioApp.Data;
using ColegioApp.DependencyServices;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColegioApp
{
    public partial class App : Application
    {
        private static AlumnoDataBase database;

        public static AlumnoDataBase Database
        {
            get 
            {
                if(database == null)
                {
                    database = new AlumnoDataBase(DependencyService.Get<IFileHelper>().GetLocalFilePath("alumnosdb.db3"));
                }
                return database; 
            }
            set { database = value; }
        }



        public App()
        {
            InitializeComponent();            
            MainPage = new NavigationPage(new LoginPage());

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
