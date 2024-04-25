using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        int numbers = -1;

        while(numbers != 0)
        {
            Console.WriteLine("Enter a number(0 to quit)");

            string userInput = Console.ReadLine();
            numbers = int.Parse(userInput);

            if(numbers != 0)
            {
                numberList.Add(numbers);
            }
        }
        int sum = 0;
        foreach(int number in numberList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numberList.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numberList[0];
        foreach(int number in numberList)
        {
            if(number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");
    }

    
}