namespace Basic.Topics.Void.Examples
{
    public class CanBeUsedWithUnsafeCode
    {
        public unsafe CanBeUsedWithUnsafeCode()
        {
            var variable = Method();
        }

        unsafe void* Method()
        {
            return null;
        }
    }
}