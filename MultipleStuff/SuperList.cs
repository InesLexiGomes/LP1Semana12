using System;
using System.Collections.Generic;

namespace MultipleStuff
{
    class SuperList : List<double>
    {
        /// <summary>
        /// Determines which is the minimum
        /// </summary>
        /// <returns> minimum value </returns>
        double GetMin()
        {
            double min = this[0];
            foreach (double d in this)
            {
                if (d < min) min = d;
            }
            return min;
        }
    }
}