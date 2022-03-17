using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App1.Services;
using App1.Views;
using App1.Data;
using System.IO;

namespace App1
{
    public partial class App : Application
    {
        static Banco banco;

        public static Banco Banco
        {
            get
            {
                if (banco == null)
                {
                    banco = new Banco(
                        Path.Combine(
                            Environment.GetFolderPath(
                                Environment
                                .SpecialFolder
                                .LocalApplicationData)
                            ,"Computador.db3"
                        )
                    );
                }
                return banco;
            }
        }


        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
