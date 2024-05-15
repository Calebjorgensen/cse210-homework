using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please enter your first number: ");
        int num1;

        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter your second number: ");
        int num2;
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What mathmaic are ar your preforming? + , - , * , / ");
        string answer;
        answer = Console.ReadLine();

        if(answer == "+")
        {
            int addAnswer = num1 + num2;
            Console.WriteLine(addAnswer);
        }
        else if(answer == "-")
        {
            int subAnswer = num1 - num2;
            Console.WriteLine(subAnswer);
        }
        else if(answer == "*")
        {
            int mulAnswer = num1 * num2;
            Console.WriteLine(mulAnswer);
        }
        else if(answer == "/")
        {
            int divAnswer = num1 / num2;
            Console.WriteLine(divAnswer);
        }
        else
        {
            Console.WriteLine("invalid repsonse, try again.");
        }
       
    }
  
}