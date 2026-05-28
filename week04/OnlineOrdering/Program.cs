using System;

class Program
{
    static void Main(string[] args)
    {
        // First Customer (USA)
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "10001",
            "USA"
        );

        Customer customer1 = new Customer("John Smith", address1);

        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Laptop", "P100", 800, 1));
        order1.AddProduct(new Product("Mouse", "P101", 25, 2));
        order1.AddProduct(new Product("Keyboard", "P102", 45, 1));

        // Second Customer (Outside USA)
        Address address2 = new Address(
            "45 Queen Road",
            "Toronto",
            "Ontario",
            "M5V 2T6",
            "Canada"
        );

        Customer customer2 = new Customer("Emily Johnson", address2);

        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Phone", "P200", 600, 1));
        order2.AddProduct(new Product("Charger", "P201", 20, 3));

        // Display Order 1
        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine();

        // Display Order 2
        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}