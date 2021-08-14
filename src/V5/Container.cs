using V5.Conversion.Implicit.C3Enumeration;
using V5.Conversion.Implicit.C5Nullable;
using V5.Conversion.Implicit.C6NullLiteral;
using V5.Conversion.Implicit.C7Reference;
using V5.Conversion.Implicit.Enumeration;

// ReSharper disable ObjectCreationAsStatement

namespace V5
{
    public class Container
    {
        public Container()
        {
            new Case1();
            new Case2();
            new Case3();
            new Case4();
            new Case5();

            new Conversion.Implicit.C4InterpolatedString.Case1();

            new C1SameType();
            new C2DifferentTypeWithValue();
            new C3DifferentTypeWithNull();

            new ToAnyNullableType();

            new C01AnyReferenceToObject();
            new C02AnyReferenceToDynamic();
            new C03Derived();
            new C04FromInterface();
            new C05FromInterfaceToInterface();
            new C06ArrayToArray();
            new C07ArrayToSystemArray();
            new C08ArrayToIList();
            new C09Delegate();
            new C10NullLiteralToAnyReferenceType();
            
            
        }
    }
}