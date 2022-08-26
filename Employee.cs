using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Employee
    {
        int rollno;
        string name;
        string address;
        int EmployeePhone;
        int Gsalary;
        int pf;

        public Employee(int rollno, string name, string address, int employeePhone, int gsalary, int pf)
        {
            this.rollno = rollno;
            name = name;
            address = address;
            EmployeePhone = employeePhone;
            Gsalary = gsalary;
            this.pf = pf;
        }
        public double GetNetsalary()
        {
            return (Gsalary - pf);
        }
        public string GetGrade()
        {
            double net = GetNetsalary();
            if(net>10000)
            {
                return "A";

            }
            else if (net >5000 && net <10000)
            {
                return "b";
            }
            else
            {
                return "c";
            }
        }
    }
}
