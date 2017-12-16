using MultiCultureCities.Model;
using System.Collections.Generic;

namespace MultiCultureCities.Contract
{
    public interface IFileReader
    {
        List<City> ImportCitiesDataExcel(string filePath);
    }
}
    