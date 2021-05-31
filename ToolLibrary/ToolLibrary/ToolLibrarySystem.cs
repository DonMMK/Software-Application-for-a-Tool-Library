using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    class ToolLibrarySystem : iToolLibrarySystem
    {
        MemberCollection memberCollection = new MemberCollection();

        private ToolCollection Selected_Collection;

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


        // method to add a tool to the library system
        public void add(Tool aTool)
        {
            Selected_Collection.add(aTool);
        }

        // method to add more quantity of the tool
        public void add(Tool aTool, int quantity)
        {
            aTool.Quantity = aTool.Quantity + 1;
        }

        // logic implemented to borrow a tool by the member
        public void borrowTool(Member aMember, Tool aTool)
        {
            --aTool.AvailableQuantity;
            aMember.addTool(aTool);
        }

        // logic implemented to delete a tool in the system
        public void delete(Tool aTool)
        {
            Selected_Collection.delete(aTool);
        }

        // logic implemented to delete a piece of the tool in the system
        public void delete(Tool aTool, int quantity)
        {
            delete(aTool);
        }

        // display all the tools the member is currenlty borrowing
        public void displayBorrowingTools(Member aMember)
        {
            string[] Tools_Borrowed = new string[aMember.Tools.Length];
            Console.WriteLine(Tools_Borrowed);

        }

        // display all the tools of a tool type selected by a member
        public void displayTools(string aToolType)
        {
            Console.WriteLine(aToolType);
        }

        //get a list of tools that are currently held by a given member
        public string[] listTools(Member aMember)
        {
            string[] Tools_Borrowed = new string[aMember.Tools.Length];
            return Tools_Borrowed;
        }

        // method implemented to 
        public void returnTool(Member aMember, Tool aTool)
        {
            aMember.deleteTool(aTool);
            string[] Tools_Borrowed = new string[aMember.Tools.Length];
            --aTool.AvailableQuantity;
        }


        // add a new memeber to the system
        public void add(Member aMember)
        {
            memberCollection.add(aMember);
        }

        // delete a member from the system
        public void delete(Member aMember)
        {
            memberCollection.delete(aMember);
        }

        // Display top three most frequently borrowed tools by the members in the descending order by the number of times each tool has been borrowed.
        public void displayTopTHree()
        {
            static void TopThreeSort(Tool[] ThreeToolsBorrowed, Tool[] Tools_Borrowed)
            {
                
                int LengthForLoop = ThreeToolsBorrowed.Length;
                for (int i = 0; i < LengthForLoop; i++)
                {

                    for (int j = 0; j < LengthForLoop; j++)
                    {
                        if (ThreeToolsBorrowed[i] == null)
                        {
                            ThreeToolsBorrowed[i] = Tools_Borrowed[i];
                            break;
                        }

                        else if (i == 1 && ThreeToolsBorrowed[i] == null && ThreeToolsBorrowed[0] != null)
                        {
                            ThreeToolsBorrowed[i] = Tools_Borrowed[i];
                            break;
                        }


                        
                        else if (Tools_Borrowed[1] != null )
                        {
                            ThreeToolsBorrowed[i] = Tools_Borrowed[j];
                            break;
                        }
                        
                        else if (i == 0)
                        {
                            ThreeToolsBorrowed[i] = Tools_Borrowed[j];
                            break;
                        }
                        else if (i == 2 && ThreeToolsBorrowed[i] == null && ThreeToolsBorrowed[0] != null)
                        {

                            ThreeToolsBorrowed[i] = Tools_Borrowed[j];
                            break;
                        }
                    }
                }
                    
            }


        }

        private static Tool[] insertTools(Tool[] tools, Tool tool)
        {
            Tool[] NewToolsArray = new Tool[tools.Length + 1];



            int i = 0;
            while (i < tools.Length)
            {
                i++;
                NewToolsArray[i] = tools[i];

                NewToolsArray[NewToolsArray.Length - 1] = tool;

                return NewToolsArray;

            }

            return NewToolsArray;
        }


        private static void InsertionSort(Tool[] Arrayy)
        {

            int n = Arrayy.Length;

            int i = 0;
            int numm = Arrayy.Length;
            while (i <= numm -1 )
            {
                Tool sizeeA = Arrayy[i];
                int j = i - 1;
                for ( int jj = 1;  jj >= 0; jj++ ) {
                    while (j >= 0 && Arrayy[j].NoBorrowings.CompareTo(sizeeA.NoBorrowings) == -1)
                    {
                        for (jj = 1; jj >= 0; jj++)
                        {
                            Arrayy[j + 1] = Arrayy[j];
                            j = j - 1;
                        }
                        
                    }
                    Arrayy[j + 1] = sizeeA;
                }
                
            }
        }
    }
}


