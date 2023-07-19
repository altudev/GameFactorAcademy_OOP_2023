using GFA.Crawler.Application.Interfaces;
using GFA.Crawler.Application.Models;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using GFA.Crawler.Domain.Entities;

namespace GFA.Crawler.ConsoleClient.Services
{
    public class ProductCrawlerConsoleManager : IProductCrawlerService
    {
        private readonly IWebDriver _driver;

        public ProductCrawlerConsoleManager()
        {
            new DriverManager().SetUpDriver(new FirefoxConfig());

            _driver = new FirefoxDriver();
        }

        public ProductCrawlerResponseDto Crawl()
        {
            var urlToCrawl = "https://4teker.net";

            _driver.Navigate();

            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

            _driver.Navigate().GoToUrl(urlToCrawl);

            Thread.Sleep(500);

            // Selecting Product Divs
            // col mb-5

            var productDivs = _driver.FindElements(By.CssSelector(".card.h-100"));

            List<Product> products = new ();

            foreach (var productDiv in productDivs)
            {
                var product = new Product();

                // Select OnSaleDiv

                var onSaleDivElements = productDiv.FindElements(By.CssSelector(".onsale"));

                if (onSaleDivElements is not null && onSaleDivElements.Any())
                {
                    product.IsOnSale = true;

                    var salePriceSpan = productDiv.FindElement(By.CssSelector(".sale-price"));

                    // Selecting sale price

                    var salePriceText = salePriceSpan.Text;

                    salePriceText = salePriceText
                        .Replace("$", string.Empty)
                        .Replace(",", ".");

                    product.SalePrice = Convert.ToDecimal(salePriceText);
                }

                // Selecting Product Name

                var productNameH5 = productDiv.FindElement(By.CssSelector(".product-name"));

                product.Name = productNameH5.Text;

                // Selecting Price Span

                var priceSpan = productDiv.FindElement(By.CssSelector(".price"));

                var priceText = priceSpan.Text
                    .Replace("$", string.Empty)
                    .Replace(",", ".");

                product.Price = Convert.ToDecimal(priceText);

                // Selecting Image

                var productImg = productDiv.FindElement(By.TagName("img"));

                product.ImagePath = productImg.GetAttribute("src");

                products.Add(product);

            }

            Thread.Sleep(500);

            _driver.Quit();

            return new ProductCrawlerResponseDto(products);
        }

        public string CheckGooglePage()
        {
            _driver.Navigate();

            return string.Empty;
        }
    }
}
