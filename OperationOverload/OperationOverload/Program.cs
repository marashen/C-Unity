using System;

namespace OperationOverload
{

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee oper = new Employee();
            oper.ID = 115;

            Employee oper2 = new Employee();
            oper2.ID = 114;

            Console.WriteLine(oper.ID == oper2.ID);
        }
    }
    class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            if (employee.ID == employee2.ID)
                return true;
            else
                return employee.ID == employee2.ID;
        }

        public static bool operator !=(Employee employee, Employee employee2)
        {
            return employee.ID != employee2.ID;
        }

        public override bool Equals(object obj)
        {
            var emp = obj as Employee;
            if (emp == null)
                return false;

            return this.ID.Equals(emp.ID);
        }
    }
}
