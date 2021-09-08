using System;

// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.C06Conversion.Implicit.C08Boxing
{
    public class C05AnyEnumTypeToSystemEnum
    {
        public C05AnyEnumTypeToSystemEnum()
        {
            SimpleEnum a = SimpleEnum.First;
            Enum a2 = a;
        }

        enum SimpleEnum
        {
            First
        }
    }
}