// ReSharper disable ArrangeTypeMemberModifiers
// ReSharper disable UnusedParameter.Local

namespace Basic.Topics.ClassConstructor.Examples
{
    public class AccessModifiers
    {
        private AccessModifiers()
        {
        }

        protected AccessModifiers(int parameter1)
        {
        }

        internal AccessModifiers(int parameter1, int parameter2)
        {
        }

        protected internal AccessModifiers(int parameter1, int parameter2, int parameter3)
        {
        }

        private protected AccessModifiers(int parameter1, int parameter2, int parameter3, int parameter4)
        {
        }

        public AccessModifiers(int parameter1, int parameter2, int parameter3, int parameter4, int parameter5)
        {
        }
    }
}