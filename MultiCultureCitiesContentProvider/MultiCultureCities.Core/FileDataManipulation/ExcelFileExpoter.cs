using MultiCultureCities.Core.Logger;
using MultiCultureCities.Model;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace MultiCultureCities.Core.FileDataManipulation
{
    public class ExcelFileExpoter
    {
        public bool ExportToExcel(List<City> cities)
        {
            // Load Excel application
            Excel.Application excel = new Excel.Application();

            // Load Excel application
            excel.Workbooks.Add();

            // Create Worksheet from active sheet
            Excel._Worksheet workSheet = excel.ActiveSheet;

            // I created Application and Worksheet objects before try/catch,
            // so that i can close them in finnaly block.
            // It's IMPORTANT to release these COM objects!!
            try
            {
                // Creation of header cells
                workSheet.Cells[1, "A"] = "CityName";
                workSheet.Cells[1, "B"] = "StateCode";
                workSheet.Cells[1, "C"] = "CountryCode";
                workSheet.Cells[1, "D"] = "Latitude";
                workSheet.Cells[1, "E"] = "Longitude";
                workSheet.Cells[1, "F"] = "IsEnabled";
                workSheet.Cells[1, "G"] = "IataCityCode";
                workSheet.Cells[1, "H"] = "FullTextColumn";
                workSheet.Cells[1, "I"] = "en-US";
                workSheet.Cells[1, "J"] = "Chinese TH";
                workSheet.Cells[1, "K"] = "en-GB or en-UK";
                workSheet.Cells[1, "L"] = "pt-BR";
                workSheet.Cells[1, "M"] = "es-MX";
                workSheet.Cells[1, "N"] = "es-CO";
                workSheet.Cells[1, "O"] = "th-TH";

                // Populate sheet with some real data from "city" list
                int row = 2;
                foreach (City city in cities)
                {
                    workSheet.Cells[row, "A"] = city.CityName;
                    workSheet.Cells[row, "B"] = city.StateCode;
                    workSheet.Cells[row, "C"] = city.CountryCode;
                    workSheet.Cells[row, "D"] = city.Latitude;
                    workSheet.Cells[row, "E"] = city.Longitude;
                    workSheet.Cells[row, "F"] = city.IsEnabled;
                    workSheet.Cells[row, "G"] = city.IataCityCode;
                    workSheet.Cells[row, "H"] = city.FullTextColumn;
                    workSheet.Cells[row, "I"] = city.USCulture;
                    workSheet.Cells[row, "J"] = city.ChineseTHCulture;
                    workSheet.Cells[row, "K"] = city.UKCulture;
                    workSheet.Cells[row, "L"] = city.BRCulture;
                    workSheet.Cells[row, "M"] = city.MXCulture;
                    workSheet.Cells[row, "N"] = city.COCulture;
                    workSheet.Cells[row, "O"] = city.THthCulture;

                    row++;
                }

                // Apply some predefined styles for data to look nicely :)
                workSheet.Range["A1"].AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatClassic1);

                // Define filename
                string fileName = string.Format(@"{0}\CityMultiCultureData.xlsx", Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));

                // Save this data as a file
                workSheet.SaveAs(fileName);
                return true;
            }
            catch (Exception ex)
            {
                Log.LogException(ex);
                Console.WriteLine("Exception While Saving File  :" + ex.Message + "\t" + ex.GetType());
                Console.ReadKey();
                throw ex;
            }
            finally
            {
                // Quit Excel application
                excel.Quit();

                // Release COM objects ()
                if (excel != null)
                    Marshal.ReleaseComObject(excel);

                if (workSheet != null)
                    Marshal.ReleaseComObject(workSheet);

                // Empty variables
                excel = null;
                workSheet = null;

                // Force garbage collector cleaning
                GC.Collect();
            }
        }
    }
}
