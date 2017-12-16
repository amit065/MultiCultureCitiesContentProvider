using MultiCultureCities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiCultureCities.Model;
using System.IO;

namespace MultiCultureCities.Core.FileDataManipulation
{
    public class ScriptGeneratorUS : IScriptGenerator
    {
        public void GenerateInsertScript(List<City> cities)
        {
            try
            {
                // Define filename where to save the City insert script
                using (StreamWriter writer = new StreamWriter(@"C:\Users\aprakash\Desktop\MultiCultureCity\InsertScriptForUS.txt", false))
                {
                    for (int i = 1; i < cities.Count; i++)
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
            catch
            {
                throw new Exception("Failed to generate script");
            }
        }
    }
}
