// ReSharper disable CoVariantArrayConversion
// ReSharper disable SuggestVarOrType_BuiltInTypes

namespace V5.Conversion.Implicit.C7Reference
{
    public class C06ArrayToArray
    {
        public C06ArrayToArray()
        {
            string[] a = { "q", "w" };
            object[] a2 = a;

            int[] b = { 1, 2 };
            // object[] b2 = b;

            string[,] c = new string[1, 2];
            object[,] c2 = c;

            string[,] d = new string[1, 2];
            // object[] d2 = c;

            string[] e = { "q", "w" };
            // StringBuilder[] e2 = e;
        }
    }
}