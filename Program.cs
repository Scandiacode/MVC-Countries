using System;

namespace MVC_Countries
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController countryController = new CountryController();
            countryController.WelcomeAction();
        }
    }
}
