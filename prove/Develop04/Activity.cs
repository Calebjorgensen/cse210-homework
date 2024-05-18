using System;

public abstract class Activity
{
    protected int _duration;
    protected string _description;
    protected string _name;

    public Activity(string name, string description)
    {
        this._name = name;
        this._description = description;
    }

    public void StartMessage(){
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine("Please enter the the time in seconds you want to do this activity: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("You will do this activity for " +_duration+" seconds!\n");

        if(GetType().Name == "BreathingActivity"){
            BreathingActivity breathing = new BreathingActivity();
            breathing.RunActivity(_duration);
        }

        else if(GetType().Name == "ReflectionActivity"){
            ReflectionActivity reflection = new ReflectionActivity();
            reflection.RunActivity(_duration);
        }

        else if(GetType().Name == "ListingActivity"){
            ListingActivity listing = new ListingActivity();
            listing.RunActivity(_duration);
        }
    }

    public void Countdown(){
        Console.WriteLine("This program will begin in ..");
        Console.WriteLine("5");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
        Console.WriteLine("4");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
        Console.WriteLine("3");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
        Console.WriteLine("2");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
        Console.WriteLine("1");
        Thread.Sleep(1000);
        Console.WriteLine("\b \b");
        Console.WriteLine("Begin!");
    }

    public PauseAnimation(int timer){
        int x = 0;
        while(x != timer){
            Console.WriteLine("/");
            Thread.Sleep(250);
            Console.WriteLine("\b \b");
            Console.WriteLine("-");
            Thread.Sleep(250);
            Console.WriteLine("\b \b");
            Console.WriteLine("\\");
            Thread.Sleep(250);
            Console.WriteLine("\b \b");
            Console.WriteLine("|");
            Thread.Sleep(250);
            Console.WriteLine("\b \b");
            x++;
        }
    }

    public void EndMessage(string end){
        Console.WriteLine(end);
    }
}