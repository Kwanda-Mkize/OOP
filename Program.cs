using OOP;
using OPP;
using System;
using System.Threading;


void clientAction(Adapter adapter)
{
  adapter.PerfomActivity();
}

// clientAction(new Client_1());
clientAction(new Client_2());

Logger.Instance.PrintWithdrawLogs();
// Logger.Instance.PrintCardPurchaseLogs();
// Logger.Instance.PrintDepositLogs();



// new B();


