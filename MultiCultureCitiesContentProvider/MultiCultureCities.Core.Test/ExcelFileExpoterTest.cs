using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiCultureCities.Core.FileDataManipulation;
using MultiCultureCities.Model;
using System.Collections.Generic;

namespace MultiCultureCities.Core.Test
{
    [TestClass]
    public class ExcelFileExpoterTest
    {
        [TestMethod]
        public void ExcelFileExporter_Should_Save_File_In_Excel()
        {
            string filePath = @"E:\MultiCultureCities\MultiCultureCitiesContentProvider\MultiCultureCitiesContentProvider\MultiCultureCities.Console\bin\Debug\MissingCities_Translated.xlsx";
            ExcelFileReader excelFileReader = new ExcelFileReader(filePath);
            List<City> cities = excelFileReader.ImportCitiesDataExcel(filePath);
            ExcelFileExpoter excelFileExpoter = new ExcelFileExpoter();
            var result = excelFileExpoter.ExportToExcel(cities);
            Assert.AreEqual(true, result);

        }
    }
}