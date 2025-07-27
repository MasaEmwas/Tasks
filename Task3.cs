namespace ProblemSolvingTasks
{
    public class Task3
    {
        public static void Run()
        {

            Console.WriteLine("\nTask 3 running: Find the missing number in an Array\n");
            int[] numbers = { 1, 3, 7, 5, 2, 8, 4 };
            int result = FindMissingNumber(numbers);
            Console.WriteLine("missing number is: " + result);
        }
        public static int FindMissingNumber(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("The array is empty or null.");
                return -1; 
            }
            else
            {
                int n = numbers.Length + 1;
                int arraySum = n * (n + 1) / 2; //calculate the sum of the first n numbers.

                // Actual sum of the array with missing number
                int actualSum = 0;
                foreach (int number in numbers)
                {
                    actualSum += number;
                }
                return arraySum - actualSum;
            }
        }
    }
}
