using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("4821 Maple Ridge Drive", "Austin", "Texas", "USA");
        Address address2 = new Address("12 Admiralty Way", "Lekki", "Lagos", "Nigeria");
        Address address3 = new Address("915 Brookstone Avenue", "Columbs", "Ohio", "USA");
        Address address4 = new Address("77 Kingfisher Crescent", "Manchester", "Greater Manchester", "UK");


        Customer customer1 = new Customer("Michael Anderson", address1);
        Customer customer2 = new Customer("Chinedu Okafor", address2);
        Customer customer3 = new Customer("Olivia Martinez", address3);
        Customer customer4 = new Customer("Daniel Thompson", address4);

        Order order1 = new Order(customer1);
        Order order2 = new Order(customer2);
        Order order3 = new Order(customer3);
        Order order4 = new Order(customer4);

        Product product1 = new Product("Wireless Bluetooth Headphones", "PRD-1047", 29.99, 15);
        Product product2 = new Product("Stainless Steel Water Bottle (1L)", "PRD-2083", 12.50, 40);
        Product product3 = new Product("USB-C Fast Charging Cable", "PRD-3321", 8.99, 75);
        Product product4 = new Product("Portable Power Bank (10,000mAh)", "PRD-4596", 24.75, 22);
        Product product5 = new Product("Smart LED Desk Lamp", "PRD-5172", 18.40, 28);
        Product product6 = new Product("Wireless Mouse (Ergonomic)", "PRD-6239", 14.99, 35);
        Product product7 = new Product("64GB Flash Drive USB 3.0", "PRD-7815", 11.25, 60);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);
        order1.AddProduct(product4);

        order2.AddProduct(product5);
        order2.AddProduct(product6);
        order2.AddProduct(product7);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("--------------------");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("--------------------");
        Console.WriteLine($"Total Cost: ${order1.CalTotalCost()}");
        Console.WriteLine("--------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("--------------------");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("--------------------");
        Console.WriteLine($"Total Cost: ${order2.CalTotalCost()}");
        Console.WriteLine("--------------------");
    }
}