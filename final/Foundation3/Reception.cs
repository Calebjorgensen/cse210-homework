using System;

public class Reception : Event
{
    private string _place;

    public Reception(string title, string activity, string date, string time, Address address, string place) : base(title, activity, date, time, address)
    {
        _place = place;
    }

    public string GetPlace()
    {
        return _place;
    }

    public string ReturnEventType()
    {
        return "Reception";
    }

    public string GenerateDetailReception()
    {
        string detail = GenerateStandard() + "\n";
        detail += "Reception:" + _place;

        return detail;
    }
}