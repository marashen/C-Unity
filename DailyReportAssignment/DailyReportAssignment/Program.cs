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
            _ = Convert.ToInt32(userPage);
            Console.WriteLine("Do you need help?");
            string userHelp = Console.ReadLine();
            int looper = 1;
            while (looper == 1)
            {
                if (userHelp == "yes" || userHelp == "yes")
                {
                    userHelp = "true";
                    _ = Convert.ToBoolean(userHelp);
                    looper -= 1;

                }
                else if (userHelp == "no" || userHelp == "No")
                {
                    userHelp = "false";
                    _ = Convert.ToBoolean(userHelp);
                    looper -= 1;
                }
                else
                {
                    Console.WriteLine("Please enter Yes or No.");
                }
            }
            Console.WriteLine("Positive experiences?");
            string userExp = Console.ReadLine();
            Console.WriteLine("Feedback?");
            string userFeed = Console.ReadLine();
            Console.WriteLine("Hours studied?");
            string userStudy = Console.ReadLine();
            _ = Convert.ToInt32(userStudy);
            Console.WriteLine("Thank you!");
        }
    }
}