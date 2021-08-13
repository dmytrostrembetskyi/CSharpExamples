// ReSharper disable RedundantAssignment
namespace V3Runner
{
    internal class Operator_BooleanLogical_Overloading
    {
        public Operator_BooleanLogical_Overloading()
        {
            NegationCanBeExplicitly();
            ExclusiveOrCanBeExplicitly();
            OrCanBeExplicitly();
            AndCanBeExplicitly();

            ConditionalOrIsInheritingAndRequireTrueFalseOperators();
            ConditionalAndIsInheritingAndRequireTrueFalseOperators();

            CompoundAssignmentIsInheriting();
        }

        void CompoundAssignmentIsInheriting()
        {
            var or = new Or();
            or |= new Or();

            var and = new And();
            and &= new And();

            var xor = new ExclusiveOr();
            xor ^= new ExclusiveOr();
        }

        void ConditionalAndIsInheritingAndRequireTrueFalseOperators()
        {
            var a = new ConditionalAnd();
            var b = a && a;
        }

        void ConditionalOrIsInheritingAndRequireTrueFalseOperators()
        {
            var a = new ConditionalOr();
            var b = a || a;
        }

        void AndCanBeExplicitly()
        {
            var a = new And();
            var b = a & a;
        }

        void OrCanBeExplicitly()
        {
            var a = new Or();
            var b = a | a;
        }

        void ExclusiveOrCanBeExplicitly()
        {
            var a = new ExclusiveOr();
            var b = a ^ a;
        }

        void NegationCanBeExplicitly()
        {
            var a = new Negation();
            var b = !a;
        }

        class Negation
        {
            public static Negation operator !(Negation a)
            {
                return a;
            }
        }

        class ExclusiveOr
        {
            public static ExclusiveOr operator ^(ExclusiveOr a, ExclusiveOr b)
            {
                return a;
            }
        }

        class Or
        {
            public static Or operator |(Or a, Or b)
            {
                return a;
            }
        }

        class And
        {
            public static And operator &(And a, And b)
            {
                return a;
            }
        }

        class ConditionalOr
        {
            public static ConditionalOr operator |(ConditionalOr a, ConditionalOr b)
            {
                return a;
            }

            public static bool operator true(ConditionalOr a)
            {
                return true;
            }

            public static bool operator false(ConditionalOr a)
            {
                return true;
            }
        }

        class ConditionalAnd
        {
            public static ConditionalAnd operator &(ConditionalAnd a, ConditionalAnd b)
            {
                return a;
            }

            public static bool operator true(ConditionalAnd a)
            {
                return true;
            }

            public static bool operator false(ConditionalAnd a)
            {
                return true;
            }
        }
    }
}