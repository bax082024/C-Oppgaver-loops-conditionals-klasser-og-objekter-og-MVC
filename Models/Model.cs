using System;
using System.Collections.Generic;

namespace BeerMVC.Models
{
    public class Beer
    {
        public string Name { get; set; }
        public string EstablishedYear { get; set; }
        public string Description { get; set; }

        // Constructor to initialize all properties
        public Beer(string name, string establishedYear, string description)
        {
            Name = name;
            EstablishedYear = establishedYear;
            Description = description;
        }

        // Override the ToString() method to return the desired output format
        public override string ToString()
        {
            return $"\"{Name}\", \"established in {EstablishedYear}\", \"{Description}\"";
        }
    }

    public class Model
    {
        private List<Beer> beers;

        // Initialize the list of beers with the new format, using 3 arguments
        public Model()
        {
            beers = new List<Beer>
            {
                new Beer("Heineken", "1873", "The best of the best"),
                new Beer("Carlsberg", "1847", "A good second on the list"),
                new Beer("Tuborg", "1880", "Littlebit cheaper but good")
            };
        }

        // Updated AddBeer method to take the new properties
        public void AddBeer(string name, string establishedYear, string description)
        {
            beers.Add(new Beer(name, establishedYear, description));
        }

        public bool RemoveBeer(string name)
        {
            var beerToRemove = beers.Find(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (beerToRemove != null)
            {
                beers.Remove(beerToRemove);
                return true;
            }
            return false;
        }

        public bool UpdateBeerType(string name, string newDescription)
        {
            var beerToUpdate = beers.Find(b => b.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (beerToUpdate != null)
            {
                beerToUpdate.Description = newDescription;
                return true;
            }
            return false;
        }

        public List<Beer> GetBeers()
        {
            return beers;
        }
    }
}
