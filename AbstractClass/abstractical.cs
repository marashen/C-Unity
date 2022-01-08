using System;
namespace AbstractClass
{
    public abstract class Person
    {
        string fName;
        string lName;
        public abstract void SayName(string fName, string lName);
    }
    public class Employee : Person
    {
        public override void SayName(string fName, string lName)
        {
            Console.WriteLine(fName + " " + lName);
        }
    }
}
