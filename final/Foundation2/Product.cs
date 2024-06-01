using System;

public class Product
{
    private string _name;
    private string _productCode;
    private double _price;
    private int _quantity;

    public Product(string name, string productCode, double price, int quantity)
    {
        _name = name;
        _productCode = productCode;
        _price = price;
        _quantity = quantity;
    }

    public double CalculatePrice()
    {
        return _price * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetProductCode()
    {
        return _productCode;
    }
}