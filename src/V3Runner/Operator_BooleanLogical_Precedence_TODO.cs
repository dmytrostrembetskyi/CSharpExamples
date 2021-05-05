using System.IO.Compression;

namespace V3Runner
{
    internal class Operator_BooleanLogical_Precedence_TODO
    {
        public Operator_BooleanLogical_Precedence_TODO()
        {
            NegationIsEvaluatingBeforeAnyOther();
            OthersHaveTheSamePrecedence();
            Test();
        }

        void Test()
        {
            var a = Operand(true) | Operand(true) & Operand(false);
            var b = (Operand(true) | Operand(true)) & Operand(false);
            
        }

        void OthersHaveTheSamePrecedence()
        {
            var a = Operand(true) | Operand(true) & Operand(true) ^ Operand(true);
            var b = Operand(true) ^ Operand(true) & Operand(true) | Operand(true);
            var c = Operand(true) && Operand(false) || Operand(false);
            var d = Operand(false) || Operand(true) && Operand(true);
            var e = Operand(true) ^ Operand(true) | Operand(true) & Operand(true) && Operand(false) || Operand(false);
            var f = Operand(false) || Operand(true) && Operand(true) & Operand(false) | Operand(false) ^ Operand(true);
        }

        void NegationIsEvaluatingBeforeAnyOther()
        {
            var a = !Operand(false) || Operand(true);
            var b = !Operand(true) && Operand(true);

            var operand = new Operand();
            var c = !operand | operand;
            var d = !operand & operand;
            var e = !operand ^ operand;
        }

        bool Operand(bool @bool)
        {
            return @bool;
        }
    }

    internal class Operand
    {
        public Operand()
        {
        }

        public static Operand operator !(Operand a)
        {
            return a;
        }

        public static bool operator |(Operand a, Operand b)
        {
            return true;
        }

        public static bool operator &(Operand a, Operand b)
        {
            return true;
        }

        public static bool operator ^(Operand a, Operand b)
        {
            return true;
        }

        public static bool operator true(Operand a)
        {
            return true;
        }

        public static bool operator false(Operand a)
        {
            return true;
        }
    }
}