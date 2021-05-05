using System.Runtime.InteropServices;

namespace V3Runner
{
    internal class Operator_BooleanLogical_Precedence
    {
        public Operator_BooleanLogical_Precedence()
        {
            NegationIsBeforeAnd();
            AndIsBeforeExclusiveOr();
            ExclusiveOrIsBeforeOr();
            OrIsBeforeConditionalAnd();
            ConditionalAndIsBeforeConditionalOr();

            AllInExample();
        }

        void AllInExample()
        {
            var inPrecedenceOrder = !true & true ^ true | true && true || true;
            var inReverseOrder = true || true && true | true ^ true & !true;
        }

        void ConditionalAndIsBeforeConditionalOr()
        {
            var a = true || true && false;
            var b = (true || true) && false;
        }

        void OrIsBeforeConditionalAnd()
        {
            var a = false && true | true;
            var b = (false && true) | true;
        }

        void ExclusiveOrIsBeforeOr()
        {
            var a = true | true ^ true;
            var b = (true | true) ^ true;
        }

        void AndIsBeforeExclusiveOr()
        {
            var a = true ^ true & false;
            var b = (true ^ true) & false;
        }

        void NegationIsBeforeAnd()
        {
            var a = true & !true;
            var b = true & true;
        }
    }
}