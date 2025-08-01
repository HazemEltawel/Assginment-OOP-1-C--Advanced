using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assginment_OOP_1_C__Advanced
{
    public class Range<T> where T : IComparable<T>
    {
        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException("Min cannot be greater than Max.");
            }
            Min = min;
            Max = max;
        }
        public bool Contains(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public dynamic length()
        {
            return (dynamic)Max - (dynamic)Min;
        }

    }
}
