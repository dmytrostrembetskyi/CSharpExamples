namespace V3Runner
{
    internal class Operator_Comparison_Precedence
    {
        public Operator_Comparison_Precedence()
        {
            AllHaveTheSame();
        }

        void AllHaveTheSame()
        {
            var inSomeOrder = new Operand(1) < new Operand(2) > new Operand(3) <= new Operand(4) >= new Operand(5);
            var inReverseOrder = new Operand(1) >= new Operand(2) <= new Operand(3) > new Operand(4) < new Operand(5);
        }

        class Operand
        {
            readonly int _value;

            public Operand(int value)
            {
                _value = value;
            }

            public static Operand operator <(Operand a, Operand b)
            {
                if (a._value < b._value)
                    return a;
                return b;
            }

            public static Operand operator >(Operand a, Operand b)
            {
                if (a._value > b._value)
                    return a;
                return b;
            }

            public static Operand operator <=(Operand a, Operand b)
            {
                if (a._value <= b._value)
                    return a;
                return b;
            }

            public static Operand operator >=(Operand a, Operand b)
            {
                if (a._value >= b._value)
                    return a;
                return b;
            }
        }
    }
}