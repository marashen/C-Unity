﻿using System;

namespace MathLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 45.45;
            while (num1 > 1)
            {
                Console.WriteLine(num1);
                num1 = num1 / 2;
            }
            int num2 = 112;
            do
            {
                Console.WriteLine(num2);
                num2++;
            }
            while (num2 < 115);
        }
    }
}