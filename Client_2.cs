using OOP;
public class Client_2 : Adapter
{
  public override void Execute()
  {
    BankAccount client2 = BankBuilder.Builder()
    .setAccountNumber("222000333")
    .setAccountHolder("Arnold Mkhize")
    .setBalance(1500)
    .setPin("2445")
    .Build();

    // client2.Widthdraw("2445", 250);

    // client2.Widthdraw("2445", 250);
    Parallel.For(0, 7, i =>
   {
     client2.Widthdraw("2445", 250);

   });


    // client2.Deposit("2445", 40, "111000555");
    // client2.CardPurchase("2445", 40, "121000333");
  }

}