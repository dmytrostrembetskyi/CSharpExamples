namespace Basic.Topics.ArithmeticOperators
{
    public class HaveLeftToRightAssociativity
    {
        public HaveLeftToRightAssociativity()
        {
            Additive();
            Multiplicative();
            AdditiveAndMultiplicative();
            UnaryPlusASndMinus();
            UnaryIsRightToLeft();
        }

        void UnaryIsRightToLeft()
        {
            var result1 = -MinusInt();
            var result2 = +MinusInt();
            var result3 = -Int();
            var result4 = +Int();
            var result5 = +-Int();
            var result6 = +-+-Int();
        }

        int Int()
        {
            return 8;
        }

        int MinusInt()
        {
            return -8;
        }

        void UnaryPlusASndMinus()
        {
            var result1 = -10 + +9;
            var result2 = +10 * -9;
            var result3 = -Int();
        }

        void AdditiveAndMultiplicative()
        {
            var result1 = 10 * 9 / 8 % 7 + 6 - 5;
            var result2 = 10 + 9 - 8 % 7 / 6 * 5;
            var result3 = 10 * 9 + 8 / 7 - 6 % 5;
        }

        void Multiplicative()
        {
            var result1 = 10 * 9 / 8 % 7;
            var result2 = 10 % 9 / 8 * 7;
            var result3 = 10 % 9 * 8 / 7;
            var result4 = 10 * 9 % 8 / 7;
        }

        void Additive()
        {
            var result1 = 10 + 9 - 8;
            var result2 = 10 - 9 + 8;
        }
    }
}