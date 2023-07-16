using GFA.Crawler.Domain.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

Console.WriteLine("Uygulama başladı.");

new DriverManager().SetUpDriver(new FirefoxConfig());

IWebDriver driver = new FirefoxDriver();

driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(1000);

driver.Navigate().GoToUrl("https://4teker.net");

Thread.Sleep(500);

// Selecting Product Divs
// col mb-5

var productDivs = driver.FindElements(By.CssSelector(".card.h-100"));


foreach (var productDiv in productDivs)
{
    var product = new Product();

    // Select OnSaleDiv

    var onSaleDiv = productDiv.FindElement(By.CssSelector(".onsale"));

    if (onSaleDiv is not null)
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

}

Thread.Sleep(500);

var submitButton = driver.FindElement(By.ClassName("gNO89b"));

submitButton.Click();

Thread.Sleep(7500);

driver.Quit();