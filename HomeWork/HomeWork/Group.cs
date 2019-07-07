using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Group
    {
        private static int ID;

        private int uniqueId;
        public string GroupName { get; set; }
        public GroupType Type { get; private set; }

        public readonly int Price;

        private Student[] students;

        private int countStudent;

        public Group(string name, GroupType type, int price, int count)
        {
            ID++;
            uniqueId = ID;
            GroupName = name;
            Type = type;
            Price = price;
            countStudent = count;
            students = new Student[0];
        }

        public void AddStudent(Student student, int price)
        {
            int exist_stdn_count = students.Length;
            if (exist_stdn_count < countStudent && price >= Price)
            {
                Array.Resize(ref students, exist_stdn_count + 1);
                students[exist_stdn_count] = student;
                Console.WriteLine(" Code Academy - ye qebul oldunuz ");
            }
            else
            {
                Console.WriteLine($"Qrup doludur {student.Name}");
            }
        }
        public void ListGroup()
        {
            foreach (var item in students)
            {
                Console.WriteLine($" Ad:{item.Name},Ixtisas: {Type.Typename},Grupun adi: {GroupName}");
            }
        }



    }
}