using System;
using System.Collections.Generic;

public class ShoppingCart
{
    public int CartID { get; set; }
    public int CustomerID { get; set; }
    public List<Product> ItemsList { get; set; }

    public ShoppingCart()
    {
        ItemsList = new List<Product>();
    }

    public void AddItem(Product product) => ItemsList.Add(product);
    public void RemoveItem(Product product) => ItemsList.Remove(product);
    public double CalculateTotal()
    {
        double total = 0;
        foreach (var item in ItemsList) total += item.Price;
        return total;
    }
}
