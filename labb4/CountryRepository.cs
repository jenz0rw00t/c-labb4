using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace labb4
{
    public class CountryRepository
    {
        private List<Country> countries = new List<Country>();

        public CountryRepository()
        {
            countries.Add(new Country("Sweden", "SEK", 10120000, "sweden.png", "Sweden, officially the Kingdom of Sweden, is a Nordic country on the Scandinavian Peninsula in Northern Europe. It has been a member of the European Union since 1 January 1995. Its capital city is Stockholm."));
            countries.Add(new Country("Denmark", "EUR", 5603000, "denmark.png", "Denmark is a Scandinavian country comprising the Jutland Peninsula and numerous islands. It's linked to nearby Sweden via the Öresund bridge. Copenhagen, its capital, is home to royal palaces and colorful Nyhavn harbor, plus the Tivoli amusement park and the iconic “Little Mermaid” statue. Odense is writer Hans Christian Andersen’s hometown, with a medieval core of cobbled streets and half-timbered houses."));
        }

        public List<Country> GetCountries => countries;
    }
}
