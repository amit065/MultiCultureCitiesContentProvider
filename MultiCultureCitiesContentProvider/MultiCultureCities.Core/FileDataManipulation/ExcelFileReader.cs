using MultiCultureCities.Contract;
using MultiCultureCities.Core.Logger;
using MultiCultureCities.Model;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;

namespace MultiCultureCities.Core.FileDataManipulation
{
    public class ExcelFileReader : IFileReader
    {
        private string _filePath;

        public ExcelFileReader(string filepath)
        {
            _filePath = filepath;
        }

        public List<City> ImportCitiesDataExcel(string filePath)
        {
            var count = 0;
            // Load Excel application
            Excel.Application xlApp = new Excel.Application();
            try
            {
                // Open the Excel file
                Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(filePath);

                // Get the first worksheet
                Excel._Worksheet xlWorksheet1 = xlWorkbook.Sheets[1];
                Excel._Worksheet xlWorksheet2 = xlWorkbook.Sheets[2];

                // Get the range of cells of first worksheet which has data.
                Excel.Range xlRange1 = xlWorksheet1.UsedRange;
                int row1 = xlRange1.Rows.Count;
                int columnl1 = xlRange1.Columns.Count;

                // Get the range of cells of second worksheet which has data.
                Excel.Range xlRange2 = xlWorksheet2.UsedRange;
                int row2 = xlRange2.Rows.Count;
                int columnl2 = xlRange2.Columns.Count;

                List<City> cities = new List<City>();
                ExcelFileManipulator excelManipulator = new ExcelFileManipulator();

                for (int i = 2; i <= row2; i++)
                {
                    count++;
                    for (int j= 2; j <= row1; j++)
                    {

                        if((Convert.ToString((xlRange2.Cells[i, 1] as Excel.Range).Value2 )== (Convert.ToString((xlRange1.Cells[j, 1] as Excel.Range).Value2))))
                        {
                            cities.Add(new City
                            {
                                CityName = Convert.ToString((xlRange2.Cells[i, 1] as Excel.Range).Value2),
                                StateCode = Convert.ToString((xlRange2.Cells[i, 2] as Excel.Range).Value2),
                                CountryCode = Convert.ToString((xlRange2.Cells[i, 3] as Excel.Range).Value2),
                                Latitude = Convert.ToString((xlRange2.Cells[i, 4] as Excel.Range).Value2),
                                Longitude = Convert.ToString((xlRange2.Cells[i, 5] as Excel.Range).Value2),
                                IsEnabled = Convert.ToString((xlRange2.Cells[i, 6] as Excel.Range).Value2),
                                IataCityCode = Convert.ToString((xlRange2.Cells[i, 7] as Excel.Range).Value2),
                                FullTextColumn = (i == 1 ? "FullTextSearch" : excelManipulator.GetFullTextSearch((string)(xlRange2.Cells[i, 1] as Excel.Range).Value2, Convert.ToString((xlRange2.Cells[i, 7] as Excel.Range).Value2))),
                                USCulture = Convert.ToString((xlRange1.Cells[j, 1] as Excel.Range).Value2),
                                ChineseTHCulture= Convert.ToString((xlRange1.Cells[j, 2] as Excel.Range).Value2),
                                UKCulture= Convert.ToString((xlRange1.Cells[j, 3] as Excel.Range).Value2),
                                BRCulture= Convert.ToString((xlRange1.Cells[j, 4] as Excel.Range).Value2),
                                MXCulture= Convert.ToString((xlRange1.Cells[j, 5] as Excel.Range).Value2),
                                COCulture= Convert.ToString((xlRange1.Cells[j, 6] as Excel.Range).Value2),
                                THthCulture= Convert.ToString((xlRange1.Cells[j, 7] as Excel.Range).Value2)

                            });
                            break;
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Rows readed : " + count + "  /  " + "Excel-Rows :" + cities.Count);
                }
                Log.Activitylogger();
                return cities;

            }
            catch (Exception ex)
            {
                Log.ExcpLogger(ex);
                Console.WriteLine("Exception While Reading Data From File :" + ex.Message + "\t" + ex.GetType());
                Console.ReadKey();
                throw ex;
            }
            finally
            {
                // Quit Excel application
                xlApp.Quit();


                // Release COM objects ()
                if (xlApp != null)
                    Marshal.ReleaseComObject(xlApp);

                // Empty variables
                xlApp = null;

                // Force garbage collector cleaning
                GC.Collect();
            }

        }
    }
}
