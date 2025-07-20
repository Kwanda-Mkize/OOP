public class Car : Vehicle
{
  public Car(string type, string engine) : base(type, engine) { }

  public override void Display()
  {
    Console.WriteLine($"This is a {Type} with a {Engine} Litre engine");
  }
}