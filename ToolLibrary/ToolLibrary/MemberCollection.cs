using System;
using System.Collections.Generic;
using System.Text;

namespace ToolLibrary
{
    public class MemberCollection : iMemberCollection
    {
        BSTree MemberTree = new BSTree();
        public int Number => throw new NotImplementedException();

        public void add(Member aMember)
        {
            MemberTree.Insert(aMember);   
        }

        public void delete(Member aMember)
        {
            MemberTree.Delete(aMember);
        }

        public bool search(Member aMember)
        {
            throw new NotImplementedException();
        }

        public Member[] toArray()
        {
            throw new NotImplementedException();
        }
    }
}
