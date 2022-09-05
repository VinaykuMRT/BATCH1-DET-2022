using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BATCH1_DET_2022
{
    internal class Circle
    {
        float radius;

        public Circle(float radius)
        {
            this.radius = radius;
        }
        public double area()
        {
            return Math.PI*radius*radius;
        }

    }
}

