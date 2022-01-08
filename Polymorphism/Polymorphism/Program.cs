using System;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable sVar;
            sVar = new Employee();
            sVar.Quit();
        }
    }
}