using Microsoft.Maui.Controls;
using MarketplaceApp.Model;

namespace MarketplaceApp.Selectors
{
    public class ProductTemplateSelector : DataTemplateSelector
    {
        public DataTemplate BlackFridayTemplate { get; set; }
        public DataTemplate NormalTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as StoreProductResponse;
            if (product == null)
                return NormalTemplate; 

            return product.Blackfriday ? BlackFridayTemplate : NormalTemplate;
        }
    }
}
