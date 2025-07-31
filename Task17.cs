using System;

namespace ProblemSolvingTasks
{
    public class Person
    { 
        public string Name;
        public Person Friend;
    }
    public class Task17
    {
        public static void Run()
        {
            Console.WriteLine("\nTask 17 running: Deep Object Cloner\n");

            // Person original = new Person();
            // original.Name = "Masa";
            // original.Friend = new Person();
            // original.Friend.Name = "Alaa";
            Person a = new Person();
            a.Name = "a";
            Person b = new Person();
            b.Name = "b";

            a.Friend = b;
            b.Friend = a;

            Person clone = DeepClone(a);
            // Person clone = a;
            clone.Name = "Alaa";

            Console.WriteLine("Original Name: " + a.Name); // Should print "a"
            Console.WriteLine("Cloned Name: " + clone.Friend.Name); // Should print "Alaa"



        }

        public static Person DeepClone(Person original)
        {
            Dictionary<Person, Person> visited = new Dictionary<Person, Person>();
            return DeepClone(original, visited);
        }

        private static Person DeepClone(Person original, Dictionary<Person, Person> visited)
        {
            if (original == null)
                return null;

            if (visited.ContainsKey(original))
                return visited[original];

            Person clone = new Person();
            visited[original] = clone;

            clone.Name = original.Name;
            clone.Friend = DeepClone(original.Friend, visited);

            return clone;
        }
    }
}