using BATCH1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class DataBase_Stored_Procedure_parameters
    {
        public static void Main()
        {
            StoredProcedure();
            Console.ReadLine();
        }
        public static void StoredProcedure()
        {
            var ctx = new trainee1Context();

            var employees = ctx.Emps.FromSqlRaw($"GetAllEmpsDetailsByEmpNo @p0", 7788).ToList();


            foreach (var v in employees)
            {
                Console.WriteLine(v.Ename);
            }
        }
    }
}
