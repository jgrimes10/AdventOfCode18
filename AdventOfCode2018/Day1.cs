using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode2018
{
    public class Day1
    {
        private List<string> _linesList;

        public Day1()
        {
            _linesList = GetLines();
            Run();
        }

        private List<string> GetLines()
        {
            // Open the text document
            StreamReader reader = File.OpenText("C:\\Users\\jgrimes\\OneDrive - Relias Learning\\Documents\\Development\\AdventOfCode2018\\AdventOfCode2018\\Data\\Day1.txt");
            string line;
            List<string> toReturn = new List<string>();

            // Read through each line and set it to 'line' variable
            while ((line = reader.ReadLine()) != null)
            {
                toReturn.Add(line);
            }

            return toReturn;
        }

        public void Run()
        {
            // Add up all the inputs
            var total = 0;
            List<int> frequencyList = new List<int>();

            // PART 1: Find the total frequency
            foreach (var line in _linesList)
            {
                total += int.Parse(line);
            }

            var currentFrequency = 0;
            var continuing = true;
            var steps = 0;

            do
            {
                foreach (var line in _linesList)
                {
                    if (!frequencyList.Contains(currentFrequency))
                    {
                        frequencyList.Add(currentFrequency);
                        currentFrequency += int.Parse(line);
                        steps++;
                    }
                    else
                    {
                        continuing = false;
                        break;
                    }
                }
            } while (continuing);
            
            Console.WriteLine("The total is {0}", total);
            Console.WriteLine("The first repeated frequency is: {0} and took {1} steps", currentFrequency, steps);
        }
    }
}