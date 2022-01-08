using System;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods userIn = new Methods();
            int num1 = 115;
            userIn.mainmethod1(num1);
            float num2 = 4.5f;
            userIn.mainmethod2(num2);
            string num3 = "5";
            userIn.mainmethod3(num3);
        }
    }
}
