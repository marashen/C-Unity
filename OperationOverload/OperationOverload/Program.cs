using System;

namespace OperationOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee oper = new Employee(20, 20);
            oper = -oper;
        }
    }
    class Employee
    {
        int num1;
        int num2;
        public Employee(int num3, int num4)
        {
            num1 = num3;
            num2 = num4;
        }
        public static Employee operator -(Employee operations)
        {
            operations.num1 = -operations.num1;
            operations.num2 = -operations.num2;
            return operations;
        }
    } 
}
