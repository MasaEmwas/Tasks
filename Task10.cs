using System;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ProblemSolvingTasks
{
    public class Task10
    {
        public static async Task Run()
        {
            Console.WriteLine("\nTask 10 running: Multithreaded Prime Number Finder: Use Task and async/await to find all prime numbers between 1 and 1,000,000 efficiently\n");
            int max = 1000000;
            int number = max / 4;

            Task<List<int>> t1 = Task.Run(() => PrimeRange(1, number)); // here i would but 2 parameters
            Task<List<int>> t2 = Task.Run(() => PrimeRange(number + 1, 2 * number));
            Task<List<int>> t3 = Task.Run(() => PrimeRange(2 * number + 1, 3 * number));
            Task<List<int>> t4 = Task.Run(() => PrimeRange(3 * number + 1, 4 * number));

            List<int>[] results = await Task.WhenAll(t1, t2, t3, t4);
 
            // to print the primes from 1-1,000,000
            //foreach (List<int> primeList in results)
            //{
            //    foreach (int prime in primeList)
            //    {
            //        Console.WriteLine(prime);
            //    }
            //}

            Console.WriteLine("The first 15 prime numbers: \n");
            foreach (int x in results[0].Take(15)) {
                Console.WriteLine(x);
            }
            int count = 0;
            for (int i = 0; i <  results.Length; i++) {
                count += results[i].Count;
            }

            Console.WriteLine("\nThe number of prime numbers from 1-1,000 is: " + count);

        }
        public static List<int> PrimeRange(int num1, int num2)
        {
            List<int> primes = new List<int>();
            for (int i = num1; i <= num2; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number == 2) // the only even prime number
                return true;

            if (number % 2 == 0) // all even numbers are not prime 
                return false;
            //Note: the 3rd if statment can be emitted and instead included as part of the for loop by starting from int i = 2,
            // however if i included it in the for loop then it would test all numbers 2,4,6,8... so all even numbers would be tested,
            // Therefor keeping the 3rd if statement and checking only the odd numbers in the for loop is more optimal.

            int boundary = (int)Math.Sqrt(number); // instead of checking all numbers up to number, we only check up to the square root of the number.
            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }      
    }
}