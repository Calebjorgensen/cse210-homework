using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenertor = new Random();
        int number = randomGenertor.Next(1,11);

        //This is a for loop in C#
        for (int i = 0;i<number;i++)
        {
            Console.WriteLine(i);
        }
    }
}