using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.lti.casestudy.day1
{
    public abstract class Course
    {
        public int id;
        public string name;
        public float duration;
        public float fees;

        public Course(){
            id = 0;
            name = null;
            duration = 0;
            fees = 10000;
        }

        public Course(int id, string name, float duration, float fees)
        {
            this.id = id;
            this.name = name;
            this.duration = duration;
            this.fees = fees;
        }

        public virtual void Accept()
        {
            Console.WriteLine("Id:");
            id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Name:");
            name = Console.ReadLine();
            Console.WriteLine("Duration:");
            duration = float.Parse(Console.ReadLine());
            Console.WriteLine("Fees:");
            fees = float.Parse(Console.ReadLine());
        }

        public abstract void CalculateMonthlyFee();
    
    }

    public class DegCourse : Course
    {
        enum level{ 
            Bachelors,
            Masters
        };
        public bool isPlacementAvailable;
        public int l;

        public DegCourse(int id, string name, float duration, float fees,string level, bool placement):base(id,name,duration,fees)
        {
            level = level;
            isPlacementAvailable = placement;
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Level of Degree: 0 for Bachelors and 1 for Masters");
            l = Convert.ToInt16(Console.ReadLine());
        }

        public override void CalculateMonthlyFee()
        {
            if (isPlacementAvailable)
            {
                //base.CalculateMonthlyFee();
                fees += (fees * duration) + (float)(0.1 * fees);
            }
            else
            {
                //base.CalculateMonthlyFee();
                fees *= duration;
            }
        }
    }

    class DipCourse : Course
    {
        int dic;

        enum type {
            professional, 
            academic
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter 0 for Profeessional and 1 for academic");
            dic = Convert.ToInt16(Console.ReadLine());
        }

        public override void CalculateMonthlyFee()
        {
            if ((int)type.professional == dic)
            {
                fees = (float)(fees * duration + 0.1 * fees);
            }
            else 
            {
                fees = (float)(fees * duration + 0.05 * fees);
            }
        }
    }
}