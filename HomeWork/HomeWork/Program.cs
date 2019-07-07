using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
           
            GroupType programming = new GroupType("programming");
            GroupType design = new GroupType("design");
            GroupType marketing = new GroupType("marketing");

            Group p111 = new Group("P111", programming, 15000, 3);
            Group d111 = new Group("D111", design, 10000, 16);
            Group m111 = new Group("M111", marketing, 8000, 8);

            Student reshad = new Student("Reshad");
            Student aynur = new Student("Aynur");
            Student orxan = new Student("Orxan");


            p111.AddStudent(aynur, 20000);
            p111.AddStudent(orxan, 15000);
            p111.AddStudent(reshad, 15000);
            p111.ListGroup();
           

       

        }
    }


}