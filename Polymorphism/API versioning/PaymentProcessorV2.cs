public class PaymentProcessorV2 : IpaymentProcess
{
  public override void process()
  {
    Console.WriteLine("Payment processsor from V2 is running");
  }
}