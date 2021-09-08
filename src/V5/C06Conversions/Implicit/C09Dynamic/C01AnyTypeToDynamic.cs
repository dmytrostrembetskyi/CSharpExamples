// ReSharper disable SuggestVarOrType_BuiltInTypes
// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.C06Conversions.Implicit.C09Dynamic
{
    public class C01AnyTypeToDynamic
    {
        public C01AnyTypeToDynamic()
        {
            int a1 = 1;
            dynamic a2 = a1;

            object b1 = new object();
            dynamic b2 = b1;

            Enum c1 = Enum.First;
            dynamic c2 = c1;

            dynamic d1 = "";
            dynamic d2 = d1;

            string e1 = "";
            dynamic e2 = e1;
        }

        enum Enum
        {
            First
        }
    }
}