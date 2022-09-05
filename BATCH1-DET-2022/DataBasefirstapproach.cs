using BATCH1_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    public static class DataBasefirstapproach
    {
        public static void Main()
        {

            // GetAllEMPDetails();
            // GetAllEMPDetailsByID();
            //AddNewEmployee();
            //DeleteNewEmployee();
            //UpdateNewEmployee();
            GetEmployeesSP();
            Console.ReadLine();
        }
        // public static void GetAllEMPDetails()
        //public static void GetAllEMPDetailsByID()

        //public static void DeleteNewEmployee()
        //    public static void UpdateNewEmployee()
        //{
        //    var ctx = new trainee1Context();

        //    try
        //    {
        //        Emp employee = new Emp();
        //        employee.Empno = 7499;
        //        employee.Ename = "vi";
        //        employee.Sal = 1000;
        //       employee.Deptno = 30;
        //        employee.Job = "Trainer";
        //        ctx.Update(employee);
        //        ctx.SaveChanges();
        //        Console.WriteLine("new Employee deleted");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //public static void UpdateNewEmployee()
        //{
        //    var ctx = new trainee1Context();
        //    var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //    emp.Ename = "vi";
        //    ctx.Update(emp);
        //    ctx.SaveChanges();

        //var ctx = new trainee1Context();
        //var emp = ctx.Emps.Where(e => e.Empno == 7499).SingleOrDefault();
        //Console.WriteLine(emp.Ename + " " + emp .Job);


        //var ctx = new trainee1Context();
        //var emps = ctx.Emps;

        //foreach(var emp in emps)
        //{
        //    Console.WriteLine(emp.Ename + " " + emp.Sal);
        //}
        private static void GetEmployeesSP()
        {
            var ctx = new trainee1Context();
            var employees = ctx.Emps.FromSqlRaw($"GetAllEmpsdetails").ToList();


            foreach (var v in employees)
            {
                Console.WriteLine(v.Ename);
            }
        }
    }
    }









    

