using System;

class Program
{
    static void Main()
    {
        // Creating a customer
        Customer customer = new Customer { CustomerID = 1, Name = "Alice", Email = "alice@example.com" };
        Console.WriteLine($"Customer Created: {customer.Name}");

        // Adding a product
        Product product = new Product { ProductID = 101, Name = "Laptop", Description = "High-end gaming laptop", Price = 1200.99, Stock = 5 };
        Console.WriteLine($"Product Added: {product.GetDetails()}");

        // Adding to shopping cart
        ShoppingCart cart = new ShoppingCart();
        cart.AddItem(product);
        Console.WriteLine($"Total Cart Value: ${cart.CalculateTotal()}");

        // Placing an order
        Order order = new Order { OrderID = 5001, CustomerID = customer.CustomerID, ItemsList = cart.ItemsList, TotalPrice = cart.CalculateTotal(), Status = "Pending" };
        order.PlaceOrder();
        order.TrackOrder();
    }
}
