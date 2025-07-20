public class CurrentAccount : BankAccount
{
  public CurrentAccount(decimal balance) : base(balance)
  {
  }
  public override decimal CalculateInterest()
  {
    return 0;
  }
}