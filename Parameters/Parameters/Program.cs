using System;
using System.Collections.Generic; 

namespace Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> types = new Employee<string>();
            types.things = "1 string";
            types.things = "2 string";
            types.things = "red string";
            types.things = "blue string";
            Employee<int> type5 = new Employee<int>();
            type5.things = 1;
            type5.things = 2;
            foreach (char i in types.things)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(type5);
        }
    }
}
