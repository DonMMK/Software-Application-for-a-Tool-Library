using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ToolLibrary
{
    public class Member : iMember, IComparable<Member>
    {
        public Member(string firstName, string lastName, string contactNumber , string pin)
        {

        }

        //Adding another constructor that takes in both first name and last name

        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ContactNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PIN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string[] Tools => throw new NotImplementedException();

        public void addTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(Member other)
        {
            throw new NotImplementedException();
        }

        public void deleteTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
