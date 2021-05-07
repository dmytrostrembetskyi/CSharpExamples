namespace V3Runner
{
    internal class Operator_TypeTesting_BasicExample
    {
        public Operator_TypeTesting_BasicExample()
        {
            ReturnTrueWhenTypeIsMatch();
        }

        void ReturnTrueWhenTypeIsMatch()
        {
            var a = "" is string;
            var d = 1 is int;

            var c = "" is int;
            var b = 1 is string;
        }
    }
}