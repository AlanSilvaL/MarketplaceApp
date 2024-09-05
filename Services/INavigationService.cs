
namespace MarketplaceApp.Services
{
    public interface INavigationService
    {
        Task GoBack();
        Task NavigateTo(string route, Dictionary<string, object> param = null);
    }
}