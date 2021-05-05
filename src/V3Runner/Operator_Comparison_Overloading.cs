namespace V3Runner
{
    internal class Operator_Comparison_Overloading
    {
        public Operator_Comparison_Overloading()
        {
            LessAndGreaterThanShouldBeOverloadedBoth();
            LessAndGreaterThanOrEqualShouldBeAlsoOverloadedBoth();
        }

        void LessAndGreaterThanOrEqualShouldBeAlsoOverloadedBoth()
        {
            var a = new NotStrictOperand() >= new NotStrictOperand();
            var b = new NotStrictOperand() <= new NotStrictOperand();
        }

        void LessAndGreaterThanShouldBeOverloadedBoth()
        {
            var a = new StrictOperand() > new StrictOperand();
            var b = new StrictOperand() < new StrictOperand();
        }

        class StrictOperand
        {
            public static StrictOperand operator <(StrictOperand a, StrictOperand b)
            {
                return a;
            }

            public static StrictOperand operator >(StrictOperand a, StrictOperand b)
            {
                return a;
            }
        }
        
        class NotStrictOperand
        {
            public static NotStrictOperand operator <=(NotStrictOperand a, NotStrictOperand b)
            {
                return a;
            }

            public static NotStrictOperand operator >=(NotStrictOperand a, NotStrictOperand b)
            {
                return a;
            }
        }
    }
}