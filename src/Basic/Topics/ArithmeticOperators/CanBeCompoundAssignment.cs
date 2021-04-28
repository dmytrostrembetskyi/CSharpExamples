namespace Basic.Topics.ArithmeticOperators
{
    public class CanBeCompoundAssignment
    {
        public CanBeCompoundAssignment()
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
        }

        void Decimal()
        {
            var variable = 8.5m;
            variable *= variable;
            variable += variable;
            variable %= 3.2m;
            variable /= variable;
            variable -= variable;
        }

        void Double()
        {
            var variable = 8.5d;
            variable *= variable;
            variable += variable;
            variable %= 3.2d;
            variable /= variable;
            variable -= variable;
        }

        void Float()
        {
            var variable = 8.5f;
            variable *= variable;
            variable += variable;
            variable %= 3.2f;
            variable /= variable;
            variable -= variable;
        }

        void Nuint()
        {
            nuint variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Nint()
        {
            nint variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Ulong()
        {
            ulong variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Long()
        {
            long variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Uint()
        {
            uint variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Int()
        {
            var variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Ushort()
        {
            ushort variable = 8;
            variable *= variable;
            variable += variable;
            variable %= 3;
            variable /= variable;
            variable -= variable;
        }

        void Short()
        {
            short variable = 100;
            variable += variable;
            variable *= variable;
            variable %= 10;
            variable /= variable;
            variable -= variable;
        }

        void Byte()
        {
            byte variable = 100;
            variable += variable;
            variable *= variable;
            variable %= 10;
            variable /= variable;
            variable -= variable;
        }

        void Sbyte()
        {
            sbyte variable = 100;
            variable += variable;
            variable *= variable;
            variable %= 10;
            variable /= variable;
            variable -= variable;
        }
    }
}