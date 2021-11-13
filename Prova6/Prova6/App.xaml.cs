using Prova6.Services;
using Prova6.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Prova6
{
    public partial class App : Application
    {
        static EsercizioService _esercizioService;
        public static EsercizioService EsercizioService
        {
            get
            {
                if(_esercizioService == null)
                {
                    _esercizioService = new EsercizioService(Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Esercizio.db3"));
                }
                return _esercizioService;
            }
        }

        public App()
        {
            InitializeComponent();
            
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
