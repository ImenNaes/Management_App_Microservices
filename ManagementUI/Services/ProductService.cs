using AutoMapper;
using ManagementUI.Contracts;
using ManagementUI.Models.Models;
using ManagementUI.Services.Base;
using System.Text.Json;

namespace ManagementUI.Services
{
   // public class ProductService : BaseHttpService, IProductService
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        private readonly JsonSerializerOptions _options;
        private readonly IMapper _mapper;
        public ProductService(HttpClient client, IMapper mapper)
        {
            _client = client;
            _options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            _mapper = mapper;
        }

        public Task<Response<Guid>> AddProduct(ProductVM product)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductVM>> GetProducts()
        {
            var response = await _client.GetAsync("products");
            var content = await response.Content.ReadAsStringAsync();
            if (!response.IsSuccessStatusCode)
            {
                throw new ApplicationException(content);
            }
            var products = JsonSerializer.Deserialize<List<ProductVM>>(content, _options);
            var productsList = _mapper.Map<List<ProductVM>>(products);   
            return productsList;
        }
    }
}
