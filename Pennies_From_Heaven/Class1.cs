using System;

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pennies.cs
{
        internal class Program
    {
        class program
        { }
        static void Main(string[] args)
        {
            string choice;
            int q, d, n, p, hd;
            int totchange, totcents, dollars, cents;

            Console.WriteLine("Welcome to the Coin Counter");
            Console.Write("Do you have change? (y/n): ");
            choice = Console.ReadLine();
            while (choice.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
            {
                hd = getCoin("Helf Dollars");
                q = getCoin("Quarters");
                d = getCoin("Dimes");
                n = getCoin("Nickels");
                p = getCoin("Pennies");

                totcents = (hd * 50) + (q * 25) + (d * 10) + (n * 5) + p;
                Console.WriteLine("\nYou have " + totcents + " Cents.");
                dollars = totcents / 100;
                cents = totcents % 100;

                Console.WriteLine("Which is " + dollars + " dollars and "

                                    + cents + " cents.\n");

                Console.WriteLine("I'm in the loop!");

                Console.Write("Do you have more change? (y/n): ");

                choice = Console.ReadLine();


            }
            while (choice.Equals("N", StringComparison.CurrentCultureIgnoreCase))
            {


            }
            if (Debugger.IsAttached)

            {
                Console.Write("Press any key to Continue...");

                Console.ReadKey();
            }
        } //end of main
        static int getCoin(string cointype)
        {
            int ccount;

            do
            {
                try
                {
                    Console.Write("How many " + cointype + " do you have?");
                    ccount = int.Parse(Console.ReadLine());
                    if (ccount < 0)
                    {
                        Console.WriteLine("Coin amounts cannot be negative, please re-enter a valid amount.");
                    }
                }
                catch (Exception ex)
                { Console.WriteLine("Illegal input: " + ex.Message + " please re-enter a valid amount.");
                    ccount = -1;
                }

            } while (ccount < 0);

            return ccount;
        }
    }
}
