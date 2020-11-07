using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamShell.Clients
{
    public partial class ClientDetailPage : ContentPage
    {
        public ClientDetailPage()
        {
            InitializeComponent();

            BindingContext = new ClientDetailViewModel();
        }

    }
}
