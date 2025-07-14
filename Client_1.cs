using OOP;

public class Client_1 : Adapter
{
  public override void Execute()
  {
    BankAccount client1 = new BankAccount.BankBuilder()
    .setAccountNumber("111000555")
    .setAccountHolder("Kwanda Mkhize")
    .setBalance(100)
    .setPin("1223")
    .build();

    client1.Widthdraw("1213", 50);
  }
}