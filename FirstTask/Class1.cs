using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Class1
    {
        //SELECT * FROM myemplist;
        //from i in myemplist select i;
        //var res = myempList.Select(i => i);

        //SELECT * FROM myemplist where E_sal>25000;
        //var result=from s in myemplist where s.ESal>25000 select s;
        //var result = myempList.Where(e => e.E_salary > 25000).Select(i=>i);

        //SELECT eid,ename from myemplist where esal>10000;
        //var result=from i in myemplist where i.Esal>10000 select (i.EId,i.EName);
        //var result=myemplist.Where(e=>e.E_salary>10000).select(e=>new { i.E_salary, i.E_name, i.E_id });

        //SELECT count(*) from myemplist;
        //var result = (from emp in myempList select emp).Count();
        //var result = myempList.Select(i => i).Count();

        //SELECT Max(Salary) from myemplist WHERE eid between 10001 and 10015;
        //var res = (from emp in myempList where (emp.E_id > 10001 && emp.E_id < 10015) select emp.E_salary).Max();
        //var result = myempList.Where(e => e.E_id > 10001 && e.E_id < 10015).Select(i => i.E_salary).Max();
    }
}
