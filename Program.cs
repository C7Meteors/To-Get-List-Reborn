using System;

namespace ToGetListReborn
{
    class Program
    {
        static void Main(string[] args)
        {
            var UserList = new ToGetList();
            Console.WriteLine("Hello, and thank you for using To Get List. Do you have an item you would like to enter into the list? Yes (y), No (any other key)");
            var userInput = Console.ReadKey();

            while (userInput.Key == ConsoleKey.Y)
            {
                Console.Clear();
                Console.WriteLine("Please type in the item you would like to add to the list, and press enter.");

                UserList.AddItem(Console.ReadLine());

                Console.WriteLine("Is there anything else you would like to add? Yes (y), No (any other key)");
                userInput = Console.ReadKey();
            }
            Console.Clear();

            Console.WriteLine("Here is your To Get List:");
            Console.WriteLine();

            UserList.PrintItems();
            Console.WriteLine("Press any key to close this program. Thank you!");
            Console.ReadKey();
        }
    }
}
