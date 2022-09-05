using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Animalsmain
    {
        public static void Main()
        {
            List<Animals>animal = new List<Animals>();
            animal.Add(new Dog());
            animal.Add(new Cat());

            foreach(Animals a in animal)
                Console.WriteLine(a.ToString());
        }
    }
}
