public class FixedDepositAccount : BankAccount
{
  public int NumberOfMonths { get; set; }
  public FixedDepositAccount(decimal balance, int numberOfMonths) : base(balance)
  {
    NumberOfMonths = numberOfMonths;
  }
  public override decimal CalculateInterest()
  {
    return Balance * 0.05m * NumberOfMonths / 12;
  }
}