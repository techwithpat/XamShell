using System;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamShell.Clients
{
    public class ClientSearchHandler : SearchHandler
    {
        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);

            ItemsSource = string.IsNullOrWhiteSpace(newValue)
                ? null
                : FakeClientStore.Clients.Where(
                    c => c.Name.ToLower().Contains(newValue.ToLower()));
        }

        protected override async void OnItemSelected(object item)
        {
            base.OnItemSelected(item);

            var uri = $"{nameof(ClientDetailPage)}?" +
                $"{nameof(ClientDetailViewModel.ClientName)}={((Client)item).Name}";

            await Task.Delay(500);

            await Shell.Current.GoToAsync(uri);
        }
    }
}
