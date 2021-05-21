using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    public class ToolCollection : iToolCollection
    {
        // Tools => ToolArray 
        private static int NumberofTools = 0;
        private static Tool[] ToolsArray = new Tool[NumberofTools];

        public int Number => throw new NotImplementedException();


        //add a given tool to this tool collection
        public void add(Tool aTool)
        {
            throw new NotImplementedException();
        }

        //delete a given tool from this tool collection
        public void delete(Tool aTool)
        {
            throw new NotImplementedException();
        }

        //search a given tool in this tool collection. Return true if this tool is in the tool collection; return false otherwise
        public bool search(Tool aTool)
        {
            throw new NotImplementedException();
        }

        // output the tools in this tool collection to an array of iTool
        public Tool[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
