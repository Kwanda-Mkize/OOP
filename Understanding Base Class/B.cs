public class B : A
{
  public B()
  {
    Console.WriteLine("B constructor called");
  }
  public B(String a):this()
  {
    Console.WriteLine("B constructor called with string a "+a);
  }
  public B(int a) :this("hello")
  {
    Console.WriteLine("B constructor called with int a = "+a);
  }
}