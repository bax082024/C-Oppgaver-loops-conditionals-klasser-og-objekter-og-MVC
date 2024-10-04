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

}