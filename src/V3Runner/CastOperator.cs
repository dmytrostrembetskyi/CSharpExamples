using System;
using System.Collections.Generic;

namespace V3Runner
{
    internal class CastOperator
    {
        public CastOperator()
        {
            NumericConversion();
            NewMethod();
        }

        void NewMethod()
        {
            IEnumerable<int> a = new int[] {1, 2};
            IList<int> b = (IList<int>) a;
        }

        void NumericConversion()
        {
            var a = 1d;
            var b = (int) a;
        }
    }
}