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
            int looper = 1;
            while (looper <= 10)
            {
                empid.Add(looper);
                looper++;
            }
            foreach (string i in employees)
            {
                Console.WriteLine("-    " + i);
                bool duped = employees2.Any(s => s.Contains(i));
                if (duped == false)
                {
                    Console.WriteLine("No Repeats");
                }
                else if (duped == true)
                {
                    Console.WriteLine("Oh Mr. " + i + "!");
                    joeschmo.Add(i);

                }
                employees2.Add(i);
            }
            var zeta = new List<int[]>
            {
                new[] { 6, 7, 8, 9, 10 }
            };

            var iota =
                from zetaS in zeta
                where zetaS.Count(n => n > 0) > 5
                select zetaS;

            foreach (var zetaS in iota)
            {
                oclockV.Add(zetaS);
            }
                List<int> list = empid.FindAll(e => (e > 5)).Take(5).ToList();
                for (int i = 0; i < list.Count; i++)
                {
                    int greater = list[i];
                    oclock.Add(greater);
                }
                

                
            Console.WriteLine("JoeSchmo List:");
            foreach (string b in joeschmo)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Greater than 5 List");
            foreach (int a in oclock)
            {
                Console.WriteLine(a);
            }
        }
    }
}