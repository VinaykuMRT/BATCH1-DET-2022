using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
   public class person
    {
        private string message;

        public person(string Message)
        {
            this.message = message;
        }

        public  int Age { get; set; }

        public string Print( )
        {
            return $"Age={Age}";
        }
    }
}
    