using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperList sL = new SuperList() {1,2,4,231,23,2312};
            double min;
            double max;
            sL.GetMinMax1(out min,out max);
            Console.WriteLine($"Min: {min} Max:{max}");

            min = sL.GetMinMax2().Min;
            max = sL.GetMinMax2().Max;
            Console.WriteLine($"Min: {min} Max:{max}");

            (double,double) minMaxTuple = sL.GetMinMax3();
            min = minMaxTuple.Item1;
            max = minMaxTuple.Item2;
            Console.WriteLine($"Min: {min} Max:{max}");

            (double min, double max) minMaxTuple2 = sL.GetMinMax4();
            min = minMaxTuple2.min;
            max = minMaxTuple2.max;
            Console.WriteLine($"Min: {min} Max:{max}");
            
        }
    }
}
