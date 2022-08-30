using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class CSFeatures
    {
        //    private static object name;

        //    public static void Main()
        //    {


        //        Action<string> action = (string name) => { Console.WriteLine($"svg{name}"); };
        //        Action<string, string> action1 = (string s1, string s2) => { Console.WriteLine($"hai {s1}," + $"you said {s2}"); };
        //        Action<string, string> action2 = (string v1, string v2) => { Console.WriteLine($"king {v1}," + $"im going {v2}"); };
        //        Action<int, string, string> action3 = (int b1, string b2, string b3) => { Console.WriteLine($"4 {b1}," + $"im vinay{b2}," + $"you know me{b3}"); };


        //        action.Invoke("vinay");
        //        action1.Invoke("vinay", "im in banglore");
        //        action2.Invoke("vinay", "imgoing to raichur");
        //        action3.Invoke(4, "vinay", "imgoing to raichur");


        //        Func<int, int, long> multiply = (x, y) =>
        //        {
        //            return x * y;
        //        };
        //        long result = multiply(100, 100);
        //        Console.WriteLine(result);
        //    }

        //    }
        //}
        static void Main()
        {
            foreach (int number in EvenSequence(5, 18))
            {
                Console.Write(number.ToString() + " ");
            }
            // Output: 6 8 10 12 14 16 18
            Console.ReadKey();
        }

        public static System.Collections.Generic.IEnumerable<int>
            EvenSequence(int firstNumber, int lastNumber)
        {
            // Yield even numbers in the range.
            for (int number = firstNumber; number <= lastNumber; number++)
            {
                if (number % 2 == 0)
                {
                    yield return number;
                }
            }
        }
    }

}

        
    
