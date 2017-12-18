using MultiCultureCities.Contract;
using MultiCultureCities.Core.Logger;
using MultiCultureCities.Model;
using System;
using System.Collections.Generic;
using System.IO;

namespace MultiCultureCities.Core.ScriptGenerator
{
    public class ScriptGeneratorUS : IScriptGenerator
    {
        public void GenerateInsertScript(List<City> cities)
        {
            try
            {
                // Define filename where to save the City insert script
                string filePath = string.Format(@"{0}\..\MultiCultureCities.Core\SolutionFile\ScriptFiles", Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));

                using (StreamWriter writer = new StreamWriter(filePath + @"\InsertScriptForUS.sql", false))
                {
                    for (int i = 0; i < cities.Count; i++)
                    {
                        writer.WriteLine("IF NOT EXISTS");
                        writer.WriteLine("(Select * from Cities where CityName = '" + cities[i].CityName.Trim() + "' , '" + "StateCode = '" + cities[i].StateCode.Trim() + "' , '" + "AND CountryCode = '" + cities[i].CountryCode.Trim() + ")");
                        writer.WriteLine("Begin");
                        writer.WriteLine("Insert into Cities (CityName, StateCode, CountryCode, Latitude, Longitude, IsEnabled, IataCityCode, FullTextColumn) values('" + cities[i].USCulture.Trim() + "' , '" + cities[i].StateCode.Trim() + "' , '"
                                        + cities[i].CountryCode.Trim() + "' , '" + cities[i].Latitude.Trim() + "' , '" + cities[i].Longitude.Trim() + "' , '" + cities[i].IsEnabled.Trim() + "' , '" + (cities[i].IataCityCode != null ? cities[i].IataCityCode.Trim() : cities[i].IataCityCode = "NULL".Trim())
                                        + "' , '" + cities[i].FullTextColumn.Trim() + "');");
                        writer.WriteLine("End");
                        writer.WriteLine();

                    }

                }
            }
            catch(Exception ex)
            {
                Log.LogException(ex);

                Console.WriteLine("Exception Related To Script Generation :" + ex.Message + "\t" + ex.GetType());

                Console.ReadKey();

            }
        }
    }
}
