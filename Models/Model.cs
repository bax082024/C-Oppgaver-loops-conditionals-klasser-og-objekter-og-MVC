using System.Collections.Generic;

namespace BeerMVC.Models // Replace with your actual namespace
{
    public class Model
    {
        private List<Beer> beers; // Ensure Beer class is defined

        public Model()
        {
            beers = new List<Beer>();
        }

        public void AddBeer(string name, string type)
        {
            beers.Add(new Beer(name, type)); // Make sure Beer class has the appropriate constructor
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
    }
}
