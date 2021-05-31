using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    // Implemented
    public class MemberCollection : iMemberCollection
    {
        BSTree MemberTree = new BSTree();
        private int number = 0;
        public int Number { get { return number; } }
        
        public void add(Member aMember)
        {
            MemberTree.Insert(aMember);
            number++;
        }

        public void delete(Member aMember)
        {
            MemberTree.Delete(aMember);
            number--;
        }

        public bool search(Member aMember)
        {
            return MemberTree.Search(aMember);
        }

        public Member[] toArray()
        {
            return MemberTree.InOrderTraverse();
        }
    }
}
