using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{

    // Implemented
    public class ToolCollection : iToolCollection
    {
        // Number of tools
        private int NumberTools;
        // Tools => ToolArray 
        private static int NumberofTools = 20;
        private Tool[] ToolsArray = new Tool[NumberofTools];
        public int Number
        {
            get
            {
                return NumberTools;
            }
        }

        //add a given tool to this tool collection
        public void add(Tool aTool)
        {
            for (int count = 0; count < ToolsArray.Length; count++)
            {
                ToolsArray[count] = null;
                NumberTools++;
                break;
            }
        }

        //delete a given tool from this tool collection
        public void delete(Tool aTool)
        {
            for (int count = 0; count < ToolsArray.Length; count++)
            {
                ToolsArray[count] = null;
                NumberTools--;
                break;
            }
        }

        //search a given tool in this tool collection. Return true if this tool is in the tool collection; return false otherwise
        public bool search(Tool aTool)
        {
            bool ctrue = true;
            bool cfalse = false;
            for (int count = 0; count < Number; count++)
                
                if (ToolsArray[ count].Equals(aTool))

                    return ctrue;

            return cfalse;
        }

        // output the tools in this tool collection to an array of iTool
        public Tool[] toArray()
        {
            return ToolsArray;
        }

        // Jaggered array was the first choice but due to difficulty implementing as 2D array a dictionary list was used
        // Cite: Discussion among peers on slack
        public Dictionary<int, ToolCollection> Gardening_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection LineTrimmers = new ToolCollection();
        private ToolCollection lawnMowers = new ToolCollection();
        private ToolCollection gHandTools = new ToolCollection();
        private ToolCollection wheelbarrows = new ToolCollection();
        private ToolCollection gardenPowerTools = new ToolCollection();


        public Dictionary<int, ToolCollection> Flooring_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection Scrapers = new ToolCollection();
        private ToolCollection FloorLasers = new ToolCollection();
        private ToolCollection FloorLevellingTools = new ToolCollection();
        private ToolCollection FloorLevellingMaterials = new ToolCollection();
        private ToolCollection FloorHandTools = new ToolCollection();
        private ToolCollection TilingTools = new ToolCollection();


        public Dictionary<int, ToolCollection> Fencing_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection FEN_HandTools = new ToolCollection();
        private ToolCollection ElectricFencing = new ToolCollection();
        private ToolCollection SteelFencingTools = new ToolCollection();
        private ToolCollection PowerTools = new ToolCollection();
        private ToolCollection FencingAccessories = new ToolCollection();


        public Dictionary<int, ToolCollection> Measuring_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection DistanceTools = new ToolCollection();
        private ToolCollection LaserMeasurer = new ToolCollection();
        private ToolCollection MeasuringJugs = new ToolCollection();
        private ToolCollection TempuratureHumidityTools = new ToolCollection();
        private ToolCollection LevellingTools = new ToolCollection();
        private ToolCollection Markers = new ToolCollection();



        public Dictionary<int, ToolCollection> Cleaning_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection Draining = new ToolCollection();
        private ToolCollection CarCleaning = new ToolCollection();
        private ToolCollection Vacuum = new ToolCollection();
        private ToolCollection PressureCleaners = new ToolCollection();
        private ToolCollection PoolCleaning = new ToolCollection();
        private ToolCollection FloorCleaning = new ToolCollection();


        public Dictionary<int, ToolCollection> Painting_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection SandingTools = new ToolCollection();
        private ToolCollection Brushes = new ToolCollection();
        private ToolCollection Rollers = new ToolCollection();
        private ToolCollection PaintRemovalTools = new ToolCollection();
        private ToolCollection PaintScrapers = new ToolCollection();
        private ToolCollection Sprayers = new ToolCollection();


        public Dictionary<int, ToolCollection> Electronic_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection VoltageTester = new ToolCollection();
        private ToolCollection Oscilloscopes = new ToolCollection();
        private ToolCollection ThermalImaging = new ToolCollection();
        private ToolCollection DataTestTool = new ToolCollection();
        private ToolCollection InsulationTesters = new ToolCollection();


        public Dictionary<int, ToolCollection> Electricity_Tools = new Dictionary<int, ToolCollection>();
        ToolCollection TestEquipment = new ToolCollection();
        ToolCollection SafetyEquipment = new ToolCollection();
        ToolCollection BasicHandTools = new ToolCollection();
        ToolCollection CircuitProtection = new ToolCollection();
        ToolCollection CableTools = new ToolCollection();


        public Dictionary<int, ToolCollection> Automotive_Tools = new Dictionary<int, ToolCollection>();
        private ToolCollection Jacks = new ToolCollection();
        private ToolCollection AirCompressors = new ToolCollection();
        private ToolCollection BatteryChargers = new ToolCollection();
        private ToolCollection SocketTools = new ToolCollection();
        private ToolCollection Braking = new ToolCollection();
        private ToolCollection Drivetrain = new ToolCollection();

    }
}
