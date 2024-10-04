using System.Collections.Generic;



public class Beer
{
  public string Name { get; set; }
  public int Type { get; set; }

  public Beer(string name, string type)
  {
    Name = name;
    Type = type;
  }

  public override string ToString()
  {
      return $"{Name} ({Type})";
  }
}

public class Model
{
  public List<Beer> Beers { get; set; } = new List<Beer>;

  public void Addbeer(string name, string type)
  {
    Beers.Add(new Beer(name, type));
  }

  public void RemoveBeer(string name)
  {
    Beers.RemoveAll(base => base.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
  }

  public List<Beer> GetBeers()
  {
    return Beers;
  }
}










public class Model
{
  public List<Beer> Beers { get; set;}
}