namespace V3Runner
{
    internal class Operator_Comparison_SupportedTypes
    {
        public Operator_Comparison_SupportedTypes()
        {
            Sbyte();
            Byte();
            Short();
            Ushort();
            Int();
            Uint();
            Long();
            Ulong();
            Nint();
            Nuint();

            Float();
            Double();
            Decimal();

            CharIsUsingUnderlyingValue();
            EnumIsUsingUnderlyingValue();

            StringIsNotSupported();
            ObjectIsNotSupported();
            BooleanIsNotSupported();
            
            DynamicIsDependOnAssignedType();
            
            ReturnFalseIfAnyOperandIsNaN();
        }

        void BooleanIsNotSupported()
        {
            // var c = true < true;
            // var d = true > true;
            // var e = true <= true;
            // var f = true >= true;
        }

        void ReturnFalseIfAnyOperandIsNaN()
        {
            var nan = 0 / 0D;
            var c = 1 < nan;
            var d = 1 > nan;
            var e = 1 <= nan;
            var f = 1 >= nan;
        }

        void DynamicIsDependOnAssignedType()
        {
            dynamic a = 1;
            dynamic b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
            
            dynamic g = "1";
            dynamic h = "2";
            // var i = g < h;
            // var j = g > h;
            // var k = g <= h;
            // var l = g >= h;
        }

        void ObjectIsNotSupported()
        {
            var a = new object();
            var b = new object();
            // var c = a < b;
            // var d = a > b;
            // var e = a <= b;
            // var f = a >= b;
        }

        void StringIsNotSupported()
        {
            var a = "Hello";
            var b = "World";
            // var c = a < b;
            // var d = a > b;
            // var e = a <= b;
            // var f = a >= b;
        }

        void EnumIsUsingUnderlyingValue()
        {
            var c = CompareMe.One < CompareMe.Two;
            var d = CompareMe.One > CompareMe.Two;
            var e = CompareMe.One <= CompareMe.Two;
            var f = CompareMe.One >= CompareMe.Two;
        }

        void CharIsUsingUnderlyingValue()
        {
            var a = 'a';
            var b = 'b';
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Decimal()
        {
            decimal a = 1;
            decimal b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Double()
        {
            double a = 1;
            double b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Float()
        {
            float a = 1;
            float b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Nuint()
        {
            nuint a = 1;
            nuint b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Nint()
        {
            nint a = 1;
            nint b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Ulong()
        {
            ulong a = 1;
            ulong b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Long()
        {
            long a = 1;
            long b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Uint()
        {
            uint a = 1;
            uint b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Int()
        {
            var a = 1;
            var b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Ushort()
        {
            ushort a = 1;
            ushort b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Short()
        {
            short a = 1;
            short b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Byte()
        {
            byte a = 1;
            byte b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        void Sbyte()
        {
            sbyte a = 1;
            sbyte b = 2;
            var c = a < b;
            var d = a > b;
            var e = a <= b;
            var f = a >= b;
        }

        enum CompareMe
        {
            One,
            Two
        }
    }
}