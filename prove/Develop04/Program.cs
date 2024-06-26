using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string choice;
        bool cont = true;
        int? breath = null;
        int? reflect = null;
        int? list = null;

        while(cont == true){
            Console.Clear();
            Console.WriteLine("Welcome to the mindfulness Program\n");
            Console.WriteLine("Choose one of the follwing: \n1: Breathing Activity\n2: Reflection Activity\n3: Listing Activity\n4: Quit\n");
            
            Console.WriteLine("You choose: ");
            choice = Console.ReadLine();

            switch(choice){
                case "1":
                Console.Clear();
                BreathingActivity breathing = new BreathingActivity();
                breathing.StartMessage();
                breath++;
                break;

                case "2":
                Console.Clear();
                ReflectionActivity reflecting = new ReflectionActivity();
                reflecting.StartMessage();
                reflect++;
                break;

                case "3":
                Console.Clear();
                list = 0;
                ListingActivity listing = new ListingActivity();
                listing.StartMessage();
                list++;
                break;

                case "4":
                Console.Clear();
                Console.WriteLine("Thank you for using our program!");
                if(breath.HasValue){
                    Console.WriteLine($"Breathing Activity: {breath} times");
                }
                
                if(reflect.HasValue){
                    Console.WriteLine($"Reflection Activity: {reflect} times");
                }

                if(list.HasValue){
                    Console.WriteLine($"Listing Activity: {list} times");
                }

                cont = false;
                break;
                default:
                Console.Clear();
                Console.WriteLine("You have enter an invalid option, please try again\n");
                Thread.Sleep(3000);
                Console.Clear();
                break;
            }
        }
    }
}