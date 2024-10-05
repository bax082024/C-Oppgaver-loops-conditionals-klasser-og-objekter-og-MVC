using System;
using BeerMVC.Models;
using BeerMVC.Views;

namespace BeerMVC.Controllers
{
    public class Controller
    {
        private Model model; // eksempel Constructor
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        // Action menu
        public void Run()
        {
            bool exit = false;
            while (!exit)
            {
                view.ShowMenu();
                Console.Write("Choose an option: ");
                string? choice = Console.ReadLine();

                if (string.IsNullOrEmpty(choice))
                {
                    view.ShowMessage("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (choice)
                {
                    case "1":
                        AddBeer();
                        break;
                    case "2":
                        RemoveBeer();
                        break;
                    case "3":
                        view.DisplayBeers(model.GetBeers());
                        break;
                    case "4":
                        UpdateBeerDescription();
                        break;
                    case "5":
                        exit = true;
                        view.ShowMessage("Exiting program...");
                        break;
                    default:
                        view.ShowMessage("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // To add a beer
        private void AddBeer()
        {
            Console.Write("Enter beer name: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                view.ShowMessage("Beer name cannot be empty.");
                return;
            }

            Console.Write("Enter the year the beer was established: ");
            string? establishedYear = Console.ReadLine();

            if (string.IsNullOrEmpty(establishedYear))
            {
                view.ShowMessage("Established year cannot be empty.");
                return;
            }

            Console.Write("Enter a description for the beer: ");
            string? description = Console.ReadLine();

            if (string.IsNullOrEmpty(description))
            {
                view.ShowMessage("Description cannot be empty.");
                return;
            }

            model.AddBeer(name, establishedYear, description);
            view.ShowMessage($"Beer '{name}' added successfully!");
        }

        // To remove a beer
        private void RemoveBeer()
        {
            Console.Write("Enter the name of the beer to remove: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                view.ShowMessage("Beer name cannot be empty.");
                return;
            }

            if (model.RemoveBeer(name))
            {
                view.ShowMessage($"Beer '{name}' removed successfully!");
            }
            else
            {
                view.ShowMessage($"Beer '{name}' not found.");
            }
        }

        // To update a beer
        private void UpdateBeerDescription()
        {
            Console.Write("Enter the name of the beer to update: ");
            string? name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                view.ShowMessage("Beer name cannot be empty.");
                return;
            }

            Console.Write("Enter the new description for the beer: ");
            string? newDescription = Console.ReadLine();

            if (string.IsNullOrEmpty(newDescription))
            {
                view.ShowMessage("New description cannot be empty.");
                return;
            }

            if (model.UpdateBeerType(name, newDescription))
            {
                view.ShowMessage($"Beer '{name}' updated successfully!");
            }
            else
            {
                view.ShowMessage($"Beer '{name}' not found.");
            }
        }
    }
}
