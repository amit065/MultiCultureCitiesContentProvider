using MultiCultureCities.Core.FileDataManipulation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCultureCities.Console
{
    class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Reading Point Of Interest Coordinates data from file.....");

            var files = Directory.GetFiles(Directory.GetCurrentDirectory(), "MissingCities_Translated.xlsx");

            var filePath = files[0];

            ExcelFileReader excelFileReader = new ExcelFileReader(filePath);

            var citiesData = excelFileReader.ImportPointOfInterestDataFromExcel(filePath);

            //Console.WriteLine();

            //Console.WriteLine("Reading Data From File Is Completed ");

            ExcelExpoter excelExpoter = new ExcelExpoter();

            excelExpoter.ExportToExcel(citiesData);

            //Console.WriteLine();

            //Console.WriteLine("Exporting To Excel File");
        }
    }
}
