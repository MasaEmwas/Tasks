using System;

namespace ProblemSolvingTasks
{
    public class Task9
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 9 running: Check If String Contains Only Digits\n");

            bool checkDigits = ContainsOnlyDigits("");
            if (checkDigits)
            {
                Console.WriteLine("The string Only has Digits");
            }

        }
        public static bool ContainsOnlyDigits(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                Console.WriteLine("The string is empty or null.");
                return false;
            }
            foreach (char c in text) {
                if (c < '0' || c > '9') {
                    Console.WriteLine("The string Contains characters Other than Digits. ");
                    return false;
                }
            }
            return true;
        }     
    }
}