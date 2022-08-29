using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal abstract class Animals
    {
        public int age { get; set; }
        public string name { get; set; }

        public string gender { get; set; }

        public abstract string ToString();
    }
}
