using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiCultureCities.Core.FileDataManipulation;

namespace MultiCultureCities.Core.Test
{
    [TestClass]
    public class ExcelFileReaderTest
    {
        [TestMethod]
        public void Reader_Should_Give_File_When_Found()
        {

            string filePath = @"E:\MultiCultureCities\MultiCultureCitiesContentProvider\MultiCultureCitiesContentProvider\MultiCultureCities.Console\bin\Debug\MissingCities_Translated.xlsx";
            ExcelFileReader excelFileReader = new ExcelFileReader(filePath);
            var cities = excelFileReader.ImportCitiesDataExcel(filePath);
            var city = cities[0];
            var cityName = city.CityName;
            Assert.AreEqual("Acoma", cityName);

        }

        [TestMethod]
        public void Reader_Should_Throw_Exception_When_File_Not_Found()
        {
            string filePath = @"E:\MultiCultureCitie\MultiCultureCitiesContentProvider\MultiCultureCitiesContentProvider\MultiCultureCities.Console\bin\Debug\MissingCities_Translated.xlsx";
            ExcelFileReader excelFileReader = new ExcelFileReader(filePath);
            Assert.ThrowsException<Exception>(() => excelFileReader.ImportCitiesDataExcel(filePath));
        }
    }
}
