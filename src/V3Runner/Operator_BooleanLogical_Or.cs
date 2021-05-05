namespace V3Runner
{
    internal class Operator_BooleanLogical_Or
    {
        public Operator_BooleanLogical_Or()
        {
            ReturnTrueWhenOneOfOperandIsTrue();
        }

        void ReturnTrueWhenOneOfOperandIsTrue()
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
    }
}