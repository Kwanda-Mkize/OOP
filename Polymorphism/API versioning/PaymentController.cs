using System.Diagnostics;

public class PaymentController
{

  public PaymentController() { }

  public void PaymentHandler(string version)
  {
    if (version == "v1")
    {
      IpaymentProcess Process = new PaymentProcessorV1();
      Process.process();

    }
    else
    {
      IpaymentProcess Process = new PaymentProcessorV2();
      Process.process();
    }

  }
}