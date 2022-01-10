using System;

namespace DatetimeSubs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);
            var dateT4 = "1/08/2022";

            var dateT1 = DateTime.TryParse(dateT4, out dt);
            if (dateT1)
            {
                Console.WriteLine(dt);
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.WriteLine("Choose a number!");
            int userDate = Convert.ToInt32(Console.ReadLine());
            var dt8 = DateTime.Now.TimeOfDay;
            TimeSpan dt9 = new TimeSpan(0, userDate, userDate, userDate);
            Console.WriteLine(dt8 + dt9);
        }
    }
}
