using MultiCultureCities.Core.FileDataManipulation;
using MultiCultureCities.Core.Logger;
using MultiCultureCities.Core.ScriptGenerator;
using System;
using System.IO;

namespace MultiCultureCities.Host
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Reading Point Of Interest Coordinates data from file.....");

                string filePath = string.Format(@"{0}\..", Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));

                var files = Directory.GetFiles(filePath + @"\MultiCultureCities.Core\SolutionFile\InputFile\", @"MissingCities_Translated.xlsx");

                ExcelFileReader excelFileReader = new ExcelFileReader(files[0]);

                var citiesData = excelFileReader.ImportCitiesDataExcel(files[0]);

                Console.WriteLine();

                Console.WriteLine("Reading Data From File Is Completed ");

                ExcelFileExpoter excelExpoter = new ExcelFileExpoter();

                excelExpoter.ExportToExcel(citiesData);

                Console.WriteLine();

                Console.WriteLine("Exporting To Excel File");

                Console.WriteLine();

                Console.WriteLine("Generating Insert Script For Different Culture");

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
            catch (Exception ex)
            {
                Log.LogException(ex);

                Console.WriteLine("Exception Related To Hosting :" + ex.Message + "\t" + ex.GetType());

                Console.ReadKey();
            }
        }
    }
}
