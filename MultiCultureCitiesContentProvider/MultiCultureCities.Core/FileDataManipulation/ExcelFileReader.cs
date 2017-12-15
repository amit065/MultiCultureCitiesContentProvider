using MultiCultureCities.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiCultureCities.Model;

namespace MultiCultureCities.Core.FileDataManipulation
{
    public class ExcelFileReader : IFileReader
    {
        private string _filePath;

        public ExcelFileReader(string filepath)
        {
            _filePath = filepath;
        }

        public List<City> ImportPointOfInterestDataFromExcel(string filePath)
        {
            throw new NotImplementedException();
        }
    }
}
