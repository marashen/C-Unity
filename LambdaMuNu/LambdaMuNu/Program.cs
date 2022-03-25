using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaOmicron
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> employees = new List<string>(10);
            List<int> empid = new List<int>(10);
            List<string> employees2 = new List<string>(10);
            List<int> empid2 = new List<int>(10);
            List<string> joeschmo = new List<string>(2);
            List<int> oclock = new List<int>(5);
            List<int[]> oclockV = new List<int[]>(5);
            employees.Add("Joe");
            employees.Add("Hannah");
            employees.Add("Izzy");
            employees.Add("Joe");
            employees.Add("Petra");
            employees.Add("Dave");
            employees.Add("Pam");
            employees.Add("Chris");
            employees.Add("Joe");
            employees.Add("Damasen");

            List<string> joeList = new List<string>();

            foreach (string emp in employees)
            {
                if (emp == "Joe")
                {
                    joeList.Add(emp);
                }
            }

            List<string> joeList2 = employees.Where(x => x == "Joe").ToList();

            int looper = 1;
            while (looper <= 10)
            {
                empid.Add(looper);
                looper++;
            }

            List<int> IDList = empid.Where(x => x >= 5).ToList();

            foreach (string i in joeList)
            {
                Console.WriteLine(i);
            }
            foreach (string i2 in joeList2)
            {
                Console.WriteLine(i2);
            }
            foreach (int j in IDList)
            { 
                Console.WriteLine(j);
            }
        }
    }
}