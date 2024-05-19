using System;

public class BreathingActivity : Activity{
    public BreathingActivity() : base("\nBreathing Activty", "This activity will help you relax by walking your through breathing in  and out slowly. Clear your mind and focus on your breathing.\n")
    {

    }
    
    //This code block is connect to the base activity part of the code. 
    public void Start()
    {
        base.StartMessage();
    }

    public void RunActivity(int time){
        Console.Clear();
        base.Countdown();
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        while(currentTime < futureTime)
        {
            Console.WriteLine("Breath in ...");
            //First second on the breath in part
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
            //First second on the breath out part. 
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