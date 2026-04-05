namespace HelloCSharp;
class Order
{
  public int OrderID { get; set; }
  public string CustomerName { get; set; }
  public double Total { get; private set; }

  public Order(int orderId, string customerName, double total)
  {
    OrderID = orderId;
    CustomerName = customerName;
    Total = total;
  }

  public void ApplyDiscount(double percentage)
  {
    Total -= Total * (percentage / 100);
  }

  public void PrintSummary()
  {
    Console.WriteLine($"Order ID: {OrderID}");
    Console.WriteLine($"Customer Name: {CustomerName}");
    Console.WriteLine($"Total: {Total:C}");
  }

}