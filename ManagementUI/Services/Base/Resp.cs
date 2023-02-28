using ManagementUI.Models.Product;

namespace ManagementUI.Services.Base
{
    public class Response<T>
    {
        public T? Data { get; set; }
        public string? Message { get; set; }
       // public string? ValidationErrors { get; set; }
        public string? Success { get; set; }

    }
}
