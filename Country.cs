using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class Country
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public List<string> Colors { get; set; }

        public Country(string name, string contient, List<string> colors)
        {
            Name = name;
            Continent = contient;
            Colors = colors;
        }
    }
}
