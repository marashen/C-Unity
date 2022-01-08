using System;

namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Person sVar;
            sVar = new Employee();
            string firstN = "sample";
            string lastN = "student";
            sVar.SayName(firstN, lastN);
        }
    }
}
