using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2018
{
    class Day2
    {
        private List<string> _linesList;

        public Day2()
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

        private void Run()
        {
            var twoCount = 0;
            var threeCount = 0;

            foreach (var line in _linesList)
            {
                foreach (var ch in line)
                {
                    var count = line.Split(ch).Length - 1;

                    Console.WriteLine(count);

                    if (count == 2)
                    {
                        twoCount++;
                    }
                    else if (count == 3)
                    {
                        threeCount++;
                    }
                }
            }

            Console.WriteLine("Number of doubles is {0} and triples is {1}", twoCount, threeCount);
        }
    }
}
