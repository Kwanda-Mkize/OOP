public class PaymentProcessorV1 : IpaymentProcess
{
  public override void process()
  {
    Console.WriteLine("Payment Processor from V1 is running");
  }
}