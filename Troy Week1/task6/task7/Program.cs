using System;

namespace task7
{
    public class Program7
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the number sorting machine");
            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The largest of the numbers entered is: " + num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The largest of the numbers entered is: " + num2);
            }
            else
            {
                Console.WriteLine("The largest of the numbers entered is: " + num3);
            }
        }
    }
}
