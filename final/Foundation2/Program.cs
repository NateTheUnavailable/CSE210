using System;
using System.Collections.Generic;

class Product
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

    public double GetTotalCost()
    {
        return Price * Quantity;
    }
}

class Address
{
    public string StreetAddress { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string Country { get; set; }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{StreetAddress}, {City}, {StateProvince}, {Country}";
    }
}

class Customer
{
    public string Name { get; set; }
    public Address Address { get; set; }

    public bool IsInUSA()
    {
        return Address.IsInUSA();
    }
}

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }

        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (var product in products)
        {
            label += $"Name: {product.Name} - Product ID: {product.ProductId}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\nCustomer: {customer.Name}\nAddress: {customer.Address.GetFullAddress()}";
    }
}

class Program
{
    static void Main()
    {
        Address address1 = new Address
        {
            StreetAddress = "123 Main St",
            City = "Anytown",
            StateProvince = "CA",
            Country = "USA"
        };

        Customer customer1 = new Customer
        {
            Name = "John Doe",
            Address = address1
        };

        Product product1 = new Product
        {
            Name = "Product A",
            ProductId = 1,
            Price = 10.5,
            Quantity = 3
        };

        Product product2 = new Product
        {
            Name = "Product B",
            ProductId = 2,
            Price = 20.75,
            Quantity = 2
        };

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        // Create another order
        // Add more orders and products as needed
    }
}