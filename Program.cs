using OOP;
using OPP;

void clientAction(Adapter adapter)
{
  adapter.PerfomActivity();
}

clientAction(new Client_1());
clientAction(new Client_2());

Logger.Instance.PrintWithdrawLogs();
Logger.Instance.PrintCardPurchaseLogs();
Logger.Instance.PrintDepositLogs();


