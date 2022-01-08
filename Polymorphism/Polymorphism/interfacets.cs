using System;

namespace Polymorphism
{
    public abstract class Person
    {
        string fName;
        string lName;
        public abstract void SayName(string fName, string lName);
    }
    public class Employee : IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("Yes");
        }
    }
    interface IQuittable
    {
        void Quit(); 
    }
}
