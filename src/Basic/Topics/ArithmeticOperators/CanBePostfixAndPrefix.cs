namespace Basic.Topics.ArithmeticOperators
{
    public class CanBePostfixAndPrefix
    {
        public CanBePostfixAndPrefix()
        {
            Here();
            ButTheyCanNotBeUsedSimultaneously();
            AndCanNotBeUsedMultipleTimes();
        }

        void AndCanNotBeUsedMultipleTimes()
        {
            var variable = 8;
            // variable++++;
            // variable----;
            // (variable++)++;
            // (++variable)++;
            // var result1 = (variable++)++;
            // var result2 = ++(variable++);
        }

        void ButTheyCanNotBeUsedSimultaneously()
        {
            var variable = 8;
            // ++variable++;
            // --variable--;
            // ++variable--;
            // --variable++;
        }

        void Here()
        {
            var variable = 8;
            var incrementPostfix = variable++;
            var incrementPrefix = ++variable;
            var decrementPostfix = variable--;
            var decrementPrefix = --variable;
        }
    }
}