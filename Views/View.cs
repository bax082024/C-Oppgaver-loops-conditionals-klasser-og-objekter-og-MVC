using System;
using System.Collections.Generic;
using BeerMVC.Models; // Reference to use the Beer class

namespace BeerMVC.Views
{
    public class View
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void DisplayBeers(List<Beer> beers)
        {
            Console.WriteLine("\nCurrent Beers:");
            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("\n--- Beer Menu ---");
            Console.WriteLine("1. Add a beer");
            Console.WriteLine("2. Remove a beer");
            Console.WriteLine("3. View beers");
            Console.WriteLine("4. Exit");
        }
    }
}
