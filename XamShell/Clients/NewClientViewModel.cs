using System;
using System.Windows.Input;
using Xamarin.Forms;
using XamShell.Common;

namespace XamShell.Clients
{
    public class NewClientViewModel : BaseViewModel
    {
        public NewClientViewModel()
        {            
            CancelCommand = new Command(async () =>
            {
                await Shell.Current.GoToAsync("..");
            });
        }

        public ICommand CancelCommand { get; }
    }
}
