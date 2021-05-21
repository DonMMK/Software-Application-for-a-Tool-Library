using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToolLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();

        }

        
        public static void MainMenu()
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

            switch (Console.ReadLine()) // entry point for the user input
            {
                case "1":
                    StaffMenu();
                    break;
                case "2":
                    MemberMenu();
                    break;
                case "0":
                    break;

                    
            }


        }

        public static void StaffMenu()
        {
            Console.Clear();
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

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("1. Add a new tool");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter the tool");
                    string ToolName = Console.ReadLine();

                    Console.WriteLine("Quantity of tools");
                    int Quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("AvailableQuantity of tools");
                    int AvailableQuantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Number of borrowings");
                    int NoBorrowers = Convert.ToInt32(Console.ReadLine());
                    Tool NewTool = new Tool(ToolName, Quantity, AvailableQuantity, NoBorrowers);

                    NewTool.AddTool();

                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("2. Add new pieces of an existing tool");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("3. Remove some pieces of a tool");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("4. Register a new member");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Please enter first name: ");
                    string firstName = Console.ReadLine();

                    Console.WriteLine("Please enter last name: ");
                    string lastName = Console.ReadLine();

                    Console.WriteLine("Please enter contact number: ");
                    string contactNumber = Console.ReadLine();

                    Console.WriteLine("Please enter four digit PIN: ");
                    string pIN = Console.ReadLine();
                    Member NewMember = new Member(firstName, lastName, contactNumber, pIN);

                    NewMember.RegisterMember();


                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("5. Remove a member");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("6. Find the contact number of a member");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Enter the Members First and Last Name seperated by a space");
                    string[] Input = Console.ReadLine().Split("");
                    // no error checking done
                    string UserName = Input[1] + Input[0];
                    // redirect to method that does the search

                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "0":
                    MainMenu();
                    break;
                default:
                    MainMenu();
                    break;
                    
            }

        }
       
        public static void MemberMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Tool Library");
            Console.WriteLine("===============Member Menu================");
            Console.WriteLine("1. Display all the tools of a tool type");
            Console.WriteLine("2. Borrow a tool");
            Console.WriteLine("3. Return a tool");
            Console.WriteLine("4. List all the tools I am renting");
            Console.WriteLine("5. Display top three (3) most frequenlty rented tools");
            Console.WriteLine("0. Return to main menu");
            Console.WriteLine("===============================");
            Console.WriteLine("");
            Console.WriteLine("Please make a selection (1-5, or 0 to return to main menu)");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===============Member Menu================");
                    Console.WriteLine("1. Display all the tools of a tool type");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to Member menu");
                    Console.ReadLine();
                    MemberMenu();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===============Member Menu================");
                    Console.WriteLine("2. Borrow a tool");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to Member menu");
                    Console.ReadLine();
                    MemberMenu();
                    break;
                case "3":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===============Member Menu================");
                    Console.WriteLine("3. Return a tool");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to Member menu");
                    Console.ReadLine();
                    MemberMenu();
                    break;
                case "4":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===============Member Menu================");
                    Console.WriteLine("4. List all the tools I am renting");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to Member menu");
                    Console.ReadLine();
                    MemberMenu();
                    break;
                case "5":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("===============Member Menu================");
                    Console.WriteLine("5. Display top three (3) most frequenlty rented tools");
                    Console.WriteLine("==========================================");
                    Console.WriteLine("");

                    Console.WriteLine("Press any key to go back to Member menu");
                    Console.ReadLine();
                    MemberMenu();
                    break;
                case "0":
                    MainMenu();
                    break;
                default:
                    MainMenu();
                    break;
            }
        }





    }
}
