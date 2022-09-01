using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    public class linqLearningAggregation
    {
        public static void Main()
        {
            AggregationIntList();


        }
        //Average
        public static void AggregationIntList()
        {
            //int[] num = { 15, 15, 15, 17 };
            //var result = num.Average();
            //Console.WriteLine("AVERAGE  OF NUM:");
            //Console.WriteLine(result);

            //}
            ////Count
            //int[] num = { 15, 15, 15, 17,44,5 };
            //var result = num.Count();
            //Console.WriteLine("Counting the num:");
            //Console.WriteLine(result);


            //Longcount
            // Create array which is 5 elements larger than Int32.MaxValue
            // var largeArr = Enumerable.Range(0, Int32.MaxValue).Concat(Enumerable.Range(0, 5));

            // Int64 result = largeArr.LongCount();

            //Console.WriteLine("Counting largeArr elements:");
            // Console.WriteLine(result);

            //Max
            //int[] num = { 2, 5, 6, 4, 87, 8 };
            //var result = num.Max();
            //Console.WriteLine("hIGHEST NUMBER IS ");
            //Console.WriteLine(result);


            //Min
            //int[] num = { 5, 1, 3, 4, 25, 8, 69, 4, 6, 4, 565 };
            //var result = num.Min();
            //Console.WriteLine("Min number is :");
            //Console.WriteLine(result);

            //sum
            string [] names = { "vinay","kumarg","re" };
            var result = names.Max();
            Console.WriteLine("M length is :");
            Console.WriteLine(result);
        }
    }
}


