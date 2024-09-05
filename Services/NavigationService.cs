using MarketplaceApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketplaceApp.Services;

public class NavigationService : INavigationService
{
    public async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    public async Task NavigateTo(string route, Dictionary<string, object> param = null)
    {
        var shellNavigation = new ShellNavigationState($"/{route}");

        if (param != null)
        {
            await Shell.Current.GoToAsync(shellNavigation, true, param);
            return;
        }
        await Shell.Current.GoToAsync(shellNavigation, true);
    }
}


