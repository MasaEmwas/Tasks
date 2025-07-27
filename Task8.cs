using System;

namespace ProblemSolvingTasks
{
    public class Task8
    {
        public static void Run()
        {
            Console.WriteLine("\nMerging two sorted Arrays into one sorted array\n");
            int[] arr1 = { 5, 8, 9 };
            int[] arr2 = { };
            int[] arr3 = new int[arr1.Length + arr2.Length];
            MergeArray(arr1, arr2, arr3);
            
        }
        public static void MergeArray(int[] arr1, int[] arr2, int[] arr3) {

            if ((arr1 == null || arr1.Length == 0) && (arr2 == null || arr2.Length == 0))
            {
                Console.WriteLine("Both arrays are empty or NUll");
                return;

            }

            int i = 0, j = 0, k = 0;
            int lengthArr1 = arr1.Length;
            int lengthArr2 = arr2.Length;
            

            while (i < lengthArr1 && j < lengthArr2) {

                if (arr1[i] < arr2[j])
                {
                    arr3[k] = arr1[i];
                    i++;
                    k++;

                }
                else {  // if arr1[i] >= arr2[j]
                    arr3[k] = arr2[j];
                    j++;
                    k++;

                }
            }

            while (i < lengthArr1)  // if there are still element in the first array
            {
                arr3[k] = arr1[i];
                i++;
                k++;
            }

            while (j < lengthArr2) { // if there are still elements in the second array
                arr3[k] = arr2[j];
                j++;
                k++;
            }

            foreach (int number in arr3)
            {
                Console.Write(number + " ");
            }
        }
    }
}