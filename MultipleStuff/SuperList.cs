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
        /// <summary>
        /// Determines which is the maximum
        /// </summary>
        /// <returns> maximum value </returns>
        double GetMax()
        {
            double max = this[0];
            foreach (double d in this)
            {
                if (d > max) max = d;
            }
            return max;
        }
        
        /// <summary>
        /// Uses out to return both values
        /// </summary>
        /// <param name="min"> returns the minimum amount </param>
        /// <param name="max"> returns the maximum amount </param>
        public void GetMinMax1(out double min, out double max)
        {
            min = GetMin();
            max = GetMax();
        }

    }
}