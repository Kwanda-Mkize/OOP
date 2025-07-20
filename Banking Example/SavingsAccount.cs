public class SavingsAccount : BankAccount
{
  public decimal Interest { get; set; }
  public SavingsAccount(decimal balance) : base(balance)
  {
  }
  public override decimal CalculateInterest()
  {
    Interest = Balance * 0.02m;
    return Interest;
  }

  public void ShowInterest()
  {
    Console.WriteLine($"Total interest accumulated {Interest}");
  }

}