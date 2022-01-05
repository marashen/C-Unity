using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;


namespace MethodsObjects
{
    class MainClass
    {
     public static void Main(string[] args)
        {
            Employee John = new Employee();

            John.FirstName = "John";
            John.LastName = "Jahn";
            John.emId = 31415;

            John.SayName();
        }
    }
}