using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ToolLibrary
{

    

   
    



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
