using System;

namespace ProblemSolvingTasks
{
    public class Task7
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 7 running: Reverse a string\n");
            string result = ReversedString("Masa");
            Console.WriteLine(result);

        }
        public static string ReversedString(string text)
        {
            string reversedString = String.Empty;
            if (String.IsNullOrEmpty(text)) {
                Console.WriteLine("The text is null or empty.");
            }
            Console.WriteLine(text.Length);
            for (int i = text.Length - 1; i > -1; i--) {
                reversedString += text[i];
            }
            return reversedString;

        }
    }
}