using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using OPP;

namespace OOP
{
  public class BankAccount
  {
    public string? AccountNumber { get; set; }
    private string? AccountHolder { get; set; }
    private decimal Balance { get; set; }
    private string? Pin { get; set; }

    public BankAccount(string accountNumber, string accountHolder, decimal balance, string pin)
    {
      AccountNumber = accountNumber;
      AccountHolder = accountHolder;
      Balance = balance;
      Pin = pin;
    }

    private object lockObject = new Object();
    public void Widthdraw(string pin, decimal amount)
    {

      DateTime timeStamp = DateTime.UtcNow;
      if (this.Pin == pin)
      {

        lock (lockObject)
        {
          if (this.Balance >= amount)
          {
            this.Balance = this.Balance - amount;
            Logger.Instance.LogWithdraw(AccountNumber ?? string.Empty, this.Balance, amount, timeStamp);
          }
          else
          {
            throw new InvalidOperationException("Not enough funds to withdraw");
          }
        }
      }
      else
      {
        throw new InvalidOperationException("Wrong Pin try again");
      }
    }


    public void Deposit(string pin, decimal amount, string SecondAccountNumber)
    {
      DateTime timeStamp = DateTime.UtcNow;
      if (this.Pin == pin)
      {

        if (this.Balance > amount)
        {
          Balance -= amount;

          Logger.Instance.LogDeposit(AccountNumber ?? string.Empty, Balance, amount, SecondAccountNumber, timeStamp);

        }
        else
        {
          throw new InvalidOperationException("Not enough funds to Depost");
        }
      }
      else
      {
        throw new InvalidOperationException("Wrong Pin try again");
      }
    }


    public void CardPurchase(string pin, decimal amount, string StoreAccountNumber)
    {
      DateTime timeStamp = DateTime.UtcNow;
      if (this.Pin == pin)
      {

        if (this.Balance > amount)
        {
          Balance -= amount;
          Logger.Instance.LogCardPurchase(AccountNumber ?? string.Empty, Balance, amount, StoreAccountNumber, timeStamp);

        }
        else
        {
          throw new InvalidOperationException("Not enough funds to Purchase");
        }
      }
      else
      {
        throw new InvalidOperationException("Wrong Pin try again");
      }

    }
  }
}





