using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamShell.Clients
{
    public partial class NewClientPage : ContentPage
    {
        public NewClientPage()
        {
            InitializeComponent();

            BindingContext = new NewClientViewModel();
        }
           
    }
}
