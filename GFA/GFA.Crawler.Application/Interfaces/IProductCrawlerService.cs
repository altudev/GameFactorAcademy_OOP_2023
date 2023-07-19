using GFA.Crawler.Application.Models;

namespace GFA.Crawler.Application.Interfaces
{
    public interface IProductCrawlerService
    {
        ProductCrawlerResponseDto Crawl();
        string CheckGooglePage();
    }
}
