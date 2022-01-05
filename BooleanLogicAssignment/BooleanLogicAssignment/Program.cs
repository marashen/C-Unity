using System;

namespace Boolin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Age?");
            string ageIn = Console.ReadLine();
            int age = Convert.ToInt32(ageIn);
            Console.WriteLine(age);
            int looper = 1;
            while (looper == 1)
            {
                Console.WriteLine("Have you ever had a DUI? Please respond yes or no.");
                string duiIn = Console.ReadLine();
                if (duiIn == "yes")
                {
                    bool dui = true;
                    Console.WriteLine(dui);
                    looper -= 1;
                }
                else if (duiIn == "no")
                {
                    bool dui = false;
                    Console.WriteLine(dui);
                    looper -= 1;
                }
                else
                {
                    Console.WriteLine("please enter 'yes' or 'no'");
                }
            }
            Console.WriteLine("Number of Tickets?");
            string tickIn = Console.ReadLine();
            int tickets = Convert.ToInt32(tickIn);
            Console.WriteLine(age);
            Console.WriteLine(tickets);
            Console.WriteLine("Qualified?");
            bool quals = (age >= 21 && tickets < 2);
            Console.WriteLine(quals);
        }
    }
}