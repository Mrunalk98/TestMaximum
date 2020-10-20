using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximum
{
    public class GenericMaximum <T> where T: IComparable
    {
        public T MaximumValue(T a, T b, T c)
        {
            if (a.CompareTo(b) > 0 && a.CompareTo(c) > 0)
                return a;
            if (b.CompareTo(a) > 0 && b.CompareTo(c) > 0)
                return b;
            if (c.CompareTo(a) > 0 && c.CompareTo(b) > 0)
                return c;
            return default;
        }
    }
}
