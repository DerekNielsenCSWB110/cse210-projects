using System;

class Program
{
    static void Main()
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Derek Nielsen", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Notebook", "P100", 3.50, 4));
        order1.AddProduct(new Product("Pen Pack", "P200", 5.00, 2));

        DisplayOrder(order1);

        // Order 2 (International)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alex Morgan", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Backpack", "P300", 45.00, 1));
        order2.AddProduct(new Product("Water Bottle", "P400", 12.00, 2));

        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
        Console.WriteLine(new string('-', 40));
    }
}