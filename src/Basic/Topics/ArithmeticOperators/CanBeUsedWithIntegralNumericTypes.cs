namespace Basic.Topics.ArithmeticOperators
{
    public class CanBeUsedWithIntegralNumericTypes
    {
        public CanBeUsedWithIntegralNumericTypes()
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
        }

        void Nuint()
        {
            nuint variable = 8;
            variable++;
            variable--;
            // var doesNotSupportUnaryMinus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Nint()
        {
            nint variable = 8;
            variable++;
            variable--;
            var minus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Ulong()
        {
            ulong variable = 8;
            variable++;
            variable--;
            // var doesNotSupportUnaryMinus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Long()
        {
            long variable = 8;
            variable++;
            variable--;
            var minus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Uint()
        {
            uint variable = 8;
            variable++;
            variable--;
            var minus = (uint)-variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Int()
        {
            var variable = 8;
            variable++;
            variable--;
            var minus = -variable;
            var plus = +variable;
            var addition = variable + variable;
            var subtraction = variable - variable;
            var multiplication = variable * variable;
            var division = variable / variable;
            var remainder = variable % variable;
        }

        void Ushort()
        {
            ushort variable = 8;
            variable++;
            variable--;
            var minus = (ushort)-variable;
            var plus = (ushort)+variable;
            var addition = (ushort)(variable + variable);
            var subtraction = (ushort)(variable - variable);
            var multiplication = (ushort)(variable * variable);
            var division = (ushort)(variable / variable);
            var remainder = (ushort)(variable % variable);
        }

        void Short()
        {
            short variable = 8;
            variable++;
            variable--;
            var minus = (short)-variable;
            var plus = (short)+variable;
            var addition = (short)(variable + variable);
            var subtraction = (short)(variable - variable);
            var multiplication = (short)(variable * variable);
            var division = (short)(variable / variable);
            var remainder = (short)(variable % variable);
        }

        void Byte()
        {
            byte variable = 8;
            variable++;
            variable--;
            var minus = (byte)-variable;
            var plus = (byte)+variable;
            var addition = (byte)(variable + variable);
            var subtraction = (byte)(variable - variable);
            var multiplication = (byte)(variable * variable);
            var division = (byte)(variable / variable);
            var remainder = (byte)(variable % variable);
        }

        void Sbyte()
        {
            sbyte variable = 8;
            variable++;
            variable--;
            var minus = (sbyte)-variable;
            var plus = (sbyte)+variable;
            var addition = (sbyte)(variable + variable);
            var subtraction = (sbyte)(variable - variable);
            var multiplication = (sbyte)(variable * variable);
            var division = (sbyte)(variable / variable);
            var remainder = (sbyte)(variable % variable);
        }
    }
}