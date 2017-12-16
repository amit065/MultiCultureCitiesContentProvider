using MultiCultureCities.Model;
using System.Collections.Generic;

namespace MultiCultureCities.Contract
{
    public interface IScriptGenerator
    {
        void GenerateInsertScript(List<City> cities);
    }
}
