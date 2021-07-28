using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day
{
    public abstract class Employee
    {
        int eid { get; set; }
        string ename { get; set; }

        string email { get; set; }

        int age { get; set; }

        public double salary { get; set; }

        public Employee()
        { }

        public Employee(int eid, string ename, int age, string email, double salary)
        { }

        public virtual void Accept()
        {
            Console.WriteLine("Eid:");
            eid = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ename:");
            ename = Console.ReadLine();
            Console.WriteLine("Age:");
            age = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Email:");
            email = Console.ReadLine();
            Console.WriteLine("Salary:");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("Eid:{0} Ename:{1} Age:{2} Email:{3} Salary:{4}",eid,ename,age,email,salary);
        }

        public abstract void CalcSal(double basic, double hra, double allowance);

    }

    class PermanentEmp : Employee
    {

        int experienceInYears;
        string eDesignation;
        /*
        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("HRA:");
            hra = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("DA:");
            da = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PF:");
            pf = float.Parse(Console.ReadLine());
        }
        

        public override void Display()
        {
            base.Display();
            Console.WriteLine("HRA:" + hra);
            Console.WriteLine("DA:" + da);
            Console.WriteLine("PF:" + pf);
        }
        */

        public PermanentEmp() { }

        public PermanentEmp(int eid, string ename, int age, string email, double salary, int exp, string eDesig) : base(eid,ename,age,email,salary)
        {
            this.experienceInYears = exp;
            this.eDesignation = eDesig;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Experience in years:");
            experienceInYears = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Designation:");
            eDesignation = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Experience:{0} Designation:{1}", experienceInYears,eDesignation);
        }

        public override void CalcSal(double basic, double hra, double allowance)
        {
            if(experienceInYears < 5) 
                salary = (1.5 * basic) + hra + allowance;
            else if(experienceInYears >= 2) 
                salary = (2 * basic) + hra + (1.5 * allowance);
        }

    }

    class TemporaryEmp : Employee
    {
        int contractPeriodInYears;
        string contractName;

        public TemporaryEmp() { }

        public TemporaryEmp(int eid, string ename, int age, string email, double salary, int cp, string cn) : base(eid, ename, age, email, salary)
        {
            this.contractPeriodInYears = cp;
            this.contractName = cn;
        }

        /*
        float bonus { get; set; }
        float incentive { get; set; }
        public void GetContractDetails()
        {
            Accept();
            Console.WriteLine("Bonus:");
            bonus = float.Parse(Console.ReadLine());
            Console.WriteLine("Incentive:");
            incentive = float.Parse(Console.ReadLine());
        }

        public void DispContractDetails()
        {
            Display();
            Console.WriteLine("Bonus:" + bonus);
            Console.WriteLine("Incentive:" + incentive);
        }
        */

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Contract Period in years:");
            contractPeriodInYears = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Contract Name:");
            contractName = Console.ReadLine();
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("Contract Period:{0} Contract Name:{1}",contractPeriodInYears,contractName);
        }

        public override void CalcSal(double basic, double hra, double allowance)
        {
            if(contractPeriodInYears < 2)
                salary = (1.5 * basic) + hra + allowance;
            else if(contractPeriodInYears >= 2)
                salary = (2 * basic) + hra + allowance;

        }
    }
}

