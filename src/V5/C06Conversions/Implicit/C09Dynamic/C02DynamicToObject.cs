namespace V5.C06Conversions.Implicit.C09Dynamic
{
    public class C02DynamicToObject
    {
        public C02DynamicToObject()
        {
            dynamic a1 = 1;
            // int a2 = a1;

            dynamic b1 = new object();
            object b2 = b1;

            dynamic c1 = Enum.First;
            // Enum c2 = c1;

            dynamic d1 = "";
            // string d2 = d1;
            object d3 = d1;

            dynamic e1 = new Class();
            // Class e2 = e1;
        }

        enum Enum
        {
            First
        }

        class Class
        {
        }
    }
}