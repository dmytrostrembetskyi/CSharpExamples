namespace V3Runner
{
    internal class Operator_BooleanLogical_Associativity
    {
        public Operator_BooleanLogical_Associativity()
        {
            NegationIsRightAssociative();
            OthersIsLeftAssociative();
        }

        void OthersIsLeftAssociative()
        {
            var evaluatingFromLeftToRight = new Operand() & new Operand();
            var b = new Operand() ^ new Operand();
            var c = new Operand() | new Operand();
            var d = new Operand() && new Operand();
            var e = new Operand() || new Operand();
        }

        void NegationIsRightAssociative()
        {
            var evaluatingFromRightToLeft = !new Operand();
        }


        class Operand
        {
            public Operand()
            {
            }

            public static Operand operator !(Operand a)
            {
                return a;
            }

            public static Operand operator ^(Operand a, Operand b)
            {
                return a;
            }

            public static Operand operator |(Operand a, Operand b)
            {
                return a;
            }

            public static Operand operator &(Operand a, Operand b)
            {
                return a;
            }

            public static bool operator true(Operand a)
            {
                return true;
            }

            public static bool operator false(Operand a)
            {
                return true;
            }
        }
    }
}