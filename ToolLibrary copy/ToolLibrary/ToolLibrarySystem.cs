﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    class ToolLibrarySystem : iToolLibrarySystem
    {
        public void add(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void add(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void add(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void borrowTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool)
        {
            throw new NotImplementedException();
        }

        public void delete(iTool aTool, int quantity)
        {
            throw new NotImplementedException();
        }

        public void delete(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void displayBorrowingTools(iMember aMember)
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

        public string[] listTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void returnTool(iMember aMember, iTool aTool)
        {
            throw new NotImplementedException();
        }
    }
}