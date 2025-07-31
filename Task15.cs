using System;

namespace ProblemSolvingTasks
{
    public class Task15
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 15 running: Sparse Matrix Representation \n");
            //Step 1 initialize the matrix

            int[,] matrix =
            {
                {0,0,0,5},
                {0,0,0,0},
                {0,2,0,0}
            };
            int row = matrix.GetLength(0);
            int column = matrix.GetLength(1);

            Console.WriteLine("The lenth of the matrix is: " + row + " and " + column);

            //step 2 declaration of dictionary
            Dictionary<Tuple<int, int>, int> dictionary = new Dictionary<Tuple<int, int>, int>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (matrix[i, j] != 0)
                    {
                        dictionary[Tuple.Create(i, j)] = matrix[i, j];

                    }

                }
            }
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"Position ({entry.Key.Item1}, {entry.Key.Item2}) → {entry.Value}");
            }

            //Decompressing part
            // we neeed the length of the original matrix
            // create an empty 2d array with the same length as original matrix
            int[,] reconstructedMatrix = new int[row, column];

            
            foreach(var entry in dictionary) {
                int rowEntry = entry.Key.Item1;
                int columnEntry = entry.Key.Item2;
                reconstructedMatrix[rowEntry, columnEntry] = entry.Value;
                    
            }

            // print the reconstructed matrix
            Console.WriteLine("\nThe reconstructed Matrix: \n");
            for (int i =0; i< reconstructedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < reconstructedMatrix.GetLength(1); j++) {
                    Console.Write(reconstructedMatrix[i, j] + " ");

                }
                Console.WriteLine("");

            }

        }

    }

}