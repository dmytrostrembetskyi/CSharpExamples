namespace Basic.Topics.ArithmeticOperators
{
    internal class CanBeUnary
    {
        public CanBeUnary()
        {
            UnaryMeansOperateOnOneOperator();
        }

        void UnaryMeansOperateOnOneOperator()
        {
            var plus = +1;
            var minus = -1;

            var increment = 0;
            increment++;

            var decrement = 0;
            decrement--;
        }
    }
}