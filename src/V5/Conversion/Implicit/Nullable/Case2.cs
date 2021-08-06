namespace V5.Conversion.Implicit.Nullable
{
    public class Case2
    {
        public Case2()
        {
            int? a = 1;
            long? a2 = a;

            int b = 1;
            long? b2 = b;
        }
    }
}