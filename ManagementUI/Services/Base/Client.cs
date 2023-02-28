
using Management.ManagementUI.Services.Base;
using System.Net.Http;

namespace Management.ManagementUI.Services.Base
{
    public partial class Client: IClient
    {
        public HttpClient HttpClient
        {
            get
            {
                return _httpClient;
            }
        }
    }
}
