using System.Collections.Generic;

namespace labb4
{
    public class CountryRepository
    {
        private List<Country> countries;

        public CountryRepository()
        {
            var json = new Json<JsonModel>();
            json.Deserialize("rawData.json");
            countries = json.Model.Countries;
        }

        public List<Country> GetCountries()
        {
            return countries;
        }
    }
}
