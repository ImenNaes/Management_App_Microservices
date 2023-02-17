using System.Net.Http;
using Management.ManagementUI.Services.Base;
using ManagementUI.Services.Base;

namespace ManagementUI.Services.Base
{
    public partial class Client : IClient
    {
        private HttpClient _httpClient;

        public HttpClient HttpClient => _httpClient;


    }
}
