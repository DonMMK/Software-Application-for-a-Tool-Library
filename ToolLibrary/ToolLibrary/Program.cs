using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ToolLibrary
{
    public static class Program
    {
        
        //Using enums to store the Tool Types and categories
        enum ToolCatergories : int
        {
            GardeningTools = 1,
            FlooringTools = 2,
            FencingTools = 3,
            MeasuringTools = 4,
            CleaningTools = 5,
            PaintingTools = 6,
            ElectronicTools = 7,
            ElectricityTools = 8,
            AutomotiveTools = 9
        }

        enum GardeningTools_Types : int
        {
            LineTrimmers = 1,
            LawnMovers = 2,
            HandTools = 3,
            Wheelbarrows = 4,
            GardenPowerTools = 5
        }

        enum FlooringTools_Types : int
        {
            Scrapers = 1,
            FloorLasers = 2,
            FloorLevellingTools = 3,
            FloorLevellingMaterials = 4,
            FloorHandTools = 5,
            TilingTools = 6
        }

        enum FencingTools_Types : int
        {
            HandTools = 1,
            ElectricFencing = 2,
            SteelFencingTools = 3,
            PowerTools = 4,
            FencingAccessories = 5
        }

        enum MeasuringTools_Types : int
        {
            DistanceTools = 1,
            LaserMeasurer = 2,
            MeasuringJugs = 3,
            TemperatureAndHumidityTools = 4,
            LevellingToola = 5,
            Markers = 6
        }

        enum CleaningTools_Types : int
        {
            Draining = 1,
            CarCleaning = 2,
            Vacuum = 3,
            PressureCleaners = 4,
            PoolCleaning = 5,
            FloorCleaning = 6
        }

        enum PaintingTools_Types : int
        {
            SandingTools = 1,
            Brushes = 2,
            Rollers = 3,
            PaintRemovalTools = 4,
            PaintScrapers = 5,
            Sprayers = 6
        }
        enum ElectronicTools_Types : int
        {
            VoltageTester = 1,
            Oscilloscopes = 2,
            ThermalImaging = 3,
            DataTestTool = 4,
            InsulationTesters = 5
        }

        enum ElectricityTools_Types : int
        {
            TestEquipment = 1,
            SafetyEquipment = 2,
            BasicHandTools = 3,
            CircuitProtection = 4,
            CableTools = 5
        }

        enum AutomotiveTools_Types : int
        {
            Jacks = 1,
            AirCompressors = 2,
            BatteryChargers = 3,
            SocketTools = 4,
            Braking = 5,
            DriveTrain = 6
        }

        static ToolLibrarySystem librarySystem = new ToolLibrarySystem();
        public static void Main(string[] args)
        { 
            MainMenu();

        }

        // Opens the main menu of the program
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
                    Console.WriteLine("Enter staff login username");
                    string StaffLoginUsername = Console.ReadLine();
                    Console.WriteLine("Enter staff login password");
                    string StaffLoginPassword = Console.ReadLine();

                    if(StaffLoginUsername == "staff" && StaffLoginPassword == "today123")
                    {
                        Console.WriteLine("staff successfully logged in");
                        StaffMenu();
                    }
                    else
                    {
                        break;
                    }
                    break;
                case "2":
                    // check if the member is already registered
                    Console.WriteLine("Please enter your username");
                    Console.ReadLine();
                    Console.WriteLine("Please enter your PIN");
                    Console.ReadLine();

                    MemberMenu();
                    break;
                case "0":
                    break;
                default :
                    MainMenu();
                    break;



            }


        }

        // The staff menu 
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


                    ToolTypesAndCatergories();
                    Console.ReadLine();

                    AddingTools();


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

                    ToolTypesAndCatergories();
                    Console.ReadLine();

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

                    ToolTypesAndCatergories();
                    Console.ReadLine();

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
                    //MemberCollection memberCollection = new MemberCollection();
                    librarySystem.add(NewMember);
                    Console.WriteLine("New member " + NewMember.FirstName + "has been added");
                    

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

                    Console.WriteLine("Please enter first name you want to delete: ");
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

        // the member menu
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
                    BorrowToolLibrary();
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

                    ToolLibrarySystem ReturnTool = new ToolLibrarySystem();
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

                    ToolLibrarySystem toolLibrarySystem = new ToolLibrarySystem();
                    toolLibrarySystem.displayTopTHree();

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


        private static void UserInputCheck()
        {
            bool InputCorrect = false;
            while (InputCorrect == false)
            {
                string UserInput = Console.ReadLine();
            }
            
        }



        private static void AddingTools()
        {
            Console.Clear();

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

            MemberMenu();
        }
        private static void BorrowToolLibrary()
        {

        }

        private static void ToolTypesAndCatergories()
        {
            Console.WriteLine("1. GardeningTools");
            Console.WriteLine("2. FlooringTools");
            Console.WriteLine("3. FencingTools");
            Console.WriteLine("4. MeasuringTools");
            Console.WriteLine("5. CleaningTools");
            Console.WriteLine("6. PaintingTools");
            Console.WriteLine("7. ElectronicTools");
            Console.WriteLine("8. ElectricityTools");
            Console.WriteLine("9. AutomotiveTools");
            string MainCategory = Console.ReadLine();

            if (MainCategory == "1")
            {
                Subcategory1();
            }
            else if (MainCategory == "2")
            {
                Subcategory2();
            }
            else if (MainCategory == "3")
            {
                Subcategory3();
            }
            else if (MainCategory == "4")
            {
                Subcategory4();
            }
            else if (MainCategory == "5")
            {
                Subcategory5();
            }
            else if (MainCategory == "6")
            {
                Subcategory6();
            }
            else if (MainCategory == "7")
            {
                Subcategory7();
            }
            else if (MainCategory == "8")
            {
                Subcategory8();
            }
            else if (MainCategory == "9")
            {
                Subcategory9();
            }
            StaffMenu();
        }

        private static void Subcategory1()
        {
            Console.WriteLine("1. LineTrimmers");
            Console.WriteLine("2. LawnMovers");
            Console.WriteLine("3. HandTools");
            Console.WriteLine("4. Wheelbarrows");
            Console.WriteLine("5. GardenPowerTools");
        }

        private static void Subcategory2()
        {
            Console.WriteLine("1. Scrapers");
            Console.WriteLine("2. FloorLasers");
            Console.WriteLine("3. FloorLevellingTools");
            Console.WriteLine("4. FloorLevellingMaterials");
            Console.WriteLine("5. FloorHandTools");
            Console.WriteLine("6. TilingTools");
        }

        private static void Subcategory3()
        {
            Console.WriteLine("1. HandTools");
            Console.WriteLine("2. ElectricFencing");
            Console.WriteLine("3. SteelFencingTools");
            Console.WriteLine("4. PowerTools");
            Console.WriteLine("5. FencingAccessories");
        }

        private static void Subcategory4()
        {
            Console.WriteLine("1. DistanceTools");
            Console.WriteLine("2. LaserMeasurer");
            Console.WriteLine("3. MeasuringJugs");
            Console.WriteLine("4. TemperatureAndHumidityTools");
            Console.WriteLine("5. LevellingTools");
            Console.WriteLine("6. Markers");
        }

        private static void Subcategory5()
        {
            Console.WriteLine("Draining");
            Console.WriteLine("CarCleaning");
            Console.WriteLine("Vacuum");
            Console.WriteLine("PressureCleaners");
            Console.WriteLine("PoolCleaning");
            Console.WriteLine("FloorCleaning");
        }

        private static void Subcategory6()
        {
            Console.WriteLine("SandingTools");
            Console.WriteLine("Brushes");
            Console.WriteLine("Rollers");
            Console.WriteLine("PaintRemovalTools");
            Console.WriteLine("PaintScrapers");
            Console.WriteLine("Sprayers");
        }

        private static void Subcategory7()
        {
            Console.WriteLine("1. VoltageTester");
            Console.WriteLine("2. Oscilloscopes");
            Console.WriteLine("3. ThermalImaging");
            Console.WriteLine("4. DataTestTool");
            Console.WriteLine("5. InsulationTesters");
        }

        private static void Subcategory8()
        {
            Console.WriteLine("1. TestEquipment");
            Console.WriteLine("2. SafetyEquipment");
            Console.WriteLine("3. BasicHandTools");
            Console.WriteLine("4. CircuitProtection");
            Console.WriteLine("5. CableTools");
        }


        private static void Subcategory9()
        {
            Console.WriteLine("1. Jacks");
            Console.WriteLine("2. AirCompressors");
            Console.WriteLine("3. BatteryChargers");
            Console.WriteLine("4. SocketTools");
            Console.WriteLine("5. Braking");
            Console.WriteLine("6. DriveTrain");
        }

        

    }
}
