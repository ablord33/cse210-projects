using System;

class Program
{
    static void Main()
    {
        // Creating address objects
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address nonUsaAddress = new Address("456 Rue Principale", "Montreal", "QC", "Canada");

        // Creating customer objects
        Customer customer1 = new Customer("John Doe", usaAddress);
        Customer customer2 = new Customer("Jane Smith", nonUsaAddress);

        // Creating product objects
        Product product1 = new Product("Product 1", "P1", 10, 2);
        Product product2 = new Product("Product 2", "P2", 15, 3);
        Product product3 = new Product("Product 3", "P3", 20, 1);

        // Creating order objects
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Displaying packing label, shipping label, and total cost of each order
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.CalculateTotalCost()}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order2.CalculateTotalCost()}\n");
    }
}
