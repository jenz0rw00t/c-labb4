using System;
using System.Collections.Generic;
using System.Windows.Input;
using Lab4;
using Xamarin.Forms;

namespace labb4
{
    public class MainViewModel : SimpleViewModel
    {
        private List<Country> countries;
        private Country selectedCountry;
        private int index;

        public ICommand NextCommand { private set; get; }
        public ICommand PrevCommand { private set; get; }

        public Country SelectedCountry
        {
            get => selectedCountry;
            set => SetPropertyValue(ref selectedCountry, value);
        }


        public MainViewModel()
        {
            var countryRepo = new CountryRepository();
            countries = countryRepo.GetCountries;
            index = 0;
            SelectedCountry = countries[index];
            CommandSetup();
        }

        private void CommandSetup()
        {
            NextCommand = new Command(() =>
            {
                index++;
                if (index > countries.Count - 1)
                {
                    index = 0;
                }
                SelectedCountry = countries[index];
            });
            PrevCommand = new Command(() =>
            {
                index--;
                if (index < 0)
                {
                    index = countries.Count - 1;
                }
                SelectedCountry = countries[index];
            });
        }
    }
}
