namespace V3Runner
{
    internal class Operator_BooleanLogical_Negation
    {
        public Operator_BooleanLogical_Negation()
        {
            ReverseBoolValue();
            CanReverseManyTimes();
        }

        void CanReverseManyTimes()
        {
            var c = !!true;
            var d = !!!!!!!false;
        }

        void ReverseBoolValue()
        {
            var a = !true;
            var b = !false;
            var c = false;
            var d = !c;
        }
    }
}