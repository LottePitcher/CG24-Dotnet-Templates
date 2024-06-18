using AcmeUmbracoStarter.Models.PublishedModels;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace AcmeUmbracoStarter.Models.ViewModels
{
    public class HomeViewModel : Home
    {
        public HomeViewModel(IPublishedContent content, IPublishedValueFallback publishedValueFallback) : base(content, publishedValueFallback)
        {
        }
    }
}
