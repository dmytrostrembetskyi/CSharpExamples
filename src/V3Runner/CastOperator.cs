using System.Collections.Generic;

// ReSharper disable RedundantExplicitArrayCreation
// ReSharper disable SuggestVarOrType_Elsewhere

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
            IEnumerable<int> a = new int[] { 1, 2 };
            IList<int> b = (IList<int>)a;
        }

        void NumericConversion()
        {
            var a = 1d;
            var b = (int)a;
        }
    }
}