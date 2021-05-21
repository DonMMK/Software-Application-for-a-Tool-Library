﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ToolLibrary
{
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

        public void RegisterMember()
        {
            Console.WriteLine("You have reached member class");
            UserName = firstname + lastname;
            // Add member to the array

            ShowMemberInfo();
        }
        

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
        
        public void ShowMemberInfo()
        {
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: " + LastName);
            Console.WriteLine("Contact Number: " + ContactNumber);
            Console.WriteLine("Password: " + PIN);

        }

        public string[] Tools => throw new NotImplementedException();

        public void addTool(Tool aTool)
        {
            // throw new NotImplementedException();

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