using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ToolLibrary
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

    enum MeasuringTools_Types: int
    {
        DistanceTools = 1,
        LaserMeasurer = 2,
        MeasuringJugs = 3,
        TemperatureAndHumidityTools = 4
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

    enum ElectricityTools_Types: int
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







    public class Tool : iTool, IComparable<Tool>
    {
        // private instance variables: Name Quantity MemberCollection NumberBorrowings 
        private string name;
        private int quantity;
        private int availablequantity;
        private int noborrowings;

        public string Name { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }
        public int Quantity { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public int AvailableQuantity { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public int NoBorrowings { 
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }

        public MemberCollection GetBorrowers => throw new NotImplementedException();

        public Tool(string Name, int Quantity, int AvailableQuantity, int NoBorrowers)
        {
            this.Name = Name;
            this.Quantity = Quantity;
            this.AvailableQuantity = AvailableQuantity;
            this.NoBorrowings = NoBorrowers;
        }

        public Tool()
        {

        }

        public void AddTool()
        {

        }

        public void ShowAllTools()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Quantity: " + Quantity);
            Console.WriteLine("Available Quantity: " + AvailableQuantity);
            Console.WriteLine("Number of Borrowings: " + NoBorrowings);
        }

        public void addBorrower(Member aMember)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Tool other)
        {
            throw new NotImplementedException();
        }

        public void deleteBorrower(Member aMember)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
