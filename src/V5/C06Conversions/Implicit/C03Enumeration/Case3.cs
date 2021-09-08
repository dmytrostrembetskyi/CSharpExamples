// ReSharper disable SuggestVarOrType_SimpleTypes
// ReSharper disable All

namespace V5.Conversion.Implicit.Enumeration
{
    public class Case3
    {
        public Case3()
        {
            FirstBasedEnum a1 = 0;
            // FirstBasedEnum a2 = 1;
            FirstBasedEnum a3 = FirstBasedEnum.First;
        }
    }

    enum FirstBasedEnum
    {
        First = 1,
        Second
    }
}