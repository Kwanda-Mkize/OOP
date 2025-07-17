using System.ComponentModel.DataAnnotations;

namespace OPP
{
  internal class Logger
  {
    private static Logger? _instance;
    private static Object _lock = new object();

    public List<string> LoggedWithdraws;
    public List<string> LoggedDeposits;
    public List<string> LoggedCardPurchases;

    public static int _instanceCount = 0;

    private Logger()
    {
      _instanceCount++;
      Console.WriteLine($"Instance Created");
      LoggedWithdraws = new List<string>();
      LoggedDeposits = new List<string>();
      LoggedCardPurchases = new List<string>();
    }

    public static Logger Instance
    {
      get
      {
        lock (_lock)
        {
          if (_instance == null)
          {
            _instance = new Logger();
          }
          return _instance;
        }
        // return  _instance = new Logger();
      }
    }

    public void LogWithdraw(string accountNumber, decimal balance, decimal amount, DateTime timeStamp)
    {
      LoggedWithdraws.Add($"{accountNumber} widthdrew R{amount} at {timeStamp}, available balance is R{balance}");
    }

    public void LogDeposit(string accountNumber, decimal balance, decimal amount, string SecondAccountNumber, DateTime timeStamp)
    {
      LoggedDeposits.Add($"{accountNumber} Deposted R{amount} to {SecondAccountNumber} at {timeStamp}, available balance is R{balance}");
    }

    public void LogCardPurchase(string accountNumber, decimal balance, decimal amount, string StoreAccountNumber, DateTime timeStamp)
    {
      LoggedCardPurchases.Add($"{accountNumber} paid R{amount} to {StoreAccountNumber} at {timeStamp}, available balance is R{balance}");
    }

    public void PrintWithdrawLogs()
    {
      foreach (var item in LoggedWithdraws)
      {
        Console.WriteLine($"Withdraw Transaction Logged: {item}");
      }
    }

    public void PrintDepositLogs()
    {
      foreach (var item in LoggedDeposits)
      {
        Console.WriteLine($"Deposit Transaction Logged: {item}");
      }
    }

    public void PrintCardPurchaseLogs()
    {
      foreach (var item in LoggedCardPurchases)
      {
        Console.WriteLine($"Purchase Transaction Logged: {item}");
      }
    }



  }
}