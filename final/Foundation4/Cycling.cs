using System;

public class Bicycles : Exercise
{
    private double _speed;
    public Bicycles(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Bicycles";
        _speed = speed;
    }

    public override double CalculateSpeed()
    {
        return _speed;
    }

    public override double CalculateDistance()
    {
        double distance = _speed * _minutes / 60;
        return distance;
    }

    public override double CalculatePace()
    {
        double pace = 60 / _speed;
        return pace;
    }
}