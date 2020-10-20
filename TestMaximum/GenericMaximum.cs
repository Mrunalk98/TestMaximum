using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class GenericMaximum <T> where T: IComparable
    {
        private T[] array;
        public GenericMaximum(T[] array)
        {
            this.array = array;
        }

        public T[] SortValues(T[] array)
        {
            Array.Sort(array);
            Array.Reverse(array);
            return array;
        }
        public T GetMaximumValue()
        {
            var sortedValues = SortValues(this.array);
            return sortedValues[0];
        }

    }
}
