public class Motorcycle : Vehicle
{
  public Motorcycle(string type, string engine) : base(type, engine)
  {
  }

  public override void Display()
  {
    Console.WriteLine($"{Type} with a {Engine} Litre engine driving on the road ");
  }
}