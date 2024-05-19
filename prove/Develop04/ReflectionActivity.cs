using System;

public class ReflectionActivity : Activity
{
    private Random _rand;
    private string[] _prompt;
    private string[] _reflectionQuestions;

    public ReflectionActivity() : base("\nReflectionActivity", "This acticiyt will help you relfect on times in your life when you have shown strength and resilience. This will help you recongnixe the power you have and how you can use it in other aspects of your life.")
    {
        _rand = new Random();
        _prompt = new string[]
        {
            "Think of a time when you stood up for someone else",
            "Think of a time when you did something really diffficult",
            "Think of a time when you helped someone in need",
            "Think of a time when you did something truly selfless"
        };

        _reflectionQuestions = new string[]
        {
            "Why was this experience meaningful yo you?",
            "Have you ever done anyring like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What mnade this time different than other tiumes when you were not as successful?",
            "What is your favorite thing aboue this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourseld through this experience?",
            "How can you keep this experience in mind in the future?"
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
        base.PauseAnimation(3);
        while(currentTime < futureTime){
            int index = _rand.Next(_reflectionQuestions.Length);
            if(index >= 0 && index < _reflectionQuestions.Length){
                string question = _reflectionQuestions[index];
                Console.WriteLine("\n" +question);
            }

            base.PauseAnimation(5);
            currentTime = DateTime.Now;
        }
        base.EndMessage($"Finsihed you completed this task in {time} seconds");
        Thread.Sleep(3000);
        Console.Clear();
    }
}