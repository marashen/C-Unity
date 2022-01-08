using System;
namespace MainMethod
{
    public class Methods
    {
        int x;
        float y;
        int stringN;
        public void mainmethod1(int x)
        {
            x += 73;
            Console.WriteLine(x);
        }
        public void mainmethod2(float y)
        {
            y += 216.45f;
            Console.WriteLine(y);
        }
        public void mainmethod3(string z)
        {
            Console.WriteLine("Choose a number!");
            z = Console.ReadLine();
            int stringN = Convert.ToInt32(z);
            stringN += 42;
            Console.WriteLine("Your number + 42 = " + stringN);
        }
    }
}
