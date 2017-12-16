using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiCultureCities.Core.FileDataManipulation;

namespace MultiCultureCities.Core.Test
{
    [TestClass]
    public class ExcelFileManipulatorTest
    {
        [TestMethod]
        public void ExcelFileManipulator_Should_Return_Full_Text_Search()
        {
            var cityName = "Mumbai";
            var IataCityCode = "MUM";
            var fullTextSearch = "MUM mum mumb mumba mumbai";
            ExcelFileManipulator excelFileManipulator = new ExcelFileManipulator();
            var generatedFullTextSearch = excelFileManipulator.GetFullTextSearch(cityName, IataCityCode);
            Assert.AreEqual(fullTextSearch, generatedFullTextSearch);
        }

        [TestMethod]
        public void ExcelFileManipulator_Should_Return_Full_Text_Search_For_More_Than_One_Word_CityName()
        {
            var cityName = "Santa Maria";
            var IataCityCode = "SMX";
            var fullTextSearch = "SMX san sant santa mar mari maria";
            ExcelFileManipulator excelFileManipulator = new ExcelFileManipulator();
            var generatedFullTextSearch = excelFileManipulator.GetFullTextSearch(cityName, IataCityCode);
            Assert.AreEqual(fullTextSearch, generatedFullTextSearch);
        }
    }
}
