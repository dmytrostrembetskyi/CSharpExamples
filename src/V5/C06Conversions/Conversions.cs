using V5.C06Conversions.Implicit.C03Enumeration;
using V5.C06Conversions.Implicit.C05Nullable;
using V5.C06Conversions.Implicit.C06NullLiteral;
using V5.C06Conversions.Implicit.C07Reference;
using V5.C06Conversions.Implicit.C08Boxing;
using V5.C06Conversions.Implicit.C09Dynamic;
using V5.C06Conversions.Implicit.C10ConstantExpression;
using V5.C06Conversions.Implicit.C11TypeParameters;
using V5.Conversion.Implicit.Enumeration;

namespace V5.C06Conversions
{
    public class Conversions
    {
        public Conversions()
        {
            new Case1();
            new Case2();
            new Case3();
            new Case4();
            new Case5();

            new Implicit.C04InterpolatedString.Case1();

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
            new C10NullLiteral();
            new C11Dynamic();
            new C12Covariance();
            new C13Contravariance();
            new C14TypeParameters();

            new C01AnyValueTypeToObject();
            new C02AnyValueTypeToSystemValueType();
            new C03NonNullableValueTypeToItsInterface();
            new C04NullableValueTypeToItsInterface();
            new C05AnyEnumTypeToSystemEnum();
            new C06NullableEnumToSystemEnum();

            new C01AnyTypeToDynamic();
            new C02DynamicToObject();
            new C03CanBeChangedToAnyType();

            new C01NumericSByte();
            new C02NumericByte();
            new C03NumericShort();
            new C04NumericUShort();
            new C05NumericInt();
            new C06NumericUInt();
            new C07NumericLong();
            new C08NumericULong();
            new C09NumericNInt();
            new C10NumericNUInt();
            new C11NumericFloat();
            new C12NumericDouble();
            new C13NumericDecimal();

            new C01IdentityConversion();
            new C02EffectiveBaseClass();
            new C03AnyBaseClass();
            new C04AnyInterface();
        }
    }
}