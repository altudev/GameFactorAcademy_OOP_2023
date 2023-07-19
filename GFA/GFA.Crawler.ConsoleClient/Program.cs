using GFA.Crawler.Application.Interfaces;
using GFA.Crawler.Application.Services;
using GFA.Crawler.ConsoleClient.Services;

Console.BackgroundColor = ConsoleColor.Green;

Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Uygulama başladı.");

Console.WriteLine("--------------------------------------");

IProductCrawlerService crawlerService = new ProductCrawlerConsoleManager();

var response = crawlerService.Crawl();

Console.WriteLine("Kazıma işlemi başarıyla tamamlandı.");

Console.WriteLine("--------------------------------------");

Console.WriteLine($"Toplamda kazınan ürün sayısı:{response.Products.Count}");

Console.WriteLine("--------------------------------------");

Console.WriteLine($"İndirimdeki ürünlerin sayısı:{response.OnSaleCount}");

Console.WriteLine("--------------------------------------");

Console.WriteLine($"İndirimsiz ürünlerin sayısı:{response.SaleCount}");

IExcelService excelService = new ExcelManager();

var excelFile = excelService.CreateProductsFile(response.Products);

excelService.SaveFile(excelFile,Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"products.xlsx"));

Console.ReadLine();


