namespace ProblemSolvingTasks
{
    public class Task1
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 1 running: (Finding the Second Largest Number in an Array)\n");
            // int[] numbers = new int[0];
            int[] numbers = { 10, 4, 22, 12, 33, 44 }; // sort from largest to smallest 44, 33, 22, 12, 10, 4
            if (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                { //start with the first number and compare it with all other numbes in the array
                    for (int j = i + 1; j < numbers.Length; j++)
                    {
                        if (numbers[i] < numbers[j])
                        {
                            int temp = numbers[i]; // temp = 22
                            numbers[i] = numbers[j];
                            numbers[j] = temp;
                        }
                    }
                }
                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Second Largest Number: " + numbers[1]);
            }
            else if (numbers.Length == 1)
            {
                Console.WriteLine("There is only one element in the array");
            }
            else
            {
                Console.WriteLine("The array is empty");
            }
        }
    }
}
