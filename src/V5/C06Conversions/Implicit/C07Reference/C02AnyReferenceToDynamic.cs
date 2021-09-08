using System.Text;

// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.C06Conversions.Implicit.C07Reference
{
    public class C02AnyReferenceToDynamic
    {
        public C02AnyReferenceToDynamic()
        {
            Decoder a = Encoding.UTF8.GetDecoder();
            object a2 = a;
        }
    }
}