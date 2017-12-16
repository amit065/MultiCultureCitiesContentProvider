using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiCultureCities.Core.FileDataManipulation;
using MultiCultureCities.Core.ScriptGenerator;

namespace MultiCultureCities.Core.Test
{
    [TestClass]
    public class ScriptGeneratorTest
    {
        [TestMethod]
        public void Script_Generator_Should_Generate_Insert_Script_For_Cities()
        {
            string filePath = @"E:\MultiCultureCities\MultiCultureCitiesContentProvider\MultiCultureCitiesContentProvider\MultiCultureCities.Console\bin\Debug\MissingCities_Translated.xlsx";
            ExcelFileReader excelFileReader = new ExcelFileReader(filePath);
            var cities = excelFileReader.ImportCitiesDataExcel(filePath);
            ScriptGeneratorUS scriptGeneratorUS = new ScriptGeneratorUS();
            Assert.ThrowsException<Exception>(() => scriptGeneratorUS.GenerateInsertScript(cities));

        }
    }
}
