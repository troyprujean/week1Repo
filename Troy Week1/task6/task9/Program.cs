using System;

namespace task9
{
    public class Program9
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the name machine");
            string[] nameArray = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Please enter the name of student " + (i+1));
                nameArray[i] = Console.ReadLine();
            }

            int y = 1;

            foreach (string name in nameArray)
            {
                Console.WriteLine("The name of student " + y + " is: ");
                Console.WriteLine(name);
                y++;
            }
        }
    }
}
