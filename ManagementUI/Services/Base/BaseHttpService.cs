using Management.ManagementUI.Services.Base;

namespace ManagementUI.Services.Base
{
    public class BaseHttpService
    {
        protected IClient _client;
        public BaseHttpService(IClient client)
        {
            _client = client;
        }
    }

}
