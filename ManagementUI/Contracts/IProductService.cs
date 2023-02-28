using ManagementUI.Models.Product;
using ManagementUI.Services.Base;

namespace ManagementUI.Contracts
{
    public interface IProductService
    {
        public List<ProductVM>? Resp_products { get; set; }
        Task<List<ProductVM>> GetProducts();
        Task<int> AddProduct(ProductVM product);
        Task<int> UpdateProduct(int idproduct, ProductVM product);
        Task<ProductVM> GetProductById(int idproduct);
        Task<int> DeleteProduct(int idproduct);

    }
}
