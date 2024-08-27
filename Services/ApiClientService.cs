using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketplaceApp.Model;

namespace MarketplaceApp.Services
{
    public class ApiClientService : IApiClientService
    {
        public const string URLBase = "https://fakestoreapi.com/";
        public RestClient client;

        public ApiClientService()
        {
            var options = new RestClientOptions(URLBase);
            client = new RestClient(options);
        }

        public async Task<RestResponse<List<StoreProductResponse>>> GetProducts()
        {
            var request = new RestRequest("products");
            var restResponse = await client.ExecuteGetAsync<List<StoreProductResponse>>(request);

            return restResponse;
        }

        public async Task<RestResponse<List<string>>> GetCategories()
        {
            var request = new RestRequest("products/categories");
            var restResponse = await client.ExecuteGetAsync<List<string>>(request);

            return restResponse;
        }
    }
}
