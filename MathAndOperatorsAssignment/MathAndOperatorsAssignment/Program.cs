using System;

namespace MathAndOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string pr1 = Console.ReadLine();
            int person1rate = Convert.ToInt32(pr1);
            Console.WriteLine(person1rate);
            Console.WriteLine("Hours Worked?");
            string ph1 = Console.ReadLine();
            int person1hours = Convert.ToInt32(ph1);
            Console.WriteLine(person1hours);
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string pr2 = Console.ReadLine();
            int person2rate = Convert.ToInt32(pr2);
            Console.WriteLine(person2rate);
            Console.WriteLine("Hours Worked?");
            string ph2 = Console.ReadLine();
            int person2hours = Convert.ToInt32(ph2);
            Console.WriteLine(person2hours);
            Console.WriteLine("Annual Salary Person 1:");
            int person1W = person1rate * person1hours;
            double person1Y = person1W * 52.1429;
            Console.WriteLine(person1Y);
            Console.WriteLine("Annual Salary Person 2:");
            int person2W = person2rate * person2hours;
            double person2Y = person2W * 52.1429;
            Console.WriteLine(person2Y);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool higherS = person1Y > person2Y;
            Console.WriteLine(higherS);
        }
    }
}