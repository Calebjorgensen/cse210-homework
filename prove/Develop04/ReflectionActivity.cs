using System;

public class ReflectionActivity : Activity
{
    private Random _rand;
    private string[] _prompt;
    private string[] _reflectionQuestions;

    public ReflectionActivity() : base("\nReflectionActivity", "This activity will help you reflect on times in your life when you have shown strength.")
    {
        _rand = new Random();
        _prompt = new string[]
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really diffficult"
        };

        _reflectionQuestions = new string[]
        {
            "Why was this experience meaningful yo you?",
            "Have you ever done anyring like this before?"
        };
    }

    public void Start()
    {
        base.StartMessage();
    }

    public string GetPrompt()
    {
        int index = _rand.Next(_prompt.Length);
        return _prompt[index];
    }

    public void RunActivity(int time)
    {
        Console.Clear();
        base.Countdown();
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        DateTime currentTime = DateTime.Now;

        Console.WriteLine(GetPrompt() + "\n");
        Console.WriteLine("As you relfect on this moment in time,");
        base.PauseAnimtion(3);
        while(currentTime < futureTime){
            int index = _rand.Next(_reflectionQuestions.Length);
            if(index >= 0 && index < _reflectionQuestions.Length){
                string question = _reflectionQuestions[index];
                Console.WriteLine("\n" +question);
            }

            base.PauseAnimation(5);
            currentTime = DateTime.Now;
        }

        base:EndMessage($"Finished");
        Thread.Sleep(3000);
        Console.Clear();
    }
}