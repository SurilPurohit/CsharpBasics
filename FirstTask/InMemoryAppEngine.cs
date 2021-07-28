using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    public class InMemoryAppEngine : IAppEngine
    {
        public static string connStr = @"Data Source=(local);Database=Assignment;Integrated Security=true";
        public void enroll(Student student, DegCourse dc)
        {
            SqlConnection conn = new SqlConnection(InMemoryAppEngine.connStr);
            conn.Open();
            int cid = dc.id;
            string cname = dc.name;
            float duration = dc.duration;
            float fees = dc.fees;
            //string level = dc.level;
            bool placement = dc.isPlacementAvailable;
            int sid = student.Id;
            string name = student.Name;
            DateTime dob = student.DateOfBirth;
            string clgname = student.CollegeName;
        }

        public void introduce(DegCourse dc)
        {
            SqlConnection conn = new SqlConnection(InMemoryAppEngine.connStr);
            conn.Open();
            int sid = dc.id;
            string name = dc.name;
            float duration= dc.duration;
            float fees = dc.fees;
            //string level = dc.level;
            bool placement = dc.isPlacementAvailable;
            SqlCommand cmd = new SqlCommand("INSERT INTO DegCourse values(@sid,@name,@duration,@fees,@placement)", conn);
            SqlParameter sp = new SqlParameter();
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@duration", duration);
            cmd.Parameters.AddWithValue("@fees", fees);
            cmd.Parameters.AddWithValue("@placement", placement);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("New Course Addded!");

            conn.Close();
        }

        public List<Enroll> listOfEnrollments()
        {
            throw new NotImplementedException();
        }

        public List<Student> listOfStudents()
        {
            SqlConnection conn = new SqlConnection(InMemoryAppEngine.connStr);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Student> l = new List<Student>();
            while (reader.Read())
            {
                Console.WriteLine("{0}  {1}    {2}           {3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                Console.WriteLine("{0} {1} {2} {3}", reader[0], reader[1], reader[2], reader[3]);
                l.Add(new Student(Convert.ToInt32(reader[0]),Convert.ToString(reader[1]),Convert.ToDateTime(reader[2]),Convert.ToString(reader[3])));
            }
            conn.Close();
            return l;
        }

        public void register(Student student)
        {
            SqlConnection conn = new SqlConnection(InMemoryAppEngine.connStr);
            conn.Open();
            int sid = student.Id;
            string name = student.Name;
            DateTime dob = student.DateOfBirth;
            string clgname = student.CollegeName;
            SqlCommand cmd = new SqlCommand("INSERT INTO Student values(@sid,@name,@dob,@clgname)", conn);
            SqlParameter sp = new SqlParameter();
            cmd.Parameters.AddWithValue("@sid", sid);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@clgname", clgname);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("New Student Addded!");

            conn.Close();
        }
    }

}
