using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamShell.Common;

namespace XamShell.Invoices
{
    public class InvoiceViewModel : BaseViewModel
    {
        private ObservableCollection<Invoice> invoices;

        public InvoiceViewModel()
        {
            Invoices = new ObservableCollection<Invoice>();

            LoadInvoicesCommand = new Command(async () => await ExecuteLoadCommand());
        }
               
        private async void OnAddInvoice(object obj)
        {
            Console.WriteLine("On Add Invoice");

            await Task.FromResult(true);
        }

        private async Task ExecuteLoadCommand()
        {
            IsBusy = true;

            try
            {
                Invoices.Clear();

                var invoices = await Task.FromResult(FakeInvoiceStore.Invoices);
                foreach (var invoice in invoices)
                {
                    Invoices.Add(invoice);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }

        internal void OnAppearing() => IsBusy = true;

        public ICommand LoadInvoicesCommand { get; }
       
        public ObservableCollection<Invoice> Invoices
        {
            get => invoices;
            set => SetProperty(ref invoices, value);
        }

        public Command<Invoice> InvoiceTappedCommand { get; }
    }
}
