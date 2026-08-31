using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Student
    {

        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public int DeptId { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student()
        {
            
        }

        public Student(int id, string fName, string lName, int age, int deptId, List<Subject> subjects)
        {
            Id = id;
            FName = fName;
            LName = lName;
            Age = age;
            DeptId = deptId;
            Subjects = subjects;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Name = {FName} {LName}, Age = {Age}";
        }

    }
}
