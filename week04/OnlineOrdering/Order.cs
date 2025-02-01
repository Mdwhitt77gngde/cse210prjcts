using System;
using System.Collections.Generic;

public class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public List<Product> ItemsList { get; set; }
    public double TotalPrice { get; set; }
    public string Status { get; set; }

    public void PlaceOrder()
    {
        Status = "Placed";
        Console.WriteLine($"Order {OrderID} placed.");
    }

    public void CancelOrder()
    {
        Status = "Cancelled";
        Console.WriteLine($"Order {OrderID} cancelled.");
    }

    public void TrackOrder() => Console.WriteLine($"Order {OrderID} is {Status}.");
}
