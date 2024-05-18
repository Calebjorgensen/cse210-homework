using System;

public class BreathingActivity : Activity{
    public BreathingActivity() : base("\nBreathing Activty", " This Activty will help oyu relax\n")
    {

    }
    public void Start()
    {
        base.StartMessage();
    }

    public void RunActivity(int time){
        Console.Clear();
        base.Countdown();
        Console.Clear();
        DateTime startTime = DateTime.Now();
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime)
        {
            Console.WriteLine("Breath in ...");
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("Breath out...");
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            currentTime = DateTime.Now;
        }

        base.EndMessage($"Finished, you completed this take in {time} seconds");
        Thread.Sleep(3000);
        Console.Clear();
    }
}