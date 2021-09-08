// ReSharper disable UnusedMember.Global

namespace V5.C06Conversion.Implicit.C03Enumeration
{
    public class Case1
    {
        public Case1()
        {
            TestEnum a1 = 0;
            // TestEnum a2 = 1;
            // TestEnum a2 = -1;
        }
    }

    internal enum TestEnum
    {
        First,
        Second
    }
}