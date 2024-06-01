using System;
using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> prodcuts, Customer customer)
    {
        _products = prodcuts;
        _customer = customer;
    }

    public double CalculateTotalPrice()
    {
        double totalprice = 0;

        foreach (Product p in _products)
        {
            double price = p.CalculatePrice();
            totalprice += price;
        }
        double shippingCost = 0;
        if (_customer.isFromUSA()  == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        totalprice += shippingCost;

        return totalprice;
    }

    public string GeneratePackLabel()
    {
        string packlabel = "Packing Label\n";
        foreach (Product p in _products)
        {
            packlabel += p.GetName() + " " + p.GetProductCode() + "\n";
        }
        return packlabel;
    }

    public string GenerateShipLabel()
    {
        string shiplabel = "shipping label\n";
        shiplabel += _customer.GetName() + "\n" + _customer.GenerateAddress();
        return shiplabel;
    }

    public void DisplayResults()
    {
        Console.WriteLine();

        string packlabel = GeneratePackLabel();
        string shiplabel = GenerateShipLabel();
        double totalPrice = CalculateTotalPrice();

        Console.WriteLine(shiplabel);
        Console.WriteLine(packlabel);
        Console.WriteLine($"Total Cost ${totalPrice}");
        Console.WriteLine();
    }
}