namespace V3Runner
{
    internal class BooleanLogicalOperator_Conditional_Logical_Or
    {
        public BooleanLogicalOperator_Conditional_Logical_Or()
        {
            Example1();
            Example2();
            Example3();
        }

        void Example3()
        {
            bool Breakpoint()
            {
                return true;
            }

            var a = true || Breakpoint();
            var b = false || Breakpoint();
            var c = false || !Breakpoint() || Breakpoint();
        }

        void Example2()
        {
            var a = true || true || true;
            var b = true || false || true;
            var c = false || true || true;
        }

        void Example1()
        {
            var a = true || true;
            var b = true || false;
            var c = false || true;
            var d = false || false;
        }
    }
}