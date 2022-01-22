using System;

namespace ParsingEnums
{
    class Program
    {
        enum Weeks
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
                Console.WriteLine("Please choose a day of the week!");
                string weekV = Console.ReadLine();
                Weeks weekly = (Weeks)Weeks.Parse(typeof(Weeks), weekV);
        }
    }
}
