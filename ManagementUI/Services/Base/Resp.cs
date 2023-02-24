using ManagementUI.Models.Models;

namespace ManagementUI.Services.Base
{
    public class Resp<T>
    {
        public string? Message { get; set; }
        public string? ValidationErrors { get; set; }
        public string? Success { get; set; }
        public T? Data { get; set; }
        public List<ProductVM>? Resp_products { get; set; }

    }
}
