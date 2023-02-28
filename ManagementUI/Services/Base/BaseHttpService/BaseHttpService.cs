using Management.ManagementUI.Services.Base;

namespace Management.ManagementUI.Services.Base.BaseHttpService
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
