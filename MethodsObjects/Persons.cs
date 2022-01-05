using System;
namespace MethodsObjects
{
    public class Persons
    {
        public string FirstName;
        public string LastName;
        public bool HasPet;

        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}