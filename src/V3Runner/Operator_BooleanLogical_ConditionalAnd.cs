namespace V3Runner
{
    internal class Operator_BooleanLogical_ConditionalAnd
    {
        public Operator_BooleanLogical_ConditionalAnd()
        {
            ReturnTrueWhenAllOperandsAreTrue();
            StopEvaluateOperatorsWhenFindFalse();
        }

        void StopEvaluateOperatorsWhenFindFalse()
        {
            bool Operator()
            {
                return true;
            }

            var a = true && Operator();
            var b = false && Operator();
            var c = true && !Operator() && Operator();
        }

        void ReturnTrueWhenAllOperandsAreTrue()
        {
            var a = true && true;
            var b = false && false;
            var c = true && false;
            var d = false && true;
            var e = true && true && false;
            var f = false && false && true;
            var g = true && true && true;
            var h = false && false && false;
        }
    }
}