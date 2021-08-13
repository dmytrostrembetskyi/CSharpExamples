using V5.Conversion.Implicit.C3Enumeration;
using V5.Conversion.Implicit.C5Nullable;
using V5.Conversion.Implicit.C6NullLiteral;
using V5.Conversion.Implicit.C7Reference;
using V5.Conversion.Implicit.Enumeration;

namespace V5
{
    public class Conteiner
    {
        public Conteiner()
        {
            new Case1();
            new Case2();
            new Case3();
            new Case4();
            new Case5();

            new Conversion.Implicit.C4InterpolatedString.Case1();

            new C1_SameType();
            new C2_DifferentType_WithValue();
            new C3_DifferentType_WithNull();

            new ToAnyNullableType();

            new C1AnyReferenceToObject();
            new C2AnyReferenceToDynamic();
        }
    }
}