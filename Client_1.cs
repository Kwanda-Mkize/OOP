using OOP;

public class Client_1 : Adapter
{
  public override void Execute()
  {
    // Bank client1 = new Bank("111000555", "Kwanda Mkhize", 100, "1223");
    BankAccount client1 = new BankAccount.BankBuilder()
    .setAccountNumber("111000555")
    .setAccountHolder("Kwanda Mkhize")
    .setBalance(100)
    .setPin("1223")
    .build();

    client1.Widthdraw("1213", 50);
  }
}