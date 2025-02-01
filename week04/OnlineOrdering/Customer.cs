using System;

public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string PaymentInfo { get; set; }

    public void Register() => Console.WriteLine($"{Name} registered.");
    public void Login() => Console.WriteLine($"{Name} logged in.");
    public void Logout() => Console.WriteLine($"{Name} logged out.");
    public void UpdateDetails(string newEmail) => Email = newEmail;
}
