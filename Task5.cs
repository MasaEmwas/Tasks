namespace ProblemSolvingTasks
{
    public class Task5
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 5 logic running: Find the maximum value in an array\n");
            int[] numbers = { 1, 3, 7, 55, 5, 2, 8, 4 };
            Console.WriteLine("The maximum value in the array: " + string.Join(", ", numbers) + " is : " + FindMaxValue(numbers));
            int result = FindMaxValue(numbers);
        }

        public static int FindMaxValue(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                Console.WriteLine("The array is empty or null.");
                return -1;
            }
            int temp = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > temp)
                {
                    temp = numbers[i];
                }
            }
            return temp;

        }

    }
}
