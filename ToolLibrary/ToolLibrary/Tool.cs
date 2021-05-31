using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace ToolLibrary
{

    // Implemented
    public class Tool : iTool, IComparable<Tool>
    {
        private MemberCollection Borrowing_Tools = new MemberCollection();
        // private instance variables: Name Quantity MemberCollection NumberBorrowings 
        private string name;
        private int quantity;
        private int availablequantity;
        private int noborrowings;

        public string Name {
            get { return name; }
            set { name = value; }
        }
        public int Quantity {
            get { return quantity; }
            set { quantity = value; }
        }

        public int AvailableQuantity {
            get { return availablequantity; }
            set { availablequantity = value; }
        }
        public int NoBorrowings {
            get { return noborrowings;  }
            set { noborrowings = value; }
        }

        public MemberCollection GetBorrowers
        {
            get
            {
               return Borrowing_Tools;
            }
            set
            {
                Borrowing_Tools = value;
            }
                
        }

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
            Borrowing_Tools.add(aMember);
        }

        public int CompareTo(Tool other)
        {
          
            Tool another = other;
            if (this.Name.CompareTo(another.Name) < 0)
            {
                return -1;
            }
            else if (this.Name.CompareTo(another.Name) == 0)
            {
                return this.Name.CompareTo(another.Name);
            }
            else
            {
                return 1;
            }
        }

        public void deleteBorrower(Member aMember)
        {
            Borrowing_Tools.delete(aMember);
        }

        public override string ToString()
        {
            return name + "" + AvailableQuantity +  "" + NoBorrowings.ToString();
        }
    }
}
