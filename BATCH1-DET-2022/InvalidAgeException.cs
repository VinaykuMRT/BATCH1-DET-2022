using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    public class IInvalidAgeException : person
    {
        public IInvalidAgeException(string Message) : base(Message)
        { }

        public bool Message { get; internal set; }
    }
}


