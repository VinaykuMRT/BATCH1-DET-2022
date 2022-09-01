using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class LinqLearning2
    {
        public static void Main()
        {
            CommonIntList();
        }
        public static void CommonIntList()
        {
            ////data source 
            //List<double> idnumber = new List<double>();
            //idnumber.Add(1110);
            //idnumber.Add(1111);
            //idnumber.Add(1112);
            //idnumber.Add(1113);

            ////Query creation
            ////var idQuery = from id in idnumber select id;

            //var idQuery = from id in idnumber where id >1111 select id;

            ////query execution

            //foreach (double id in idnumber)
            //{
            //    Console.WriteLine("{0}",id);
            //}

            //Console.ReadLine();





            //// Order by example 
            //int[] numbers = {5,6,7,8,9,10};
            //var result = numbers.OrderBy(n => n);

            //Console.WriteLine("order list of numbers:");
            // foreach(int number in result )
            //    Console.WriteLine(number);

            // Order bydescending 
            //string [] names = {"vinay","kumar","reddy","g"};

            //var result = names.OrderByDescending(n => n);


            //    Console.WriteLine("Descending list of numbers:");

            //foreach (string number in result)
            //  Console.WriteLine(number);


            //Revsrse
            string [] characters = { "vinay", "kumar", "g" };

            var result = characters.Reverse();

            Console.WriteLine("Characters in reverse order:");
            foreach (string character in result)
                Console.WriteLine(character);


            //ThenBy
            //string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Console.WriteLine(capital);

            //TnbyDescending
    //        var dates = new DateTime[] {
    //    new DateTime(2015, 3, 1),
    //    new DateTime(2014, 7, 1),
    //    new DateTime(2013, 5, 1),
    //    new DateTime(2015, 1, 1),
    //    new DateTime(2015, 7, 1)
    //};

    //        var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

    //        Console .WriteLine("List of dates first ordered by year descending, and then by month descending:");
    //        foreach (DateTime dt in result)
    //            Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }
    }
}
        

    
