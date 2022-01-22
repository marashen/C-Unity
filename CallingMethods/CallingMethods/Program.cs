using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            TripleMethods userIn = new TripleMethods();

            Console.Write("Choose a number! ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(userIn.method1(num1));
            Console.WriteLine(userIn.method2(num1));
            Console.WriteLine(userIn.method3(num1));
        }
    }
}
