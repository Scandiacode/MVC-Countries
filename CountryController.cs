using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_Countries
{
    class CountryController
    {
        private List<Country> CountryDb = new List<Country>
        {
            new Country("Japan","Asia", new List<string>{"White","Red"}),
            new Country("United Kingdom","Europe", new List<string>{"Blue","White","Red"}),
            new Country("United States","North America", new List<string>{"Red", "White","Blue"}),
            new Country("Sweden","Europe", new List<string>{"Blue","Yellow"}),
            new Country("Australia","Australia", new List<string>{"Blue","White","Red","White Stars" })
        };

        public List<Country> CountryList { get; set; }

        public void CountryAction(Country c)
        {
            CountryView cView = new CountryView(c);
            cView.Display();
        }

        public void WelcomeAction()
        {
            bool runProgram = true;
            while (runProgram)
            {
                Console.WriteLine("Hello, welcome to the country app. Please select a country from the following list: ");
                while (true)
                {
                    try
                    {
                        CountryListView countryListView = new CountryListView(CountryDb);
                        countryListView.Display();
                        int choice = int.Parse(Console.ReadLine());
                        if(choice >= CountryDb.Count && choice <= 0)
                        {
                            Console.WriteLine("Invalid choice | Please select a number for list");
                            continue;
                        }
                        CountryAction(CountryDb[choice - 1]);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                Console.WriteLine("Would you like to pick another country? (y/n)");
                while (true)
                {
                    string answer = Console.ReadLine();
                    if (answer.Equals("y"))
                    {
                        break;
                    }
                    else if (answer.Equals("n"))
                    {
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice | Please choose y or n");
                    }
                }
            }
        }
    }
}
