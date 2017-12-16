using MultiCultureCities.Core.FileDataManipulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCultureCities.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\aprakash\Desktop\CityDataReader\MissingCities_Translated.xlsx";
            ExcelFileReader excelFileReader = new ExcelFileReader(filePath);
            var citiesData = excelFileReader.ImportPointOfInterestDataFromExcel(filePath);
            ExcelExpoter excelExpoter = new ExcelExpoter();
            excelExpoter.ExportToExcel(citiesData);
        }
    }
}
