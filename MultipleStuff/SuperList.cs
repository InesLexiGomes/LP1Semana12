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

        /// <summary>
        /// Uses Structs
        /// </summary>
        /// <returns> Struct with min and max values </returns>
        public MinMaxStruct GetMinMax2()
        {
            return new MinMaxStruct(GetMin(), GetMax());
        }

        /// <summary>
        /// Uses tuple
        /// </summary>
        /// <returns> Min and max values respectively </returns>
        public (double, double) GetMinMax3()
        {
            return(GetMin(), GetMax());
        }

        /// <summary>
        /// uses named tuple
        /// </summary>
        /// <returns> named min and max values </returns>
        public (double min, double max) GetMinMax4()
        {
            return(GetMin(), GetMax());
        }

        public struct MinMaxStruct
        {
            double Min {get;}
            double Max {get;}

            public MinMaxStruct(double min, double max)
            {
                Min = min;
                Max = max;
            }
        }
    }
}