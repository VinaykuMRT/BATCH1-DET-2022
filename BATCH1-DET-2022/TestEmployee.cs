using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class TestEmployee
    {
        public static void Main()
        {
            Employee ceo = new Employee(1, "Tony stark", "ballary", 457644, 75000, 7500);
            double Net = ceo.GetNetsalary();
            string gread = ceo.GetGrade();
            Console.WriteLine($"Net salary={Net},gread={gread}");
        }
    }
}
