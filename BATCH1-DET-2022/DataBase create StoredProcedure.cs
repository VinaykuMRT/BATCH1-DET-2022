using BATCH1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class DataBase_create_StoredProcedure
    {
        public static void Main()
        {
            //UpdateNewEmployee();
            GetEmployeesSP();
            Console.ReadLine();
        }
        private static void GetEmployeesSP()
        {
            var ctx = new trainee1Context();
            var employees = ctx.Emps.FromSqlRaw("GetAllEmpsDetails").ToList();



            foreach (var a in employees)
            {
                Console.WriteLine(a.Ename);
            }
        }
    }
}
