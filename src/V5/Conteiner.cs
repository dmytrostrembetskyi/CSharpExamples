using V5.Conversion.Implicit.Enumeration;
using V5.Conversion.Implicit.Nullable;
using V5.Conversion.Implicit.NullLiteral;

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

            new Conversion.Implicit.InterpolatedString.Case1();

            new C1_SameType();
            new C2_DifferentType_WithValue();
            new C3_DifferentType_WithNull();

            new ToAnyNullableType();

            new Conversion.Implicit.Reference.AnyReferenceToObject();
            new Conversion.Implicit.Reference.Case();
        }
    }
}