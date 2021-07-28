using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    public class Enroll
    {
        private Student student;
        private Course course;
        private DateTime enrollmentDate;

        public Student Student { get => student; set => student = value; }
        public DateTime EnrollmentDate { get => enrollmentDate; set => enrollmentDate = value; }
        internal Course Course { get => course; set => course = value; }

        //constructors & getters/setters
        public Enroll()
        { }

        public Enroll(Student s, Course c, DateTime ed)
        {
            this.student = s;
            this.course = c;
            ed = DateTime.Now;
        }
    }
}
