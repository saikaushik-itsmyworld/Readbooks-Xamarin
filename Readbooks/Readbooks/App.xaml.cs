using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Readbooks.Services;
using Readbooks.Views;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace Readbooks
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            AppCenter.Start("ios=5404f2e7-a091-414b-bfa8-8c3f0195feac;android=05697554-02d1-4f07-b442-e55fcec1fd77", typeof(Analytics), typeof(Crashes));

        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
