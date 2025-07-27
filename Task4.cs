namespace ProblemSolvingTasks
{
    public class Task4
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 4 running: sort an array of integers in ascending order\n");
             
            int[] numbers = { 10, 4, 22, 12, 33, 44 }; // sort ascending from smallest to largest 4, 10, 12, 22, 33, 44
            if (numbers.Length > 1)
            {
                for (int i = 0; i < numbers.Length - 1; i++)
                { //start with the first number and compare it with all other numbes in the array

                    for (int j = i + 1; j < numbers.Length; j++)
                    {

                        if (numbers[i] > numbers[j])
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
