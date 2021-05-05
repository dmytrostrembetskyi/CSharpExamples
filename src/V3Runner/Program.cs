namespace V3Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Operator_BooleanLogical_Negation();
            new Operator_BooleanLogical_And();
            new Operator_BooleanLogical_Or();
            new Operator_BooleanLogical_ExclusiveOr();
            new Operator_BooleanLogical_ConditionalOr();
            new Operator_BooleanLogical_ConditionalAnd();
            
            new Operator_BooleanLogical_CompoundAssignment();
            new Operator_BooleanLogical_Precedence();
            new Operator_BooleanLogical_Conditionality();

            new Operator_Bitwise_LogicalExclusiveOr();

            // todo review 
            new Operator_BooleanLogical_Precedence_TODO();
            new BooleanLogicalOperator_Precedence();
        }
    }
}