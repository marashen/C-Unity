using System;

namespace CallingMethods
{
    public class TripleMethods
    {
        public int para1;
        public int para2;
        public int para3;
        public void method1(int para1)
        {
            para1 += 9;
            Console.WriteLine("Method 1 number (+9) = " + para1);
        }
        public void method2(int para2)
        {
            para2 -= 14;
            Console.WriteLine("Method 2 number (-14) = " + para2);
        }
        public void method3(int para3)
        {
            para3 += 2;
            Console.WriteLine("Method 3 number (+2) = " + para3);
        }
    }
}
