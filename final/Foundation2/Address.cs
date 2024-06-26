using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GenerateAddress()
    {
        string address = _street + "," + _city + "\n" + _state + "," + _country;
        return address;
    }

    public bool isUSA()
    {
        if(_country == "usa"){
            return true;
        }
        else{
            return false;
        }
    }
}