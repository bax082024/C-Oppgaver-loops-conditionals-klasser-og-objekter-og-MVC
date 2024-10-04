using System;

namespace BeerMVC.Controllers // Replace with your actual namespace
{
    public class Controller
    {
        private Model model; // Ensure that the Model class is defined and accessible
        private View view; // Ensure that the View class is defined and accessible

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void AddBeer()
        {
            Console.WriteLine("Enter beer name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter beer type:");
            string type = Console.ReadLine();

            // Check for null or empty values
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(type))
            {
                view.ShowMessage("Beer name and type cannot be empty.");
                return;
            }

            model.AddBeer(name, type); // Ensure AddBeer method exists in Model
            view.ShowMessage("Beer added successfully!");
        }

        public void RemoveBeer()
        {
            Console.WriteLine("Enter the name of the beer to remove:");
            string name = Console.ReadLine();

            // Check for null or empty value
            if (string.IsNullOrEmpty(name))
            {
                view.ShowMessage("Beer name cannot be empty.");
                return;
            }

            if (model.RemoveBeer(name)) // Ensure RemoveBeer method exists in Model
            {
                view.ShowMessage("Beer removed successfully!");
            }
            else
            {
                view.ShowMessage("Beer not found.");
            }
        }
    }
}
