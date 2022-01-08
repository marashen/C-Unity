using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;


namespace MoreMethods
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ManyMews newNum = new ManyMews();

            newNum.x = 6;
            newNum.y = 8;
            int num1 = 1;
            int num2 = 3;

            newNum.DoMath(num1, num2);
        }
    }
}