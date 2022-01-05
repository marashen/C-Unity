using System;

namespace Boolin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age?");
            int age = 35;
            Console.WriteLine(age);
            bool dui = false;
            Console.WriteLine("Have you ever had a DUI?");
            Console.WriteLine(dui);
            Console.WriteLine("Tickets?");
            int tickets = 0;
            Console.WriteLine(tickets);
            Console.WriteLine("Qualified?");
            bool quals = (age >= 21 && tickets < 2 && !dui);
            Console.WriteLine(quals);
        }
    }
}