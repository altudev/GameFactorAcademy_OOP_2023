using GFA.Crawler.Domain.Entities;

namespace GFA.Crawler.Application.Models
{
    public class ProductCrawlerResponseDto
    {
        public byte[] ExcelFile { get; set; }
        public string ExcelFilePath { get; set; }

        public int TotalCount { get; set; }
        public int OnSaleCount { get; set; }
        public int SaleCount { get; set; }

        public List<Product> Products { get; set; }
    }
}
