namespace GFA.Crawler.Domain.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal? SalePrice { get; set; }
        public bool IsOnSale { get; set; }
        public string ImagePath { get; set; }

        public Product()
        {
            Id = Guid.NewGuid();
        }

    }
}
