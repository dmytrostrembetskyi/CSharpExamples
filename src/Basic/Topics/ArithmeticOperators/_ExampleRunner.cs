namespace Basic.Topics.ArithmeticOperators
{
    public class _ExampleRunner
    {
        public _ExampleRunner()
        {
            new CanBeUnary();
            new CanBeBinary();
            new CanBeUsedWithIntegralNumericTypes();
            new CanBeUsedWithFloatingPointNumericTypes();
            new CanBeUsedWithChars();
            new CanBeUsedForStringConcatenationOnly();
            new CanNotBeUsedWithBool();
            new CanBeUsedWithDynamic();
            new CanBePostfixAndPrefix();
            new CanNotBeUsedWithObject();
            new CanBeCompoundAssignment();
            new HaveLeftToRightAssociativity();
        }
    }
}