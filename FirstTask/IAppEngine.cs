using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    interface IAppEngine
    {
        public void introduce(DegCourse dc);
        public void register(Student student);
        public List<Student> listOfStudents();
        public void enroll(Student student, DegCourse dc);
        public List<Enroll> listOfEnrollments();

    }
}
