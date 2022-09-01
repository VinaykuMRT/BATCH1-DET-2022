//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BATCH1_DET_2022
//{
//    internal class Linqlearning
//    {
//        public static void Main()
//        {
//            SampleIntList();
//        }
//        public static void   SampleIntList()
//        {
//            //data source
//            List<int> numbers = new List<int>();
//            numbers.Add(1);
//            numbers.Add(2);
//            numbers.Add(3);
//            numbers.Add(4);
//            //Query creation 
//            var numQuery = from num in numbers select num;

//            numbers.Add(5);
//            numbers.Add(6);
//            numbers.Add(7);
//            //Query execution 
//            foreach(int num in numQuery)
//            {
//                Console.WriteLine("{0}",num);

//            }
//            Console.ReadLine();

//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Linqlearning
    {
        public static void Main()
        {
            SampleIntList();
        }
        public static void SampleIntList()
        {
            ////data source
            //List<int> numbers = new List<int>();
            //numbers.Add(1);
            //numbers.Add(2);
            //numbers.Add(3);
            //numbers.Add(4);
            ////Query creation 
            //// Early execution
            ////var numQuery = (from num in numbers select num).ToList();
            ////var numQuery = from num in numbers where num>2 select num;


            ////Lamda execpression;
            ////var numQuery = numbers.Select(x => x);

            ////lamda > execpression
            //var numQuery = numbers.Where(x => x > 2);
            ////Query execution 
            //foreach (int num in numQuery)
            //{
            //    Console.WriteLine("{0}", num);

            //}
            //Console.ReadLine();


            List<string> names = new List<string>();
            names.Add("jhon");
            names.Add("peter");
            names.Add("jacob");
            names.Add("harry");
            names.Add("jackson");


            // var numQuery = from o in names //select num from numbers
            //              where names = o
            //         select names;

            var result = names.Where(word => word.Contains('o'));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

            //max
            List<string> names = new List<string>();
            names.Add("jhon");
            names.Add("peter");
            names.Add("jacob");
            names.Add("harry");
            names.Add("jackson");


            // var numQuery = from o in names //select num from numbers
            //              where names = o
            //         select names;

            var result = names.Where(word => word.Contains('o'));

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }

        }
    }
    }
}


