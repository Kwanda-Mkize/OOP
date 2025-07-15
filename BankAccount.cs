using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using OPP;

namespace OOP
{
  internal class BankAccount
  {
    private string? AccountNumber { get; set; }
    private string? AcountHolder { get; set; }
    private decimal Balance { get; set; }
    private string? Pin { get; set; }

    private BankAccount(){ }

    public class BankBuilder
    {
      private readonly BankAccount bankAccountBuilder = new BankAccount();
       public BankBuilder setAccountNumber(string accountNumber )
        { 
          bankAccountBuilder.AccountNumber = accountNumber;
         return this;
        }
         public BankBuilder setAccountHolder(string accountHolder )
        { 
          bankAccountBuilder.AcountHolder = accountHolder;
         return this;
        }
         public BankBuilder setBalance(decimal balance )
        { 
          bankAccountBuilder.Balance = balance;
         return this;
        }
         public BankBuilder setPin(string pin)
        { 
          bankAccountBuilder.Pin= pin;
         return this;
        }
         public BankAccount build()
        {
          return bankAccountBuilder;
        }  
    }

    public void Widthdraw(string pin, decimal amount)
    {

      DateTime timeStamp = DateTime.UtcNow;
      if (this.Pin == pin)
      {

        if (this.Balance > amount)
        {
          Balance -= amount;
          Logger.Instance.LogWithdraw(AccountNumber?? string.Empty, Balance, amount, timeStamp);

        }
        else
        {
          throw new InvalidOperationException("Not enough funds to withdraw");
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
          Logger.Instance.LogDeposit(AccountNumber?? string.Empty, Balance, amount, SecondAccountNumber, timeStamp);

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





