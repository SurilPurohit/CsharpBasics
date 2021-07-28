using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    public class Student
    {
        int id;
        string name;
        DateTime dateOfBirth;
        string collegeName;
        static int idinc = 101;
        string[] phoneno;

        // create properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
        public string CollegeName { get => collegeName; set => collegeName = value; }
        public string[] Phoneno { get => phoneno; set => phoneno = value; }

        //create constructors
        //static Student()
        //{
        //    collegeName = "KJSCE";
        //}

        public Student()
        {
            Id = idinc++;
            Name = null;
            DateOfBirth = DateTime.Now;
            CollegeName = collegeName;
            Phoneno = null;
        }

        public Student(int id, string name, DateTime dateOfBirth, string collegeName)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            CollegeName = collegeName;
            
        }

        //create get method
        public void getName()
        {
            Console.WriteLine("Enter your name:");
            Name = Console.ReadLine();
            //return Name;
        }
        public void getDob()
        {
            Console.WriteLine("Enter your DOB");
            DateOfBirth = DateTime.Parse(Console.ReadLine());
            //return DateOfBirth;
        }

        //public void getPhoneno(int n)
        //{
        //    for (int i = 0; i < n; i++)
        //    {
        //        Phoneno[i] = Console.ReadLine();
        //    }
        //}

        // create display method
        public void display()
        {
            Console.WriteLine("ID:" + Id + "    Name:" + Name + "     Birth Date:" + DateOfBirth + "    College Name:" + CollegeName);
        }

    }
}
