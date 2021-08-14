using System.Text;

// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.Conversion.Implicit.C7Reference
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