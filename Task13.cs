using System;

namespace ProblemSolvingTasks
{
    public class Task13
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 13 running: Binary Search on a Sorted array using Recursion\n");

            int[] array = {2, 5, 6, 7, 8, 22, 30};
            int target = 22;
            int left = 0;
            int right = array.Length - 1;       

            if (array == null || array.Length == 0)
            {
                Console.WriteLine("The array is null or empty");
                return;
            }
            if (IsArraySorted(array) == false)
            {
                Console.WriteLine("For Binary Search Algorithm to work, Your Array must be Sorted");
                return;
            }
            int result = FindTargetElement(left, right, array, target);
            
            if (result != -1)
            {
                Console.WriteLine("The target: " + target + " is present in the array (" + string.Join(", ", array ) +") at index: " + result);
            }
            else
            {
                Console.WriteLine("The target is NOT found in the array.");
            }
        }
       public static int FindTargetElement(int left, int right, int[] array, int target) {

            if (left > right) {
                return -1;
            }
            int mid = (left + right) / 2;

            if (target == array[mid])
                return mid;

            if (target > array[mid])
            {
                //disregard the left part of the array
                //left = mid + 1; 
                return FindTargetElement(mid + 1, right, array, target);
                
            }
            else
            {
                //disregard the left part of the array
                //right = mid - 1; 
                return FindTargetElement(left, mid - 1, array, target);

            }
        }
        public static bool IsArraySorted(int[] array) {
            for (int i = 0; i < array.Length - 1; i++) {
                if (array[i + 1] < array[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}