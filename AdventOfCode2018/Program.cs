using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            var _continue = true;

            while (_continue)
            {
                Console.WriteLine("Please enter which day to run: ");
                var day = Console.ReadLine();

                switch (day)
                {
                    case "1":
                        Day1 day1 = new Day1();
                        break;
                    case "2":
                        Day2 day2 = new Day2();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Would you like to go again?");
                var again = Console.ReadLine().ToLower();
                switch (again)
                {
                    case "y":
                        _continue = true;
                        break;
                    case "n":
                        Console.WriteLine("Exiting...");
                        _continue = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input, exiting...");
                        _continue = false;
                        break;
                }
            }

            Console.ReadLine();
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
