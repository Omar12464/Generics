using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics1
{
    internal class Range<T> where T :IComparable<T>
    {
        public T Min { get; private set; }
        public T Max { get; private set; }

        public Range(T min, T max)
        {
            if(min.CompareTo(max)> 0) { Console.WriteLine("invalid range"); }
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public T Legth()
        {
            dynamic min=Min;
            dynamic max=Max;
            return max-min;
        }

    }
}
