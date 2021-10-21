using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> countryList)
        {
            Countries = countryList;
        }

        public void Display()
        {
            Console.WriteLine("Country:");

            int counter = 1;
            foreach (Country country in Countries)
            {
               Console.WriteLine($"{counter}. {country.Name}");
                counter++;
            }
        }
    }
}
