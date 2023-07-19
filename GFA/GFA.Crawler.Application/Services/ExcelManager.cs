using ClosedXML.Excel;
using GFA.Crawler.Application.Interfaces;
using GFA.Crawler.Domain.Entities;

namespace GFA.Crawler.Application.Services
{
    public class ExcelManager:IExcelService
    {
        public byte[] CreateProductsFile(List<Product> products)
        {
            using (var workbook = new XLWorkbook())
            {
                // General Info & Settings
                workbook.Properties.Author = "Hacked By Alper Tunga";
                workbook.Properties.Title = "Crawled Products";
                workbook.Properties.Subject = "Crawled Products";

                // Worksheet Settings
                var worksheet = workbook.Worksheets.Add("Products");

                worksheet.ColumnWidth = 20;

                // Table Headers

                for (int i = 1; i <= 6; i++)
                {
                    worksheet.Cell(1, i).Style.Font.Bold = true;
                    worksheet.Cell(1, i).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    worksheet.Cell(1, i).Style.Fill.SetBackgroundColor(XLColor.BlueGray);
                }

                worksheet.Cell(1, 1).Value = "ID";

                worksheet.Cell(1, 2).Value = "Name";

                worksheet.Cell(1, 3).Value = "Is On Sale";

                worksheet.Cell(1, 4).Value = "Price";

                worksheet.Cell(1, 5).Value = "Sale Price";

                worksheet.Cell(1, 6).Value = "Image Path";

                worksheet.Column(1).Width = 60;

                worksheet.Column(6).Width = 60;

                var rowIndex = 2;

                foreach (var product in products)
                {
                    worksheet.Cell(rowIndex, 1).Value = product.Id.ToString();

                    worksheet.Cell(rowIndex, 2).Value = product.Name;

                    worksheet.Cell(rowIndex, 3).Value = product.IsOnSale.ToString();

                    worksheet.Cell(rowIndex, 3).Style.Fill.BackgroundColor = product.IsOnSale ? XLColor.Green : XLColor.Red;

                    worksheet.Cell(rowIndex, 4).Value = product.Price.ToString("C");

                    worksheet.Cell(rowIndex, 5).Value = product.SalePrice.HasValue
                        ? product.SalePrice.Value.ToString("C") : "Not on sale";

                    worksheet.Cell(rowIndex, 5).Style.Fill.BackgroundColor = product.SalePrice.HasValue ? XLColor.Green : XLColor.Red;

                    worksheet.Cell(rowIndex, 6).Value = product.ImagePath;

                    rowIndex++;
                }

                var firstCell = worksheet.FirstCellUsed();
                var lastCell = worksheet.LastCellUsed();

                var range = worksheet.Range(firstCell.Address, lastCell.Address);

                range.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;

                var table = range.CreateTable();

                using (var memoryStream = new MemoryStream())
                {
                    workbook.SaveAs(memoryStream);

                    return memoryStream.ToArray();
                }
            }
        }

        public void SaveFile(byte[] excelFile, string savePath)
        {
            using (FileStream stream = new FileStream(savePath,FileMode.Create))
            {
                stream.Write(excelFile);
            }
        }

        //private void CreateStyledCell(int row, int column, XLDataType dataType, ref IXLWorksheet worksheet)
        //{
        //    worksheet.Cell(row, column).DataType = dataType;
        //}
    }
}
