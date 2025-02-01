using System;

public class Payment
{
    public int PaymentID { get; set; }
    public int OrderID { get; set; }
    public double Amount { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }

    public void ProcessPayment()
    {
        Status = "Completed";
        Console.WriteLine($"Payment {PaymentID} processed.");
    }

    public void RefundPayment()
    {
        Status = "Refunded";
        Console.WriteLine($"Payment {PaymentID} refunded.");
    }
}
