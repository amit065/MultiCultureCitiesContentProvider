using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCultureCities.Model
{
    public class City
    {
        public string CityName { get; set; }

        public string StateCode { get; set; }

        public string CountryCode { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string IsEnabled { get; set; }

        public string IataCityCode { get; set; }

        public string FullTextColumn { get; set; }

        public string USCulture { get; set; }
        public string ChineseTHCulture { get; set; }
        public string UKCulture { get; set; }
        public string BRCulture { get; set; }
        public string MXCulture { get; set; }
        public string COCulture { get; set; }
        public string THthCulture { get; set; }

    }
}
