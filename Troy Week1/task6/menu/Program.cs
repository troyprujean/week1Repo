using System;
using task6;
using task7;
using task8;
using task9;

namespace menu
{
    class MainMenu
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the main menu");
            Console.WriteLine("Please enter the name of the program you want to use");
            Console.WriteLine("For the number swapper, enter the word 'number'");
            Console.WriteLine("For the number sorter, enter the word 'sorter'");
            Console.WriteLine("For the grades machine, enter the word 'grade'");
            Console.WriteLine("For the name machine, enter the word 'name'");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "number":
                    Program6.Main();
                    break;

                case "sorter":
                    Program7.Main();
                    break;

                case "grade":
                    Program8.Main();
                    break;

                case "name":
                    Program9.Main();
                    break;
            }
        }
    }
}
