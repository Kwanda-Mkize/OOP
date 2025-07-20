public abstract class BankAccount
{
  public decimal Balance { get; set; }
  public BankAccount(decimal balance)
  {
    Balance = balance;
  }

  public abstract decimal CalculateInterest();
}