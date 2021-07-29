using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Banking
    {
        public static int balance = 10000;
        public int withdraw(int x)
        {
            return balance - x;
        }

        public int deposit(int x)
        {
            return balance + x;
        }
    }
}
