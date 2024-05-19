using System;
using System.Runtime.InteropServices;

public class ListingActivity : Activity
{
    private string [] _listingQuestion;
    private Random _rand;
    private List<string> _response;
    private string _user;


    //The block of Code is used to get the random prompts for the listing activity.
    public ListingActivity(): base("\nListing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){
        _rand = new Random();
        _listingQuestion = new string[]
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heros?"
        };
        _response = new List<string>();
    }

    //This is used from the base class of Activity.
    public void Start()
    {
        base.StartMessage();
    }


    // This is the code need to make the listing work.
    public void RunActivity(int time){
        Console.Clear();
        base.Countdown();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time+2);
        DateTime currentTime = DateTime.Now;
        int counter = 0;

        Console.WriteLine("For the follwing question, please enter as many responses as you can. Hit enter when done with one response! \n");
        int index = _rand.Next(_listingQuestion.Length);
        Console.WriteLine(_listingQuestion[index]);

        base.PauseAnimation(2);
        Console.WriteLine("Begin");
        while(currentTime<futureTime){
            counter++;
            Console.WriteLine($"Response #{counter}: ");
            _user = Console.ReadLine();
            _response.Add(_user);
            currentTime = DateTime.Now;
        };

        base.EndMessage($"Completed! You finished this activity in {time} seconds!");
        base.EndMessage($"\nHere are the responses for the following: {_listingQuestion[index]}");
        foreach (string i in _response){
            base.EndMessage(i);
        }
        Thread.Sleep(5000);
    }
}