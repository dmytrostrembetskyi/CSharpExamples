using Basic.Topics.Void.Examples;

namespace Basic.Topics.Void
{
    public class ExampleRunner
    {
        public ExampleRunner()
        {
            new CanBeMethodReturnType();
            new CanHaveEmptyReturn();
            new CanBeUsedInLocalFunction();
            new CanBeStatic();
            new CanBeUsedWithTypeOfOperator();
            new CanBeUsedWithUnsafeCode();

            new CanNotBeAssignedToVariable();
            new CanNotBeVariableType();
            new CanNotExplicitlyUseSystemVoid();
        }
    }
}