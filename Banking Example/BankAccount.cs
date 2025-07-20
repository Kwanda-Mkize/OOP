public abstract class BankAccount
{
  protected decimal Balance { get; set; }
  public BankAccount(decimal balance)
  {
    Balance = balance;
  }

  public abstract decimal CalculateInterest();
}