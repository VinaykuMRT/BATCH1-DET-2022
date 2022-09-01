using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class LinqlearningElement
    {
        public static void Main()
        {
            ElementIntList();


        }
        public static void ElementIntList()
        {

            // int [] words = { 4,566,4 };

            // var result = words.ElementAt(1);

            //Console.WriteLine("Element at index 1 in the array is:");
            // Console.WriteLine(result);

            //ElementAtOrDefault
            // string[] colors = { "Red", "Green", "Blue" };

            // var resultIndex1 = colors.ElementAtOrDefault(1);

            // var resultIndex10 = colors.ElementAtOrDefault(10);

            //Console.WriteLine("Element at index 1 in the array contains:");
            //     Console.WriteLine(resultIndex1);

            //     Console.WriteLine("Element at index 10 in the array does not exist:");
            //     Console.WriteLine(resultIndex10 == null);

            // First(Simple)
            // double[] words = { 4.5, 566, 4 };

            //var result = words.First();

            //Console.WriteLine("First element in the array is:");
            //Console.WriteLine(result);

            //First(Conditional)

            //  string[] countries = { "Denmark", "Sweden", "Norway" };

            //  var result = countries.First(c => c.Length == 6);

            //Console.WriteLine("First element with a length of 6 characters:");
            //  Console.WriteLine(result);

            //FirstOrDefault

            //  string[] countries = { "Denmark", "Sweden", "Norway" };
            //  string[] empty = { };

            //  var result = countries.FirstOrDefault();

            //  var resultEmpty = empty.FirstOrDefault();

            //Console.WriteLine("First element in the countries array contains:");
            // Console.WriteLine(result);

            //  Console.WriteLine("First element in the empty array does not exist:");
            //  Console.WriteLine(resultEmpty == null);

            //Last
            //int[] words = { 4, 566, 11};

            //var result = words.Last();

            //Console.WriteLine("Last numbers in array is:");
            //Console.WriteLine(result);

            //LastOrDefault(simple)
            //string[] words = { "one", "two", "three" };
            //string[] empty = { };

            //var result = words.LastOrDefault();

            //var resultEmpty = empty.LastOrDefault();

            //Console.WriteLine("Last element in the words array contains:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array does not exist:");
            //Console.WriteLine(resultEmpty == null);

            ////LastOrDefault(conditional)
            //string[] words = { "one", "twp", "three" };

            //var result = words.LastOrDefault(w => w.Length == 3);

            //var resultNoMatch = words.LastOrDefault(w => w.Length == 2);

            //Console.WriteLine("Last element in the words array having a length of 3:");
            //Console.WriteLine(result);

            //Console.WriteLine("Last element in the empty array having a length of 2 does not exist:");
            //Console .WriteLine(resultNoMatch == null);

            //single
            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.Single();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //try
            //{
            //    // This will throw an exception because array contains no elements
            //    var resultEmpty = empty.Single();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    // This will throw an exception as well because array contains more than one element
            //    var result3 = names3.Single();
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //SingleOrDefault
            //string[] names1 = { "Peter" };
            //string[] names3 = { "Peter", "Joe", "Wilma" };
            //string[] empty = { };

            //var result1 = names1.SingleOrDefault();

            //var resultEmpty = empty.SingleOrDefault();

            //Console.WriteLine("The only name in the array is:");
            //Console.WriteLine(result1);

            //Console.WriteLine("As array is empty, SingleOrDefault yields null:");
            //Console.WriteLine(resultEmpty == null);

            //try
            //{
            //    // This will throw an exception as well because array contains more than one element
            //    var result3 = names3.SingleOrDefault();
            //}
            //catch (Exception e)
            //{
            //   Console.WriteLine(e.Message);
            //}
        }

    }
    }
    

      
    

