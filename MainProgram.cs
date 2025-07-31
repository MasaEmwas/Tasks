using System;

namespace ProblemSolvingTasks
{
    class Program
    {
        // previously it was "static void Main(string[] args)", Now its:" static async Task Main(string[] args)"
        //since I am calling the async Task method from the Main method, the Main method should be async to await task10 
        static async Task Main(string[] args)
        {
            Console.WriteLine("running remaining tasks(3-6)");
            // Task1.Run();
            // Task2.Run();
            // Task3.Run();
            // Task4.Run();
            // Task5.Run();
            // Task6.Run();
            // Task7.Run();
            // Task8.Run();
            // Task9.Run();
            // await Task10.Run(); // wait until this task is completed before exiting the program
            // Task11.Run();
            // Task12.Run();
            // Task13.Run();
            // Task14.Run();
            Task15.Run();
            Task16.Run();
            Task17.Run();
        }   
    }
}