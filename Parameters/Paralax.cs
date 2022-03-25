using System;
using System.Collections.Generic;

namespace Parameters
{
    public abstract class Person
    {
        string fName;
        string lName;
        public abstract void SayName(string fName, string lName);
    }
    public class Employee<T>
    {
        public T things
        {
            get; set;
        }
    }
}
    
    