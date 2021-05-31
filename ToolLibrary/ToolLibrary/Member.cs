using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ToolLibrary
{
    // Implemented
    public class Member : iMember, IComparable<Member>
    {
        // all simple is for the private variables
        // all capital is the public method
        // with both is the constructor

        private string firstname;
        private string lastname;
        private string contactnumber;
        private string pin;
        //Adding another constructor that takes in both first name and last name

        public string FirstName {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName {
            get { return lastname; }
            set { lastname = value; }
        }
        public string ContactNumber { 
            get { return contactnumber; }
            set { contactnumber = value; }
        }
        public string PIN { 
            get { return pin; }
            set { pin = value; }
        }

        public string UserName;

        string[] NewTools = new string[20];
        
        public Tool[] BorrowedTool = new Tool[9];

        public Member(string firstName, string lastName, string contactNumber, string pIN)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.contactnumber = contactNumber;
            this.pin = pIN;
        }

        public Member()
        {

        }
        
        public string[] Tools
        {
            get
            {
                return NewTools;
            }
        }

        public void addTool(Tool aTool)
        {
            for (int count = 0; count < NewTools.Length; count++)
            {
                NewTools[count] = firstname;
                    break;
            }

        }

        public int CompareTo(Member other)
        {
            //throw new NotImplementedException();
            Member another = other;
            if (this.LastName.CompareTo(another.LastName) < 0)
            {
                return -1;
            }else if(this.LastName.CompareTo(another.LastName) == 0)
            {
                return this.FirstName.CompareTo(another.FirstName);
            }
            else
            {
                return 1;
            }
        }

        public void deleteTool(Tool aTool)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return FirstName + LastName.ToString();
        }
    }
}
