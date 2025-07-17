using OOP;

public class BankBuilder
{
  private string? AccountNumber { get; set; }
  private string? AccountHolder { get; set; }
  private decimal Balance { get; set; }
  private string? Pin { get; set; }

  public static BankBuilder Builder()
  {
    return new BankBuilder();
  }

  public BankBuilder setAccountNumber(string accountNumber)
  {
    AccountNumber = accountNumber;
    return this;
  }
  public BankBuilder setAccountHolder(string accountHolder)
  {
    AccountHolder = accountHolder;
    return this;
  }
  public BankBuilder setBalance(decimal balance)
  {
    Balance = balance;
    return this;
  }
  public BankBuilder setPin(string pin)
  {
    Pin = pin;
    return this;
  }
  public BankAccount Build()
  {
    return new BankAccount(AccountNumber ?? string.Empty, AccountHolder ?? string.Empty, Balance, Pin ?? string.Empty);
  }
}
