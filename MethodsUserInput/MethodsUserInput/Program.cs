using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;


namespace Equations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program is about to being.");
            Console.WriteLine("Please only input whole numbers!");
            Thread.Sleep(2000);
            double health = 0;
            int round = 1;
            Console.Write("Please enter Players desired Firerate, or how many bullets per second they will fire. Recommended ranges are between 1-20. (whole numbers only): ");
            string firerateIn = Console.ReadLine();
            Console.Write("Please enter Players desired trigger delay, or how much time between shots. (Optional, for burst weapons!). (whole numbers only): ");
            Console.ReadLine();
            double firerate = Convert.ToInt32(firerateIn);
            double bps = firerate;
            double fps = 1 / firerate;
            Console.WriteLine("Trigger Delay based on Firerate and User Input: " + fps);
            Thread.Sleep(1000);
            Console.Write("Please enter Players desired Damage per Second. Recommended ranges are between 40-200. (whole numbers only): ");
            string dpsIn = Console.ReadLine();
            int dps = Convert.ToInt32(dpsIn);
            Thread.Sleep(1000);
            Console.Write("Please enter Players desired Base Damage Multiplier. Recommended ranges are between .10-50. (decimals allowed): ");
            string dmgbaseIn = Console.ReadLine();
            double dmgbase = Convert.ToDouble(dmgbaseIn);
            Thread.Sleep(1000);
            Console.Write("Please enter Players desired Upgraded Damage Multiplier. Recommended ranges are between 12-1500. (decimals allowed): ");
            string dmgboostIn = Console.ReadLine();
            double dmgboost = Convert.ToDouble(dmgboostIn);
            Thread.Sleep(1000);
            while (round <= 50)
            {
                if (round <= 30)
                {
                    double dmgrec = 1800 / round;
                    double dmgmulti = dmgrec / 100;
                    health = 1250 * (-0.054217728 + Math.Pow(1.25, round - 10));
                    Console.WriteLine("Round " + round + " " + health);
                    basedmg(health, dmgmulti, firerate, dps, dmgbase, fps, bps);
                    health = 1250 * (-0.054217728 + Math.Pow(1.25, round - 10));
                    boostdmg(health, dmgmulti, firerate, dps, dmgboost, fps, bps);
                    health = 1250 * (-0.054217728 + Math.Pow(1.25, round - 10));
                    Thread.Sleep(500);
                    round += 1;
                }
                else
                {
                    double dmgrec = 1800 / round;
                    double dmgmulti = dmgrec / 100;
                    health = 125000;
                    Console.WriteLine("Round " + round + " " + health);
                    basedmg(health, dmgmulti, firerate, dps, dmgbase, fps, bps);
                    health = 125000;
                    boostdmg(health, dmgmulti, firerate, dps, dmgboost, fps, bps);
                    health = 125000;
                    Thread.Sleep(100);
                    round += 1;
                }
            }
        }
        static void basedmg(double health, double dmgmulti, double firerate, int dps, double dmgbase, double fps, double bps)
        {
                double elasped = 0;
                int rounds = 0;
                while (health >= 1)
                {
                    while (firerate > 0)
                    {
                        health = health - ((dmgmulti * (dps * dmgbase)) / firerate);
                        rounds++;
                        firerate--;
                        if (health <= 0)
                        {
                            firerate = 0;
                        }
                    }
                    elasped = rounds * fps;
                    firerate = bps;
                }
                Thread.Sleep(100);
                Console.WriteLine("-    STK base = " + rounds + " round(s) fired.");
                Thread.Sleep(100);
                Console.WriteLine("-    TTK base = " + elasped + " second(s) to kill.");
                Thread.Sleep(100);            
        }
        static void boostdmg(double health, double dmgmulti, double firerate, int dps, double dmgboost, double fps, double bps)
        {
            double elasped = 0;
            int rounds = 0;
            while (health >= 1)
            {
                while (firerate > 0)
                {
                    health = health - ((dmgmulti * (dps * dmgboost)) / firerate);
                    rounds++;
                    firerate--;
                    if (health <= 0)
                    {
                        firerate = 0;
                    }
                }
                elasped = rounds * fps;
                firerate = bps;
            }
            Thread.Sleep(100);
            Console.WriteLine("-    STK boost = " + rounds + " round(s) fired.");
            Thread.Sleep(100);
            Console.WriteLine("-    TTK boost = " + elasped + " second(s) to kill");
            Thread.Sleep(100);
            Console.WriteLine("");
        }
    }
}