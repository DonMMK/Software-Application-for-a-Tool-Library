using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    
    //Using enums to store the Tool Types and categories
    //enum ToolCatergories : int
    //{
    //    GardeningTools = 1,
    //    FlooringTools = 2,
    //    FencingTools = 3,
    //    MeasuringTools = 4,
    //    CleaningTools = 5,
    //    PaintingTools = 6,
    //    ElectronicTools = 7,
    //    ElectricityTools = 8,
    //    AutomotiveTools = 9
    //}

    //enum GardeningTools_Types : int
    //{
    //    LineTrimmers = 1,
    //    LawnMovers = 2,
    //    HandTools = 3,
    //    Wheelbarrows = 4,
    //    GardenPowerTools = 5
    //}

    //enum FlooringTools_Types : int
    //{
    //    ScrapersFloorLasersFloorLevellingToolsFloorLevellingMaterialsFloorHandToolsTilingTools
    //}

    //enum FencingTools_Types : int
    //{
    //    LineTrimmers = 1,
    //    LawnMovers = 2,
    //    HandTools = 3,
    //    Wheelbarrows = 4,
    //    GardenPowerTools = 5
    //}

    //enum MeasuringTools_Types : int
    //{
    //    LineTrimmers = 1,
    //    LawnMovers = 2,
    //    HandTools = 3,
    //    Wheelbarrows = 4,
    //    GardenPowerTools = 5
    //}

    //enum CleaningTools_Types : int
    //{
    //    DrainingCarCleaningVacuumPressureCleanersPoolCleaningFloorCleaning
    //}

    //enum PaintingTools_Types : int
    //{
    //    LineTrimmers = 1,
    //    LawnMovers = 2,
    //    HandTools = 3,
    //    Wheelbarrows = 4,
    //    GardenPowerTools = 5
    //}
    //enum ElectronicTools_Types : int
    //{
    //    VoltageTester = 1,Oscilloscopes = 2,ThermalImaging = 3,DataTestTool = 4,InsulationTesters = 5
    //}

    //enum ElectricityTools_Types : int
    //{
    //    TestEquipment = 1,SafetyEquipment = 2,BasicHandTools = 3,CircuitProtection = 4,CableTools = 5
    //}

    //enum AutomotiveTools_Types : int
    //{
    //    Jacks = 1,AirCompressors = 2,BatteryChargers = 3,SocketTools = 4,Braking = 5,DriveTrain = 6
    //}




    class ToolLibrarySystem : iToolLibrarySystem
    {
        MemberCollection memberCollection = new MemberCollection();

        string[][] AllTools = new string[9][]
        {
            new string[] {"LineTrimmers","LawnMovers","HandTools","Wheelbarrows","GardenPowerTools"},
            new string[] {"Scrapers","FloorLasers","FloorLevellingTools","FloorLevellingMaterials","FloorHandTools","TilingTools"},
            new string[] {"HandTools","ElectricFencing","SteelFencingTools","PowerTools","FencingAccessories"},
            new string[] {"DistanceTools","LaserMeasurer","MeasuringJugs","TemperatureAndHumidityTools","LevellingTools","Markers"},
            new string[] {"Draining","CarCleaning","Vacuum","PressureCleaners","PoolCleaning","FloorCleaning"},
            new string[] {"SandingTools","Brushes","Rollers","PaintRemovalTools","PaintScrapers","Sprayers"},
            new string[] {"VoltageTester","Oscilloscopes","ThermalImaging","DataTestTool","InsulationTesters"},
            new string[] {"TestEquipment","SafetyEquipment","BasicHandTools","CircuitProtection","CableTools"},
            new string[] {"Jacks","AirCompressors","BatteryChargers","SocketTools","Braking","DriveTrain"},
        };

        public void add(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void add(Tool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void add(Member aMember)
        {
            memberCollection.add(aMember);
        }

        public void borrowTool(Member aMember, Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(Tool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void displayBorrowingTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            throw new NotImplementedException();
        }

        public string[] listTools(Member aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(Member aMember, Tool aTool)
        {
            throw new NotImplementedException();
        }
    }
}
