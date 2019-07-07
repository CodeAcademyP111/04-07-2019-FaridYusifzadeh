using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Student
    {
        private static int ID;
        private int uniqueId;
        public string Name { get; set; }

        public Student(string name)
        {
            ID++;
            uniqueId = ID;
            Name = name;
        }

    }
}
