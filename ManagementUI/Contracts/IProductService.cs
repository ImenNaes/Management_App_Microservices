using ManagementUI.Models.Models;
using ManagementUI.Services.Base;

namespace ManagementUI.Contracts
{
    public interface IProductService
    {
        Task<List<ProductVM>> GetProducts();
        Task<Resp<Guid>> AddProduct(ProductVM product); 
    }
}
