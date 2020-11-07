
using Xamarin.Forms;

namespace XamShell.Clients
{
    public partial class ClientPage : ContentPage
    {
        ClientViewModel _viewModel;

        public ClientPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ClientViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
