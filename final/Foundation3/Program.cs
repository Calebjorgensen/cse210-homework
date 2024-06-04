using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Address address = new Address("832 fake street,", "city", "OR", "USA");

        Lecture lecture = new Lecture("Cars", "PG", "6-10-24", "8PM", address, "Caleb", 200);

        Console.WriteLine("Event 1");

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());
        Console.WriteLine();

        Address address1 = new Address("A-1 warehouse", "743 not his lane", "CA", "USA");
        Reception reception = new Reception("Boogie Dance", "Bring your dancing shoes", "8am -", "12pm", address, "The Johnsons");

        Console.WriteLine("Event 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());
        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailReception());
    }
}