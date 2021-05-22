using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToolLibrary
{
    public static class Program
    {
        public static void Main(string[] args)
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
                default :
                    MainMenu();
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

                    Tool NewTool = new Tool();
                    
                    Console.WriteLine("Please enter the tool");
                    NewTool.Name = Console.ReadLine();

                    Console.WriteLine("Quantity of tools");
                    NewTool.Quantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("AvailableQuantity of tools");
                    NewTool.AvailableQuantity = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Number of borrowings");
                    NewTool.NoBorrowings = Convert.ToInt32(Console.ReadLine());

                    int num = 0;
                    Int32.TryParse(Console.ReadLine(), out num);
                     

                    //NewTool.AddTool();
                    ToolCollection newToolCollection = new ToolCollection();
                    newToolCollection.add(NewTool);
                    
                    Console.WriteLine("Press any key to go back to staff menu");
                    Console.ReadLine();
                    StaffMenu();
                    break;
                case "2":
                    Console.Clear();
                    Console.WriteLine("Welcome to the Tool Library");
                    Console.WriteLine("================Staff Menu================");
                    Console.WriteLine("2. Add new pieces of an existing tool"); // increase quantity
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

                    Member NewMember = new Member();

                    Console.WriteLine("Please enter first name: ");
                    NewMember.FirstName = Console.ReadLine();

                    Console.WriteLine("Please enter last name: ");
                    NewMember.LastName = Console.ReadLine();

                    Console.WriteLine("Please enter contact number: ");
                    NewMember.ContactNumber = Console.ReadLine();

                    Console.WriteLine("Please enter four digit PIN: ");
                    NewMember.PIN = Console.ReadLine();
                    MemberCollection memberCollection = new MemberCollection();
                    memberCollection.add(NewMember);

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

                    Member RemoveMember = new Member();

                    Console.WriteLine("Please enter first name you want t: ");
                    RemoveMember.FirstName = Console.ReadLine();

                    Console.WriteLine("Please enter last name you want to delete: ");
                    RemoveMember.LastName = Console.ReadLine();

                    //Console.WriteLine("Please enter contact number: ");
                    //RemoveMember.ContactNumber = Console.ReadLine();

                    //Console.WriteLine("Please enter four digit PIN: ");
                    //RemoveMember.PIN = Console.ReadLine();
                    MemberCollection deleteMember = new MemberCollection();
                    deleteMember.delete(RemoveMember);

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

                    Member searchmember = new Member();

                    Console.WriteLine("Enter the Members First and Last Name seperated by a space");
                    string[] Input = Console.ReadLine().Split("");
                    // no error checking done
                    string UserName = Input[1] + Input[0];
                    
                    // redirect to method that does the search
                    MemberCollection membersearch = new MemberCollection();
                    
                    //membersearch.search();
                    
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

            // While true loop to check if the member login is okay
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

                    Console.WriteLine("Enter the name of the tool type want to display");
                    
                    for (int i = 0; i < 9; i++) 
                    {
                        Console.Write(i+1);
                        Console.Write(". ");
                        Console.WriteLine(Enum.GetName(typeof(ToolCatergories),i+1));
                    }

                    string UIToolType = Console.ReadLine();

                    if (UIToolType == "1")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(GardeningTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "2")
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(FlooringTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "3")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(FencingTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "4")
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(MeasuringTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "5")
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(CleaningTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "6")
                    {
                        for (int i = 0; i < 6; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(PaintingTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "7")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(ElectronicTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "8")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(ElectricityTools_Types), i + 1));
                        }
                    }

                    else if (UIToolType == "9")
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(i + 1);
                            Console.Write(". ");
                            Console.WriteLine(Enum.GetName(typeof(AutomotiveTools_Types), i + 1));
                        }
                    }


                    // Find the actual tool eg 125 orbital sander from the tool type

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
