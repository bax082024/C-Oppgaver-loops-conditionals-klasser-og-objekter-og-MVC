using System;
using System.Collections.Generic;
using BeerMVC.Models; // added to use the beer class

namespace BeerMVC.Views
{
    public class View
    {
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        // Displays the list of beer
        public void DisplayBeers(List<Beer> beers)
        {
            Console.WriteLine("\nCurrent Beers:");
            foreach (var beer in beers)
            {
                Console.WriteLine(beer);
            }
        }

        // Functions shown to user
        public void ShowMenu()
        {
            Console.WriteLine("\nWelcome to the beer information program");
            Console.WriteLine("\n--- Beer Menu ---");
            Console.WriteLine("\n1. Add a beer");
            Console.WriteLine("2. Remove a beer");
            Console.WriteLine("3. View beers");
            Console.WriteLine("4. Update beer description");
            Console.WriteLine("5. Exit Program");
        }
    }
}
