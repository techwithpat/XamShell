using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using XamShell.Settings;
using XamShell.Clients;

namespace XamShell
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = this;

            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(NewClientPage), typeof(NewClientPage));
            Routing.RegisterRoute(nameof(ClientDetailPage), typeof(ClientDetailPage));
        }

        public ICommand SettingsCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync("SettingsPage");
        });

        public ICommand HelpCommand => new Command(async () =>
        {
            var uri = "https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/shell";
            await Browser.OpenAsync(uri, BrowserLaunchMode.SystemPreferred);
        });
    }
}
