using MarketplaceApp.Model;
using RestSharp;

namespace MarketplaceApp.Services
{
    public interface IApiClientService
    {
        Task<RestResponse<List<string>>> GetCategories();
        Task<RestResponse<List<StoreProductResponse>>> GetProducts();
    }
}