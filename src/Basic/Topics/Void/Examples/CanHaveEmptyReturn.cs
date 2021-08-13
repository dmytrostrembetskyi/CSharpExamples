// ReSharper disable RedundantJumpStatement
// ReSharper disable HeuristicUnreachableCode

#pragma warning disable 162

namespace Basic.Topics.Void.Examples
{
    public class CanHaveEmptyReturn
    {
        public CanHaveEmptyReturn()
        {
            Method();
        }

        void Method()
        {
            int variable1;
            return;
            int variable2;
        }
    }
}