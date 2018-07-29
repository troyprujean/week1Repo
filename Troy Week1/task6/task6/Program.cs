using System;

namespace task6
{
    public class Program6
    {
        public static void Main()
        {   
            Console.WriteLine("Welcome to the number swapper");
            Console.WriteLine("Please enter the first number:");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the second number:");
                int num2 = int.Parse(Console.ReadLine());
                Console.WriteLine("The numbers swapped around are:");
                int tempNum = num1;
                num1 = num2;
                num2 = tempNum;
                Console.WriteLine("num1 is now: " + num1);
                Console.WriteLine("num2 is now: " + num2);
        }
    }
}
