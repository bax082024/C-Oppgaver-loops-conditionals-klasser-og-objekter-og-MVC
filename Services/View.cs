using System;
using System.Collections.Generic;

public class View
{
  public void DisplayBeers(List<Beer> beers)
  {
    Console.WriteLine("Current Beer List");
    foreach (var beer in beers)
    {
      Console.WriteLine($"- {beer}");
    }
  }

  public void ShowMenu()
  {
    Console.WriteLine("\nMenu");
    Console.WriteLine("1. Add Beer");
    Console.WriteLine("2. Remove Beer");
    Console.WriteLine("3. Show Beers");
    Console.WriteLine("4. Exit");
  }

  public void ShowMessage(string message)
  {
    Console.WriteLine();
  }

}