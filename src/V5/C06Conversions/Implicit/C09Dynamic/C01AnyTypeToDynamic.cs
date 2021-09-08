namespace V5.C06Conversions.Implicit.C09Dynamic
{
    public class C01AnyTypeToDynamic
    {
        public C01AnyTypeToDynamic()
        {
            var a1 = 1;
            dynamic a2 = a1;
            // int a3 = a2;

            var b1 = new object();
            dynamic b2 = b1;
            object b3 = b2;

            var c1 = Enum.First;
            dynamic c2 = c1;
            // Enum c3 = c2;

            dynamic d1 = "";
            var d2 = d1;
            var d3 = d2;

            var e1 = "";
            dynamic e2 = e1;
            // string e3 = e2;
            object e4 = e2;
        }

        enum Enum
        {
            First
        }
    }
}