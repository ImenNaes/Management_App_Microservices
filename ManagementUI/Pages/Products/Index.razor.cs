using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using ManagementUI;
using ManagementUI.Shared;
using ManagementUI.Contracts;
using ManagementUI.Models.Product;
using System.Net.Http.Headers;
using ManagementUI.Services;

namespace ManagementUI.Pages.Products
{
    public partial class Index
    {
        [Inject]
        public NavigationManager? NavigationManager { get; set; }
        [Inject]    
        public IProductService? productService { get; set; } 

        public List<ProductVM>? Products { get; private set; } 

        public string Message { get; set; } = string.Empty;

        [Parameter]
        public int productid { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = await productService.GetProducts();
        }

        public void CreateProduct()
        {
            NavigationManager?.NavigateTo("/Create");
        }
        protected void EditProduct(int Id)
        {
            NavigationManager.NavigateTo("/Update");
         //   NavigationManager.NavigateTo($"/Update/{Id}");
        }

        protected async void DeleteProduct(int Id) 
        {
            var respone = await productService.DeleteProduct(Id);
            //if (respone.success) 
            //{ 
            //    //Reload itself (Reload the component)
            //    StateHasChanged();
            //}
            //else
            //{
            //    Message = respone.Message;
            //}
        }
    }
}