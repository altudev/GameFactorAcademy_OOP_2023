using GFA.Crawler.Domain.Entities;

namespace GFA.Crawler.Application.Models
{
    public class ProductCrawlerResponseDto
    {
        public int OnSaleCount => Products.Count(p => p.IsOnSale);
        public int SaleCount => Products.Count(p => p.IsOnSale == false);
        public int ExpensiveCount => Products
            .Where(p => p.IsOnSale == false)
            .Where(p=> p.Price > 500)
            .Count();
        public int ExpensiveOrMoreThan500Count => Products.Count(p => p.IsOnSale == false || p.Price <= 500);

        public List<Product> Products { get; set; }

        public ProductCrawlerResponseDto()
        {
            Products = new List<Product>();
        }

        public ProductCrawlerResponseDto(List<Product> products)
        {
            Products = products;
        }
    }
}
