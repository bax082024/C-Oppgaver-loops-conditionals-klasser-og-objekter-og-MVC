using System;
using BeerMVC.Controllers;
using BeerMVC.Models;
using BeerMVC.Views;

class Program
{
    static void Main(string[] args)
    {
        // Create the Model, View, and Controller for Beer Management
        Model model = new Model();
        View view = new View();
        Controller controller = new Controller(model, view);

        // Start the application
        controller.Run();
    }
}
