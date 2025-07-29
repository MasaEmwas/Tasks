using System;

namespace ProblemSolvingTasks
{
    public class Task12
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 12 running: Binary Search on a Sorted array\n");
            // we should check if the array is sorted
            int[] array = { 2, 5, 7, 9, 10, 12, 15, 20, 25, 30 };
            int target = 5;
            int result = FindTargetElement(array, target);
            if (result != -1)
            {
                Console.WriteLine("The target: " + target + " is present in the array (" + string.Join(", ", array) + ") at index: " + result);
            }
        }
        public static int FindTargetElement(int[] array, int target) {
            if (array == null || array.Length == 0) {
                Console.WriteLine("The array is null or empty");
                return -1;
            }
            if (IsArraySorted(array) == false) {
                Console.WriteLine("For Binary Search Algorithm to work, Your Array must be Sorted");
                return -1;
            }
            
            int left = 0;
            int right = array.Length - 1;

            while (left <= right) {
                int mid = (left + right) / 2;
                if (target == array[mid])
                    return mid;

                if (target > array[mid])
                {
                    //disregard the left part of the array
                    left = mid + 1; ///////// correct
                    
                }
                else
                { // if target is less than array[mid]
                  // disregard the right side          
                    right = mid - 1;
                }
            }
            Console.WriteLine("the Target is NOT in the array");
            return -1;
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