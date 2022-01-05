using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("The Current Time is " + DateTime.Now);
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("Name?");
            string userName = Console.ReadLine();
            Console.WriteLine("Course?");
            string userCourse = Console.ReadLine();
            Console.WriteLine("Page?");
            string userPage = Console.ReadLine();
            Console.WriteLine("Do you need help?");
            string userHelp = Console.ReadLine();
            Console.WriteLine("Positive experiences?");
            string userExp = Console.ReadLine();
            Console.WriteLine("Feedback?");
            string userFeed = Console.ReadLine();
            Console.WriteLine("Hours studied?");
            string userStudy = Console.ReadLine();
            Console.WriteLine("Thank you!");
        }
    }
}