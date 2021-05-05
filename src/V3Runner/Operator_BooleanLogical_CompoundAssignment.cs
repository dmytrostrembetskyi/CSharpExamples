namespace V3Runner
{
    internal class Operator_BooleanLogical_CompoundAssignment
    {
        public Operator_BooleanLogical_CompoundAssignment()
        {
            AssignReturnToLeftOperand();
            IsNotSupportedByConditionalOperators();
            IsNotSupportedByUnary();
        }

        void IsNotSupportedByUnary()
        {
            var itIsNotCompoundAssignment = true;
            // itIsNotCompoundAssignment != true;
        }

        void IsNotSupportedByConditionalOperators()
        {
            var a = true;
            // a &&= false;

            var b = false;
            // b ||= true;
        }

        void AssignReturnToLeftOperand()
        {
            var a = true;
            a &= false;

            var b = false;
            b |= true;

            var c = true;
            c ^= true;
        }
    }
}