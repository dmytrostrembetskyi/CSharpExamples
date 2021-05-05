namespace V3Runner
{
    internal class Operator_Comparison_Operators
    {
        public Operator_Comparison_Operators()
        {
            LessThan();
            GreaterThan();
            LessThanOrEqual();
            GreaterThanOrEqual();
        }

        void GreaterThanOrEqual()
        {
            var a = 1 >= 2;
            var b = 1.5 >= 0.5;
            var c = 1 >= 1;
        }

        void LessThanOrEqual()
        {
            var a = 1 <= 2;
            var b = 1.5 <= 0.5;
            var c = 1 <= 1;
        }

        void GreaterThan()
        {
            var a = 1 > 2;
            var b = 1.5 > 0.5;
            var c = 1 > 1;
        }

        void LessThan()
        {
            var a = 1 < 2;
            var b = 1.5 < 0.5;
            var c = 1 < 1;
        }
    }
}