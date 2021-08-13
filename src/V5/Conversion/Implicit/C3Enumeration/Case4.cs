// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable UnusedMember.Global

namespace V5.Conversion.Implicit.C3Enumeration
{
    public class Case4
    {
        public Case4()
        {
            Enum a1 = Enum.First;
            Enum a2 = 0;
            Enum a3 = 0 | Enum.First;
            Enum a4 = 1 - 1;
            // Enum a5 = 2 - 1 + 0 + 1;
            Enum a6 = 2 - 1 - 1 + 0;
            // Enum a7 = 2 - 1 - 1 + 0 + 1;
            Enum a8 = 0L & 1;
            Enum a9 = 1 & 0L;
            // Enum a10 = 10 / 10;
            Enum a11 = 0 | 0 | Enum.First;
        }
    }

    internal enum Enum
    {
        First,
        Second
    }
}