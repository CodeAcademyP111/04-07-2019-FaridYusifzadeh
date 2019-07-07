using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class GroupType
    {
        private static int ID;
        private int UniqueId;
        public string Typename { get; private set; }

        public GroupType(string type)
        {
            ID++;
            UniqueId = ID;
            Typename = type;
        }

        public int GetId()
        {
            return UniqueId;
        }
    }
}