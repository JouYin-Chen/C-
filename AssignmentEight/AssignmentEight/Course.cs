﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEight
{
    class Course
    {
        public string CourseName;
        public static int count;
        public int countnum
        {
            get { return count; }
        }
        public List<Student> cstudent;
        public Course(string CourseName)
        {
            this.CourseName = CourseName;
            cstudent = new List<Student>();
            // cTeachers = new Teacher();
        }
        public void AddStudent(Student a)
        {
            cstudent.Add(a);
            count++;
        }
        public void ListStudent()
        {
            foreach (Student c in cstudent)
            {
                Console.WriteLine("Name:{0} {1}", c.FirstName, c.LastName);
                Console.WriteLine("Grades:");
                while (c.Grades.Count > 0)
                    Console.WriteLine("　　　{0}", c.Grades.Pop());
            }
        } 
    }
}
