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
  public List<Beer> Beers { get; set;}
}