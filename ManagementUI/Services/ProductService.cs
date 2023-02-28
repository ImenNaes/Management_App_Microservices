using AutoMapper;
using ManagementUI.Contracts;
using ManagementUI.Models.Product;
using System.Text.Json;
using Management.ManagementUI.Services.Base;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Data;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using Management.ManagementUI.Services.Base;
using Management.ManagementUI.Services.Base.BaseHttpService;

namespace ManagementUI.Services
{
    public class ProductService : BaseHttpService ,IProductService
    {
        private readonly IMapper _mapper;
        private readonly IClient _client;   

        public List<ProductVM>? Resp_products { get; set; }

        public ProductService(IClient client, IMapper mapper) : base(client)
        {
            _mapper = mapper;
            _client= client;    
        }


        public async Task<List<ProductVM>> GetProducts()
        {
            var result = await _client.ProductsAllAsync();
            var products= _mapper.Map<List<ProductVM>>(result);   
            return products;
        }
      
        async Task<int> IProductService.AddProduct(ProductVM product)
        {
            //await _client.ProductsPOSTAsync(product);

            var v = 0;
            return v;
        }
   
        public async Task<int> UpdateProduct(int idproduct, ProductVM product)
        {
            //var productbyid =await _client.PutAsJsonAsync("api/Products", idproduct);
            return 0;
        }

        public async Task<ProductVM> GetProductById(int idproduct)
        {
            var product = await _client.ProductsGETAsync(idproduct);
            var productbyid= _mapper.Map<ProductVM>(product);    
            return productbyid;
        }

        public async Task<int> DeleteProduct(int idproduct)
        {
            var prodtoDelete= await _client.ProductsGETAsync(idproduct);
            await _client.ProductsDELETEAsync(idproduct);
            return idproduct;
        }
    }
}
