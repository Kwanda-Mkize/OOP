using OOP;

public class Client_1 : Adapter
{
  public override void Execute()
  {
    BankAccount client1 = BankBuilder.Builder()
    .setAccountNumber("111000555")
    .setAccountHolder("Kwanda Mkhize")
    .setBalance(100)
    .setPin("1223")
    .Build();

    client1.Widthdraw("1213", 50);
  }
}
