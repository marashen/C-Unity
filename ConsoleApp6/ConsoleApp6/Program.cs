using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> moons = new List<string>(7);
            List<string> moons2 = new List<string>(7);
            moons.Add("Luna");
            moons.Add("Titan");
            moons.Add("Ganymede");
            moons.Add("Luna");
            moons.Add("Phobos");
            moons.Add("Deimos");
            moons.Add("Io");
            foreach (string i in moons)
            {
                Console.WriteLine("-    " + i);
                bool duped = moons2.Any(s => s.Contains(i));
                if (duped == false)
                {
                    Console.WriteLine("No Repeats");
                }
                else if (duped == true)
                {
                    Console.WriteLine("The Moon " + i + " is repeated twice!");
                }
                moons2.Add(i);
            }
        }
    }
}
