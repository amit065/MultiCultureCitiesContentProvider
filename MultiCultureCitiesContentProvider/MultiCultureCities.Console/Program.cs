using MultiCultureCities.Core.FileDataManipulation;
using MultiCultureCities.Core.ScriptGenerator;
using System.IO;

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

            var citiesData = excelFileReader.ImportCitiesDataExcel(filePath);

            //Console.WriteLine();

            //Console.WriteLine("Reading Data From File Is Completed ");

            ExcelFileExpoter excelExpoter = new ExcelFileExpoter();

            excelExpoter.ExportToExcel(citiesData);

            //Console.WriteLine();

            //Console.WriteLine("Exporting To Excel File");

            //Console.WriteLine();

            //Console.WriteLine("Generating Insert Script For Different Culture");

            ScriptGeneratorUS scriptGeneratorUS = new ScriptGeneratorUS();

            scriptGeneratorUS.GenerateInsertScript(citiesData);

            ScriptGeneratorUK scriptGeneratorUK = new ScriptGeneratorUK();

            scriptGeneratorUK.GenerateInsertScript(citiesData);

            ScriptGeneratorTH scriptGeneratorTH = new ScriptGeneratorTH();

            scriptGeneratorTH.GenerateInsertScript(citiesData);

            ScriptGeneratorMX scriptGeneratorMX = new ScriptGeneratorMX();

            scriptGeneratorMX.GenerateInsertScript(citiesData);

            ScriptGeneratorCO scriptGeneratorCO = new ScriptGeneratorCO();

            scriptGeneratorCO.GenerateInsertScript(citiesData);

            ScriptGeneratorChinese scriptGeneratorChinese = new ScriptGeneratorChinese();

            scriptGeneratorChinese.GenerateInsertScript(citiesData);

            ScriptGeneratorBR scriptGeneratorBR = new ScriptGeneratorBR();

            scriptGeneratorBR.GenerateInsertScript(citiesData);
        }
    }
}
