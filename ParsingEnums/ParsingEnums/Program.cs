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

            bool isWeek;

            try
            {
                string weekV = Console.ReadLine();
                if (weekV.Length >= 6)
                {
                    isWeek = true;
                }                
                Weeks weekly = (Weeks)Weeks.Parse(typeof(Weeks), weekV);
            }
            catch (Exception)
            {
                isWeek = false;
            }
        }
    }
}
