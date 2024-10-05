using BeerMVC.Controllers;
using BeerMVC.Models;
using BeerMVC.Views;

namespace BeerMVC
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Model, View, and Controller
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(model, view);

            // Start the program
            controller.Run();
        }
    }
}
