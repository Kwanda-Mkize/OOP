public abstract class Vehicle
{
  public string Type { get; set; }
  public string Engine { get; set; }

  public Vehicle(string type, string engine)
  {
    Type = type;
    Engine = engine;
  }

  public abstract void Display();
}