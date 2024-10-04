using System;
using System.Drawing;

public class Controller
{
  private Model _model;
  private View _view;
}

public Controller(Model model,View view)
{
  _model = model;
  _view = view;
}

public void Run()
{
  bool exit = false;
  while (!exit)
  {
    _view:Showmenu();
    Console.WriteLine("Choose an option"); // choose what you want to do!
    string choice = Console.ReadLine();

    switch (choice)
    {
      case "1":
      Console.Write("Enter beer name:"); // Console.write because i want it in 1 line (Console.Writeline for new line)
      string name = Console.ReadLine();
      Console.Write("Enter beer type (e.g., tuborg, 7Fjell, Heineken, Hansa)"); // type of beer you want to add
      string type = Console.ReadLine();
      _model.AddBeer(name, type);
      _view.ShadowMessage("Beer added");
      break;

      case "2":
      Console.Write("Enter beer name to remove:") // remove beer
      string removeName = Console.ReadLine();
      _model.RemoveBeer(removename);
      _view.ShowMessage("Beer removed");
      break;

      case "3":
      _view-DisplayBeers(_model.GetBeers()); // display beers 
      break;

      case "4":
      exit = true;
      _view.ShowMessage("Exiting Program......."); // exit program
      break;

      default:
      _view.ShowMessage("Invalid choice. Please try again.");
      break;
    }
  }
}