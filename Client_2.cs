using OOP;
public class Client_2 : Adapter
{
  public override void Execute()
  {
    // Bank client2 = new Bank("222000333", "Arnold Mkhize", 1500, "2445");
    BankAccount client2 = new BankAccount.BankBuilder()
    .setAccountNumber("222000333")
    .setAccountHolder("Arnold Mkhize")
    .setBalance(1500)
    .setPin("2445")
    .build();

    client2.Widthdraw("2445", 250);
    client2.Deposit("2445", 40, "111000555");
    client2.CardPurchase("2445", 40, "121000333");
  }

}