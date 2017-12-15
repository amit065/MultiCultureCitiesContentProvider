using MultiCultureCities.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCultureCities.Contract
{
    public interface IFileReader
    {
        List<City> ImportPointOfInterestDataFromExcel(string filePath);
    }
}
