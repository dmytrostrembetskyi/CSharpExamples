namespace V3Runner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            new Operator_BooleanLogical_Operators();
            new Operator_BooleanLogical_CompoundAssignment();
            new Operator_BooleanLogical_Precedence();
            new Operator_BooleanLogical_Conditionality();
            new Operator_BooleanLogical_Overloading();
            new Operator_BooleanLogical_Associativity();
            // todo Nullable Boolean logical operators

            new Operator_Bitwise_LogicalExclusiveOr();
            // todo bitwise operators

            new Operator_Comparison_Operators();
            new Operator_Comparison_SupportedTypes();
            new Operator_Comparison_Overloading();
            new Operator_Comparison_Precedence();
            
        }
    }
}