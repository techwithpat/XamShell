using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Xamarin.Forms;
using XamShell.Common;

namespace XamShell.Clients
{
    [QueryProperty(nameof(ClientName), nameof(ClientName))]
    public class ClientDetailViewModel : BaseViewModel
    {
        private string name;
        private string phone;
        private string email;
        private string clientName;

        public ClientDetailViewModel()
        {
        }

        public async void LoadClient(string name)
        {
            try
            {
                var client = await Task.FromResult(FakeClientStore.Clients.FirstOrDefault(c => c.Name == name));

                Name = client.Name;
                Phone = client.PhoneNumber;
                Email = client.Email;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load client");
            }
        }

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public string Phone
        {
            get => phone;
            set => SetProperty(ref phone, value);
        }

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }

        public string ClientName
        {
            get => clientName;
            set
            {
                clientName = value;
                LoadClient(HttpUtility.UrlDecode(clientName));
            }
        }
    }
}
