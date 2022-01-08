using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            TripleMethods userIn = new TripleMethods();

            Console.WriteLine("Choose a number!");
            int num1 = Convert.ToInt32(Console.ReadLine());
            userIn.method1(num1);
            userIn.method2(num1);
            userIn.method3(num1);
        }
    }
}
