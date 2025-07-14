public abstract class Adapter
{
  public abstract void Execute();

  private void StartTransction()
  {
    Console.WriteLine("Transaction started");
  }
  private void CommitTransction()
  {
    Console.WriteLine("Transaction Committed");
  }
  private void RollbackTransction()
  {
    Console.WriteLine("Transaction Rolledback");
  }

  public void PerfomActivity()
  {
    try
    {
      StartTransction();
      Execute();
      CommitTransction();

    }
    catch (Exception ex)
    {
      RollbackTransction();
      Console.WriteLine(ex.Message);
      
    }
  }
}