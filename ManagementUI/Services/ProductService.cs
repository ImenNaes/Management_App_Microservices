using AutoMapper;
using ManagementUI.Contracts;
using ManagementUI.Models.Models;
using ManagementUI.Services.Base;
using System.Text.Json;
using Management.ManagementUI.Services.Base;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Data;
using System.Net;
using Newtonsoft.Json;

namespace ManagementUI.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly HttpClient _client;

        public ProductService(HttpClient client) 
        {
            this._client = client;
        }

        //public ProductService(IClient client, IMapper mapper): base(client)
        //public ProductService(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}

        
        public async Task<List<ProductVM>> GetProducts()
        {
            var apiName = "api/Products";
            var httpResponse = await _client.GetAsync(apiName);
            var prods= new List<ProductVM>();   
            if (httpResponse.IsSuccessStatusCode)
            {
                Response responseData = JsonConvert.DeserializeObject<Response>(await httpResponse.Content.ReadAsStringAsync());
                prods= responseData.RespServerProducts;
            }
            return prods;

        }

        Task<Resp<Guid>> IProductService.AddProduct(ProductVM product)
        {
            throw new NotImplementedException();
        }
    }
}
