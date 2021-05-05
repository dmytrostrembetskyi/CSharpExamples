namespace V3Runner
{
    internal class Operator_BooleanLogical_Conditionality
    {
        public Operator_BooleanLogical_Conditionality()
        {
            NonConditionalAreAlwaysEvaluateBothOperands();
            ConditionalAreStopEvaluatingWhenConditionIsSatisfied();
            MakeNoSenseToBeAppliedToExclusiveOr();
            CanNotBeAppliedToUnary();
        }

        void CanNotBeAppliedToUnary()
        {
            var itIsNotConditionality = !!!Operand(true);
        }

        void MakeNoSenseToBeAppliedToExclusiveOr()
        {
            var a = Operand(true) ^ Operand(false);
            // var b = Operand(true) ^^ Operand(false);
        }

        void ConditionalAreStopEvaluatingWhenConditionIsSatisfied()
        {
            var a = Operand(false) && Operand(true);
            var b = Operand(true) || Operand(false);
        }

        void NonConditionalAreAlwaysEvaluateBothOperands()
        {
            var a = Operand(false) & Operand(true);
            var b = Operand(true) | Operand(false);
        }

        bool Operand(bool @bool)
        {
            return @bool;
        }
    }
}