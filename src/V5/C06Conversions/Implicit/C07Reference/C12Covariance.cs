// ReSharper disable SuggestVarOrType_Elsewhere
// ReSharper disable UnusedTypeParameter

namespace V5.C06Conversions.Implicit.C07Reference
{
    public class C12Covariance
    {
        public C12Covariance()
        {
            Class<string> a = new Class<string>();
            IInterface<string> a2 = a;

            Class<string> b = new Class<string>();
            IInterface<object> b2 = b;

            Class<object> c = new Class<object>();
            // IInterface<string> c2 = c;
        }

        interface IInterface<out T>
        {
        }

        class Class<T> : IInterface<T>
        {
        }
    }
}