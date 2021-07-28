using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    class Info
    {
        public void display1(Student s)
        {
            Console.WriteLine("ID:{0}  Name:{1}  Birth Date:{2}  College Name:{3}",s.Id, s.Name, s.DateOfBirth, s.CollegeName); //+ "        phoneno" + s.Phoneno);
        }

        public void display2(Course c)
        {
            Console.WriteLine("ID:{0}  Name:{1}  Duration:{2}  Fees:{3}", c.id, c.name, c.duration, c.fees);
        }

        public void display3(Student s, Course c, DateTime ed)
        {
            Console.WriteLine("Student:");
            Console.WriteLine("ID:{0}  Name:{1}  Birth Date:{2}  College Name:{3}", s.Id, s.Name, s.DateOfBirth, s.CollegeName);
            Console.WriteLine("Course:");
            Console.WriteLine("ID:{0}  Name:{1}  Duration:{2}  Fees:{3}", c.id, c.name, c.duration, c.fees);
            Console.WriteLine("DateTime: {0}", ed);
        }
    }
}
