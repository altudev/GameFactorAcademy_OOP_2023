using GFA.Crawler.Domain.Entities;

namespace GFA.Crawler.Application.Interfaces
{
    public interface IExcelService
    {
        byte[] CreateProductsFile(List<Product> products);
        void SaveFile(byte[] excelFile, string savePath);
    }
}
