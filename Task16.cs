using System;

namespace ProblemSolvingTasks
{
    public class Task16
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 16 running: Password Pattern Generator\n");


            Dictionary<char, List<char>> patternMap = new Dictionary<char, List<char>>()
            {
                {'A', new List<char>
                    { 'A','B','C','D','E','F','G','H','I','J','K','L','M',
                    'N','O','P','Q','R','S','T','U','V','W','X','Y','Z' }
                },

                {'a', new List<char>
                    { 'a','b','c','d','e','f','g','h','i','j','k','l','m',
                    'n','o','p','q','r','s','t','u','v','w','x','y','z' }
                },

                {'#', new List<char>
                    { '0','1','2','3','4','5','6','7','8','9' }
                },

                {'*', new List<char>
                    { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')' }
                }
            };

            string passwordPattern = "A#x";

            List<List<char>> patternOptions = new List<List<char>>();

            foreach (char charater in passwordPattern)
            {
                if (patternMap.ContainsKey(charater))
                {
                    // Add the list of possible characters for this pattern symbol
                    patternOptions.Add(patternMap[charater]);
                }
                else
                {
                    // It's a literal character (like 'x', '_', etc.), so wrap it in a list
                    patternOptions.Add(new List<char> { charater });
                }
            }

            List<string> allPasswords = new List<string>();
            int limit = 100;
            GenerateCombinations(patternOptions, 0, "", allPasswords, limit);

            Console.WriteLine("the fllowing are the first 100 passwords generated based on the pattern: " + passwordPattern + "\n");
            // Print results
            foreach (string password in allPasswords)
            {
                Console.WriteLine(password);
            }


        }

        // Method definition
        static void GenerateCombinations(List<List<char>> patternOptions, int index, string current, List<string> results, int limit)
        {
            if (results.Count >= limit) // just there to print the first 100 passwords
                return;

            if (index == patternOptions.Count)
            {
                results.Add(current);
                return;
            }

            foreach (char c in patternOptions[index]) //if index = 0 then c will loop through ['A', 'B', 'C', ..., 'Z']
            {
                GenerateCombinations(patternOptions, index + 1, current + c, results, limit); // for each of these characters call the function again
                if (results.Count >= limit)
                    break;
            }
        }

    }
}