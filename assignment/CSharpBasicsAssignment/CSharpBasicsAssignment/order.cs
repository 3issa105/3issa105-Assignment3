public class Order
{
    // Exactly 10 concrete-typed fields (no object type)
    public int OrderId;
    public string CustomerName;
    public int Quantity;
    public decimal UnitPrice;
    public decimal TotalPrice;
    public bool IsPaid;
    public double DiscountPercent;
    public string ShippingCity;
    public char Priority;
    public long ItemCode;

    // Method 1: Computes TotalPrice based on Quantity, UnitPrice, and DiscountPercent
    public void CalculateTotal()
    {
        TotalPrice = Quantity * UnitPrice * (decimal)(1 - (DiscountPercent / 100));
    }

    // Method 2: Prints a one-line summary of the order
    public void PrintSummary()
    {
        Console.WriteLine($"Order #{OrderId} | Customer: {CustomerName} | Total: ${TotalPrice} | Paid: {IsPaid}");
    }
}