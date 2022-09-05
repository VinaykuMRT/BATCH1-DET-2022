using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    public class Empl
    {

        //data declared inside class are known as "fields"
        int id;
        string name;
        string dept;
        double sal;
        DateOnly doj;

        public Empl()
        {
        }

        //constructor - is a function used to init object data
        //has the same name as classname, no ret type
        public Empl(int eid, string ename, DateOnly doj)
        {
            id = eid; name = ename; this.doj = doj;
        }

        public int Empno { get; internal set; }
        public string Ename { get; internal set; }
        public int Sal { get; internal set; }
        public int Deptno { get; internal set; }
        public string Job { get; internal set; }

        //function written inside a class is known as method
        public int GetYearsofExp()
        {
            return DateTime.Now.Year - doj.Year;
        }

        public object Print()
        {
          throw new NotImplementedException();
        }
    }


}

