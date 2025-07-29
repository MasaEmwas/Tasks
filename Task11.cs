namespace ProblemSolvingTasks
{
    public class Task11
    {
        public static void Run()
        {
            Console.WriteLine("\nFind All Subsets of a Given Set, using Recursion\n");
            List<int> inputSet = new List<int> { 1, 2, 3 };
            List<int> currentSubset = new List<int>();
            generateSubsets(inputSet, currentSubset, 0);

 
        }
        public static void generateSubsets(List<int> inputSet, List<int> currentSubset, int index)
        {
            // Base case: if we have considered all elements
            if (index == inputSet.Count)
            {
                Console.WriteLine("Subset: " + string.Join(", ", currentSubset));
                return;
            }

            currentSubset.Add(inputSet[index]);
            generateSubsets(inputSet, currentSubset, index + 1);
 
            currentSubset.RemoveAt(currentSubset.Count - 1);
            generateSubsets(inputSet, currentSubset, index + 1);
        }

    }
}