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
            int looper = 1;
            while (looper == 1)
            {
                Console.WriteLine("Please choose a day of the week!");
                string weekV = Console.ReadLine();
                if (weekV == "Sunday" || weekV == "sunday")
                {
                    Weeks weekly = Weeks.Sunday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else if (weekV == "Monday" || weekV == "monday")
                {
                    Weeks weekly = Weeks.Monday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else if (weekV == "Tuesday" || weekV == "tuesday")
                {
                    Weeks weekly = Weeks.Tuesday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else if (weekV == "Wednesday" || weekV == "wednesday")
                {
                    Weeks weekly = Weeks.Wednesday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else if (weekV == "Thursday" || weekV == "thursday")
                {
                    Weeks weekly = Weeks.Thursday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else if (weekV == "Friday" || weekV == "friday")
                {
                    Weeks weekly = Weeks.Friday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else if (weekV == "Saturday" || weekV == "saturday")
                {
                    Weeks weekly = Weeks.Saturday;
                    string weeklyS = weekly.ToString();
                    Console.WriteLine(weeklyS);
                    looper -= 1;
                }
                else
                {
                    Console.WriteLine("Please enter a value of the week!");
                }
            }
        }
    }
}
