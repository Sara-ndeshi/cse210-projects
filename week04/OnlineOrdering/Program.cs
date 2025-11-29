using System;

class Program
{
    static void Main(string[] args)
    {
        // --- FIRST ORDER ---
        Address addr1 = new Address("123 Apple St", "Provo", "UT", "USA");
        Customer cust1 = new Customer("John Smith", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Laptop", "A100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "B200", 25.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}\n");

        // --- SECOND ORDER ---
        Address addr2 = new Address("45 King Rd", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Emily Green", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("Phone", "C300", 650.00, 1));
        order2.AddProduct(new Product("Headphones", "D400", 80.00, 3));
        order2.AddProduct(new Product("Charger", "E500", 20.00, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}");
    }
}
