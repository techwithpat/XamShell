using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamShell.Clients;
using XamShell.Invoices;

[assembly: ExportFont("Montserrat.ttf", Alias = "Montserrat")]
namespace XamShell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

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
