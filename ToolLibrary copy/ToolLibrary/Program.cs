using System;

namespace ToolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        // Online source: wllsb.com
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===========Main Menu===========");
            Console.WriteLine("1. Staff Login");
            Console.WriteLine("2. Member Login");
            Console.WriteLine("0. Exit");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Please make a selection (1-2, or 0 to exit)");

            switch (Console.ReadLine())
            {
                case "1":
                    StaffMenu();
                    return true;
                case "2":
                    MemberLogin();
                    return true;
                case "0":
                    Console.WriteLine("Exiting Menu");
                    return false;
                default:
                    return true;
            }

        }

        public static void StaffMenu()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("================Staff Menu================");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("6. Find the contact number of a member");
            Console.WriteLine("0. Return to main menu"); 
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Please make a selection (1-6, or 0 to return to main menu)");
        }

        public static void MemberLogin()
        {
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===============Member Menu================");
            Console.WriteLine("1. Add a new tool");
            Console.WriteLine("2. Add new pieces of an existing tool");
            Console.WriteLine("3. Remove some pieces of a tool");
            Console.WriteLine("4. Register a new member");
            Console.WriteLine("5. Remove a member");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Please make a selection (1-5, or 0 to return to main menu)");
        }


    }
}
