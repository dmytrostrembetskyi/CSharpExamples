namespace V3Runner
{
    internal class Operator_BooleanLogical_Operators
    {
        public Operator_BooleanLogical_Operators()
        {
            NegationReturnReversedValue();
            ExclusiveOrReturnTrueWhenBothOperandsAreDifferent();

            AndReturnTrueWhenAllOperandsAreTrue();
            ConditionalAndIdSimilarToAnd();

            OrReturnTrueWhenAtLeastOneOperandIsTrue();
            ConditionalOrIsSimilarToOr();
        }

        void ConditionalOrIsSimilarToOr()
        {
            var a = true || true;
            var b = false || false;
            var c = true || false;
            var d = false || true;
            var e = true || true || false;
            var f = false || false || true;
            var g = true || true || true;
            var h = false || false || false;
        }

        void ConditionalAndIdSimilarToAnd()
        {
            var a = true && true;
            var b = false && false;
            var c = true && false;
            var d = false && true;
            var e = true && true && false;
            var f = false && false && true;
            var g = true && true && true;
            var h = false && false && false;
        }

        void OrReturnTrueWhenAtLeastOneOperandIsTrue()
        {
            var a = true | true;
            var b = false | false;
            var c = true | false;
            var d = false | true;
            var e = true | true | false;
            var f = false | false | true;
            var g = true | true | true;
            var h = false | false | false;
        }

        void ExclusiveOrReturnTrueWhenBothOperandsAreDifferent()
        {
            var a = true ^ true;
            var b = false ^ false;
            var c = true ^ false;
            var d = false ^ true;
            var e = true ^ true ^ false;
            var f = false ^ false ^ true;
            var g = true ^ true ^ true;
            var h = false ^ false ^ false;
        }

        void AndReturnTrueWhenAllOperandsAreTrue()
        {
            var a = true & true;
            var b = false & false;
            var c = true & false;
            var d = false & true;
            var e = true & true & false;
            var f = false & false & true;
            var g = true & true & true;
            var h = false & false & false;
        }

        void NegationReturnReversedValue()
        {
            var a = !true;
            var b = !false;
            var c = false;
            var d = !c;
            var canReverseManyTimes = !!true;
            var canReverseALot = !!!!!!!false;
        }
    }
}