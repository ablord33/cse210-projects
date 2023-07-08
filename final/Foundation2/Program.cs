using System;

class Program
{
    static void Main(string[] args)
    {
        // Create two sample orders
        Order order1 = new Order();
        order1.AddProduct(new Product("Product1", "P001", 10.99, 2));
        order1.AddProduct(new Product("Product2", "P002", 5.99, 1));
        order1.Customer = new Customer("John Doe", new Address("123 Main St", "New York", "NY", "USA"));

        Order order2 = new Order();
        order2.AddProduct(new Product("Product3", "P003", 15.99, 3));
        order2.AddProduct(new Product("Product4", "P004", 8.99, 2));
        order2.Customer = new Customer("Jane Smith", new Address("456 Elm St", "Toronto", "ON", "Canada"));

        // Calculate and display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.CalculateTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.CalculateTotalPrice());

        Console.ReadLine();
    }
}
