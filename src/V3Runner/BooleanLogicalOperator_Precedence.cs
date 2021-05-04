namespace V3Runner
{
    internal class BooleanLogicalOperator_Precedence
    {
        public BooleanLogicalOperator_Precedence()
        {
            EvaluatesFromLeftToRight();
            CanBeControlledByParentheses();
        }

        void CanBeControlledByParentheses()
        {
            var a = Operand() && Operand() || Operand();
            var b = Operand() && (Operand() || Operand());
        }

        void EvaluatesFromLeftToRight()
        {
            var a = Operand() | (Operand() & Operand());
            var b = Operand() && !Operand() || Operand();
        }

        bool Operand()
        {
            return true;
        }
    }
}