public class SavingsAccount : BankAccount
{
  public decimal interest { get; set; }
  public SavingsAccount(decimal balance) : base(balance)
  {
  }
  public override decimal CalculateInterest()
  {
    interest = Balance * 0.02m;
    return interest;
  }

  public void ShowInterest()
  {
    Console.WriteLine($"Total interest accumulated {interest}");
  }

}