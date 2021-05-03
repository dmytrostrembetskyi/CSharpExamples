using System;

namespace V3Runner
{
    internal class BooleanLogicalOperator_BitwiseLogicalExclusiveOr
    {
        public BooleanLogicalOperator_BitwiseLogicalExclusiveOr()
        {
            GenerateOneWhenBothNumbersAreDifferent();
            GenerateZeroWhenBothNumbersAreTheSame();
        }

        void GenerateZeroWhenBothNumbersAreTheSame()
        {
            var a = 0b_1100_1100;
            var b = 0b_0011_1100;
            var c = a ^ b;
            var d = Convert.ToString(c, 2);
        }

        void GenerateOneWhenBothNumbersAreDifferent()
        {
            var a = 0b_0000_0000;
            var b = 0b_1111_1111;
            var c = a ^ b;
            var d = Convert.ToString(c, 2);
        }
    }
}