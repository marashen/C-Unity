using System;

namespace OperationOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Operator oper = new Operator(20, 20);
            oper = -oper;
        }
    }
    class Operator
    {
        int num1;
        int num2;
        public Operator(int num3, int num4)
        {
            num1 = num3;
            num2 = num4;
        }
        public static Operator operator -(Operator operations)
        {
            operations.num1 = -operations.num1;
            operations.num2 = -operations.num2;
            return operations;
        }
    } 
}
