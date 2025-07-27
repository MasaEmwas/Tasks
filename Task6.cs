namespace ProblemSolvingTasks
{
    public class Task6
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 6 running: Counting vowels in string\n");
            Console.WriteLine("The string is: MasaAmwas, the number of vowels in it is: ");
            int result = CountVowels("MasaAmwas");
            Console.WriteLine(result);
        }
public static int CountVowels(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("The string is empty or null.");
                return 0;
            }
            word = word.ToLower();
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                {
                    count++;
                }
                
            }
            return count;
        }
    }
}
