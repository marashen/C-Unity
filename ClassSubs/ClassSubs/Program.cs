using System;

namespace ClassSubs
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassyMath vclassy = new ClassyMath();
            Console.WriteLine("Choose a number!");
            int userN = Convert.ToInt32(Console.ReadLine());
            vclassy.method1(userN);
        }
    }
}
