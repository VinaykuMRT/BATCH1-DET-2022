//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Tracing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BATCH1_DET_2022
//{
//    internal class LinqLearningGroupBy
//    {
//        private static object item;

//        public static void Main()
//        {
//            BroupbyInt();


//        }
//        public static void BroupbyInt()
//        {

//            List<string> words = new List<string> { "Basket", "Bluebarry", "chimpanze", "abacus", "banana", "apple", "cheese" };

//            var wordGroups = words.GroupBy(x => x[0]).Select(y => new { Firstletter = y.Key, words = y });
//            foreach (var item in wordGroups)
//                Console.WriteLine("words that start with the " + "Letter '{0}:", item.Firstletter);
//            foreach (var w in item.words)
//            {
//                Console.WriteLine(w);
//            }

//        }
//    }
//}
    
