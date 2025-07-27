namespace ProblemSolvingTasks
{
    public class Task2
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 2 running: Find first Non-Repeated Character in a string\n");
            char result = findChar("maysam");
            Console.WriteLine(result);


        }
         static char findChar(string name) //"maysam"
        {       
            if (name.Length > 1)
            {
                for (int i = 0; i < name.Length; i++)
                {
                    int flag = 1;
                    for (int j = 0; j < name.Length; j++)
                    {
                        if (i == j) {
                            continue;
                        }

                        if (name[i] == name[j])
                        {
                            flag = 0;
                            break;

                        } 
                    }
                    
                    //if flag is 1, it means that the character at index i is non-repeating
                    if (flag == 1)
                    {
                        Console.WriteLine("the first non-repeating character in index: " + i);
                        return name[i];

                    }
                }
            }
            else if (name.Length == 1)
            {
                Console.WriteLine("There is only one character in the string");
                return '0';

            }
            else
            {
                Console.WriteLine("The string is empty ");
                return '0';

            }
                Console.WriteLine("The string does not have nonrepeating characters!");
                return 'z';

        }
    }
}
