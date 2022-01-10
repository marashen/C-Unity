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
            int dts = DateTime.Now.TimeOfDay.Seconds;
            int dtm = DateTime.Now.TimeOfDay.Minutes;
            int dth = DateTime.Now.TimeOfDay.Hours;
            TimeSpan cT = new TimeSpan(dth, dtm, dts);
            Console.WriteLine("Current Time is " + cT);
            TimeSpan dt9 = new TimeSpan(dth + userDate, dtm, dts);
            Console.WriteLine(dt9);
        }
    }
}
