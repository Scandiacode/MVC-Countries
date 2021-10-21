using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country country)
        {
            DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine(string.Format("{0,-25}{1,-15}{2,0}","Name","Continent","Colors"));
            Console.WriteLine(string.Format("{0,-25}{1,-15}{2,0}",DisplayCountry.Name, DisplayCountry.Continent, DisplayCountry.Colors));
        }
    }
}
