using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LumenWorks.Framework.IO.Csv;

namespace com.lti.casestudy.day1
{
    class readCsv
    {
        public static DataTable csvtable = new DataTable();

        public void get()
        {
            var myfile = @"C:\Users\Aarthi\source\repos\miniproject1\miniproject1\complaints.csv";
            var reader = new StreamReader(System.IO.File.OpenRead(myfile));
            //var csvReader = new CsvReader(reader, true);
            {
                csvtable.Load(csvReader);
                csvtable.Load();
            }

            reader.Close();
        }
    }
    class userReq : readCsv
    {
        public void GetcomplaintsbyYear()
        {
            int year;
            Console.WriteLine("enter year");
            year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(csvtable.Rows.Count);
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                char[] sep = { '/', '-' };
                string ts = Convert.ToString(csvtable.Rows[j][0]);
                string[] tspl = ts.Split(sep, 3, StringSplitOptions.None);

                int temp = Convert.ToInt32(tspl[2]);
                if (temp == year)
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);
                }
            }
        }
        public void getComplaintsbyBank()
        {
            string bankname;
            Console.WriteLine("enter bankname:");
            bankname = Console.ReadLine();
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                string temp = Convert.ToString(csvtable.Rows[j][5]);
                if (temp == bankname)
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);

                }
            }
        }
        public void Complaintbyid()
        {
            Console.WriteLine("enter complaint id:");
            double compid = Convert.ToDouble(Console.ReadLine());
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                double temp = Convert.ToDouble(csvtable.Rows[j][13]);
                if (temp == compid)
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);

                }
            }
        }
        public void Timetoclosecomplaint()
        {
            int index = 0;
            Console.WriteLine("enter complaint id:");
            double compid = Convert.ToDouble(Console.ReadLine());
            for (int i = 0; i < csvtable.Rows.Count; i++)
            {
                double temp = Convert.ToDouble(csvtable.Rows[i][13]);
                if (temp == compid)
                    index = i;

            }
            char[] sep = { '/', '-' };
            string startdatestr = Convert.ToString(csvtable.Rows[index][0]);
            string[] startspl = startdatestr.Split(sep, 3, StringSplitOptions.None);
            string enddatestr = Convert.ToString(csvtable.Rows[index][9]);
            string[] endspl = enddatestr.Split(sep, 3, StringSplitOptions.None);
            DateTime sd = Convert.ToDateTime(startspl[1] + '/' + startspl[0] + '/' + startspl[2]);
            DateTime ed = Convert.ToDateTime(endspl[1] + '/' + endspl[0] + '/' + endspl[2]);
            TimeSpan t = ed - sd;
            Console.WriteLine("Number of days took by the Bank to close the complaint:{0}", t.Days);
        }
        public void closedcomplaints()
        {
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                string str = Convert.ToString(csvtable.Rows[j][10]);
                if (str == "Closed" || str == "Closed with explanation")
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);
                }
            }
        }
        public void Timelyresponsed()
        {
            for (int j = 0; j < csvtable.Rows.Count; j++)
            {
                if (Convert.ToString(csvtable.Rows[j][11]) == "Yes")
                {
                    Console.WriteLine(" Date Received:{0}\n Product:{1}\n SubProduct:{2} Issue:{3}\n SubIssue:{4}\n Company:{5}\n State:{6}\n ZipCode:{7}\n Submittedvia:{8}\n Date Sent to Company:{9}\n Company Response to customer:{10}\n Timely response?:{11}\n Consumer Disputed:{12}\n Client Response:{13}\n", csvtable.Rows[j][0], csvtable.Rows[j][1], csvtable.Rows[j][2], csvtable.Rows[j][3], csvtable.Rows[j][4], csvtable.Rows[j][5], csvtable.Rows[j][6], csvtable.Rows[j][7], csvtable.Rows[j][8], csvtable.Rows[j][9], csvtable.Rows[j][10], csvtable.Rows[j][11], csvtable.Rows[j][12], csvtable.Rows[j][13]);

                }
            }
        }
        public void createComplaint()
        {
            Console.WriteLine("enter Date:");
            string datereceived = Console.ReadLine();
            Console.WriteLine("Enter Product:");
            string prod = Console.ReadLine();
            Console.WriteLine("enter subproduct:");
            string sprod = Console.ReadLine();
            Console.WriteLine("enter Issue:");
            string issue = Console.ReadLine();
            Console.WriteLine("enter subissue:");
            string sissue = Console.ReadLine();
            Console.WriteLine("enter company:");
            string company = Console.ReadLine();
            Console.WriteLine("enter state:");
            string state = Console.ReadLine();
            Console.WriteLine("enter zipcode:");
            string zip = Console.ReadLine();
            Console.WriteLine("enter Device through which complaint is submitted");
            string svia = Console.ReadLine();
            Console.WriteLine("enter Date sent to company:");
            string date_rec = Console.ReadLine();
            Console.WriteLine("enter Company response to consumer:");
            string c_resp = Console.ReadLine();
            Console.WriteLine("enter timely responded or not:");
            string istime = Console.ReadLine();
            Console.WriteLine("enter Consumer disputed?");
            string c_disp = Console.ReadLine();
            Console.WriteLine("enter Complaint ID:");
            string cid = Console.ReadLine();

            var myfile = @"C:\Users\Aarthi\source\repos\miniproject1\miniproject1\complaints.csv";
            var csv = new StringBuilder();
            var newline = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", datereceived, prod, sprod, issue, sissue, company, state, zip, svia, date_rec, c_resp, istime, c_disp, cid);
            csv.AppendLine(newline);
            File.AppendAllText(myfile, csv.ToString());

            //csv.WriteLine(newline);

            base.get();
        }

    }

    class Project1
    {
        static void Main(string[] args)
        {

            readCsv c = new readCsv();
            c.get();
            userReq u = new userReq();
            int loop = 1;
            while (loop != 0)
            {
                Console.WriteLine("enter 1.Display all the complaints based on the year\n 2.Display all the complaints based on the name of the bank \n 3.Display complaints based on the complaint id \n 4.Display number of days took by the Bank to close the complaint\n 5.Display all the complaints closed/closed with explanation\n 6.Display all the complaints which received a timely response\n 7.Create new complaint\n 8.exit\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        u.GetcomplaintsbyYear();
                        break;
                    case 2:
                        u.getComplaintsbyBank();
                        break;
                    case 3:
                        u.Complaintbyid();
                        break;
                    case 4:
                        u.Timetoclosecomplaint();
                        break;
                    case 5:
                        u.closedcomplaints();
                        break;
                    case 6:
                        u.Timelyresponsed();
                        break;
                    case 7:
                        u.createComplaint();
                        break;
                    default:
                        loop = 0;
                        break;
                }
            }

        }
    }
}
