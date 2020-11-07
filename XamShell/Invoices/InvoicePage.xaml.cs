
using Xamarin.Forms;

namespace XamShell.Invoices
{
    public partial class InvoicePage : ContentPage
    {
        readonly InvoiceViewModel _viewModel;

        public InvoicePage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new InvoiceViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            _viewModel.OnAppearing();
        }
    }
}
