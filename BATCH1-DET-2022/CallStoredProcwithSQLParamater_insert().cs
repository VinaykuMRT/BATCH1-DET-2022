using BATCH1_DET_2022.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class CallStoredProcwithSQLParamater_insert__
    {
        public static void Main()
        {
            CallStoredProcwithSQLParamater_insert();
            Console.ReadLine();
        }
       public static void CallStoredProcwithSQLParamater_insert()
        {
            var ctx = new trainee1Context();
            var Employee = new SqlParameter[] {
new SqlParameter()
{
ParameterName = "@EMPNO",
SqlDbType = System.Data.SqlDbType.Int,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = 4485
},

new SqlParameter() {
ParameterName = "@ENAME",
SqlDbType = System.Data.SqlDbType.VarChar,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = "RDBMS "},

new SqlParameter() {
ParameterName = "@JOB",
SqlDbType = System.Data.SqlDbType.VarChar,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = "trainee"},


new SqlParameter() {
ParameterName = "@SAL",
SqlDbType = System.Data.SqlDbType.Decimal,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = 10000},

new SqlParameter() {
ParameterName = "@DEPTNO",
SqlDbType = System.Data.SqlDbType.Int,
Size = 100,
Direction = System.Data.
ParameterDirection.Input,
Value = 10}
};


            try
            {
                var result = ctx.Database.ExecuteSqlRaw("newemppployy2 @EMPNO, @ENAME,@JOB,@SAL,@DEPTNO", Employee);
                Console.WriteLine("added");
            }
            catch (Exception ex)
            {


                throw;
            }

            Console.WriteLine("update successful");


        }
    }
}
