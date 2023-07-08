using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    public Customer Customer { get; set; }

    public Order()
    {
        products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public string GetPackingLabel()
    {
        string label = "";
        foreach (Product product in products)
        {
            label += $"Name: {product.Name}, Product ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return "Name: " + Customer.Name + "\n" + Customer.Address.GetAddressString();
    }

    public double CalculateTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }
        totalPrice += Customer.Address.IsInUSA() ? 5 : 35; // Shipping cost
        return totalPrice;
    }
}
