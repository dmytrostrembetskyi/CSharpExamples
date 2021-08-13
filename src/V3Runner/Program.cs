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

            new Operator_Bitwise_LogicalExclusiveOr();

            new Operator_Comparison_Operators();
            new Operator_Comparison_SupportedTypes();
            new Operator_Comparison_Overloading();
            new Operator_Comparison_Precedence();
            new Operator_Comparison_NaN();

            new Operator_TypeTesting_BasicExample();
            new Operator_TypeTesting_Comparison();


            new ImplicitIdentityConversion();

            new ImplicitNumericConversion();
            new ImplicitNumericConversion_LossOfPrecision();
            new ImplicitNumericConversion_FromLitaral();
            new Conversion_Implicit_Enumeration();

            new AsOperator();
            new CastOperator();

            new Operator_TypeConversion_Comparison();
        }
    }
}