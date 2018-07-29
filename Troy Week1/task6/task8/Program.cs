using System;

namespace task8
{
    public class Program8
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the grades machine");
            Console.WriteLine("Please enter your final course mark:");
            int marks = int.Parse(Console.ReadLine());

            if (marks >= 50)
            {
                Console.WriteLine("Congratulations, you have passed!");
            }
            else
            {
                Console.WriteLine("I'm sorry but you have failed");
            }
        }
    }
}
