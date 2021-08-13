using System.Text;

// ReSharper disable SuggestVarOrType_SimpleTypes

namespace V5.Conversion.Implicit.C7Reference
{
    public class C2AnyReferenceToDynamic
    {
        public C2AnyReferenceToDynamic()
        {
            Decoder a = Encoding.UTF8.GetDecoder();
            object a2 = a;
        }
    }
}