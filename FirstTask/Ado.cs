using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace com.lti.casestudy.day1
{
    class Ado
    {
        public static string connStr = @"Data Source=(local);Database=Students;Integrated Security=true";
        SqlConnection conn = new SqlConnection(Ado.connStr);
        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public void displayStudent()
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * from Student", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine("{0}  {1}    {2}           {3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
                Console.WriteLine("{0} {1} {2} {3}", reader[0], reader[1], reader[2], reader[3]);
            }
            conn.Close();
        }

        public void getStudentById()
        {
            conn.Open();
            Console.WriteLine("Enter ID to found: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            SqlCommand sql = new SqlCommand("Select * from Student where id=@sid", conn);
            SqlParameter sp = new SqlParameter();
            sp.ParameterName = "@sid";
            sp.Value = sid;
            sql.Parameters.Add(sp);
            SqlDataReader reader = sql.ExecuteReader();
            Console.WriteLine("{0} {1} {2} {3}", reader.GetName(0), reader.GetName(1), reader.GetName(2), reader.GetName(3));
            while (reader.Read())
            {
                Console.WriteLine("{0} {1} {2} {3}", reader[0], reader[1], reader[2], reader[3]);
            }
            conn.Close();

        }

        public void insertStudent()
        {
            conn.Open();
            Console.WriteLine("Enter ID: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Date: ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter College Name: ");
            string clgname = Console.ReadLine();
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

        public void updateDOB()
        {
            Console.WriteLine("Enter Student ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DOB:");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            conn.Open();
            string query = "Update Student set dob=@dob where id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("Student Data Updated!");

            conn.Close();
        }

        public void deleteStudentById()
        {
            Console.WriteLine("Enter Student ID:");
            int id = Convert.ToInt32(Console.ReadLine());
            conn.Open();
            string query = "Delete from Student where id=@id";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", id);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("Student Data Deleted!");

            conn.Close();
        }

        public void insertProc()
        {
            conn.Open();
            Console.WriteLine("Enter ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Date: ");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter College Name: ");
            string collegeName = Console.ReadLine();
            string query = "sp_AddStudent";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter sp = new SqlParameter();
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@dob", dob);
            cmd.Parameters.AddWithValue("@collegeName", collegeName);

            int result = cmd.ExecuteNonQuery();
            if (result > 0)
                Console.WriteLine("New Student Addded by Stored Procedure!");

            conn.Close();
        }

        public void disconnectedSelect()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", conn);
            

            //da.Fill(dt);

            //foreach (DataRow row in dt.Rows)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}",row[0],row[1],row[2],row[3]);
            //}

            
            da.Fill(ds,"Student");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Console.WriteLine("{0} {1} {2} {3}", row[0], row[1], row[2], row[3]);
            }
            //da.Update(dt);
        }

        public void disconnectedUpdate()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from Student", conn);

            da.Fill(dt);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            //code to modify/manipulate the data
            foreach (DataRow row in dt.Rows)
            {
                row[3] = "KJSCE";
            }

            da.Update(dt);
        }

        public void disconnectedInsert()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Student", conn);
            da.Fill(dt);

            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            DataRow row = dt.NewRow();

            row[0] = 104;
            row[1] = "Aditya";
            row[2] = DateTime.Now;
            row[3] = "KJSCE";

            dt.Rows.Add(row);
            da.Update(dt);
        }

    }
}
