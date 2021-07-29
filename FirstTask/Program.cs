using System;
using System.Collections;
using System.Data.SqlClient;

namespace com.lti.casestudy.day1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Kevin here");
            //Student s = new Student(105,"Krisha",DateTime.Parse("2004-08-05"),"HR");
            //InMemoryAppEngine ia = new InMemoryAppEngine();
            ////ia.register(s);

            //DegCourse degc = new DegCourse(101,"B.Tech",4,200000,"0",true);
            ////ia.introduce(degc);
            //ia.listOfStudents();

        }
    }
}


//Student s = new Student("Suril", DateTime.Parse("1999-06-06"));
// Student s1 = new Student("Rishi", DateTime.Parse("1995-08-13"));
//Student s1 = new Student();
//s1.getName();
//s1.getDob();
//s1.getPhoneno(2);
//s1.display();
//Course c = new Course(1,"Suril",4,200000);
//DegCourse dc = new DegCourse(1, "Suril", 4, 200000,"0",true);
//dc.Accept();
//dc.CalculateMonthlyFee();
//DipCourse dipc = new DipCourse();
//dipc.Accept();
//dipc.CalculateMonthlyFee();
//Course c1 = new Course();
//Info i = new Info();
//i.display2(dc);

//PermanentEmp pe = new PermanentEmp();
//pe.Accept();
//pe.CalcPermSal();
//pe.Display();

//ContractEmp ce = new ContractEmp();
//ce.GetContractDetails();
//ce.calcContractSal();
//ce.DispContractDetails();

//scenario1();
//scenario2();
//scenario3();



//Student s = new Student("Suril", DateTime.Parse("1999-06-06"));
//DegCourse dc = new DegCourse(1, "B.Tech", 4, 200000, "0", true);
//Enroll imae = new Enroll(s, dc, DateTime.Parse("2021-07-07"));
//Info i = new Info();
//i.display3(s, dc, DateTime.Parse("2021-07-07"));


//PermanentEmp pe = new PermanentEmp();
//pe.Accept();
//pe.CalcSal(20000, 1000, 500);
//pe.Display();

//TemporaryEmp te = new TemporaryEmp();
//te.Accept();
//te.CalcSal(25000, 1000, 500);
//te.Display();
/*
public static void scenario2()
{
    ArrayList obj = new ArrayList();
    Student[] s = new Student[2];
    for (int i = 0; i < 2; i++)
    {
        s[i] = new Student();
        s[i].getName();
        s[i].getDob();
        obj.Add(s[i].Id);
        obj.Add(s[i].Name);
        obj.Add(s[i].DateOfBirth);
        obj.Add(s[i].CollegeName);
    }
    foreach (var item in obj)
    {
        Console.WriteLine(item);
    }
    //Info info = new Info();
    //for(int i = 0; i < 3; i++)
    //    info.display1(s[i]);
}
*/

/*
            Ado a = new Ado();
            a.disconnectedInsert();
            bool done = false;
            while (!done)
            {
                Console.WriteLine("1. Display All 2. Get Student by Id 3. Insert Student 4. Update DOB 5. Delete by ID 6. Insert by Stored Procedure 7.Exit");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1: a.displayStudent();
                        break;
                    case 2: a.getStudentById();
                        break;
                    case 3: a.insertStudent();
                        break;
                    case 4: a.updateDOB();
                        break;
                    case 5:a.deleteStudentById();
                        break;
                    case 6:a.insertProc();
                        break;
                    case 7: done = true;
                        break;
                    default: break;
                }
            }
            */

