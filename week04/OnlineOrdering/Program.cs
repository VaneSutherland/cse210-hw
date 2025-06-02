using System;
using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Provo", "UT", "USA");
        Customer customer1 = new Customer("John Green", address1);

        Address address2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);

        Product prod1 = new Product("Notebook", "NB123", 3.99, 2);
        Product prod2 = new Product("Pen", "PEN456", 1.49, 5);

        Product prod3 = new Product("Headphones", "HD789", 25.99, 1);
        Product prod4 = new Product("Charger", "CH321", 15.00, 2);

        Order order1 = new Order(customer1);
        order1.AddProduct(prod1);
        order1.AddProduct(prod2);

        Order order2 = new Order(customer2);
        order2.AddProduct(prod3);
        order2.AddProduct(prod4);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
