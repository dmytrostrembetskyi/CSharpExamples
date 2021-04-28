namespace Basic.Topics.ArithmeticOperators
{
    public class CanBeUsedWithDynamic
    {
        public CanBeUsedWithDynamic()
        {
            AsInteger();
            AsString();
        }

        void AsString()
        {
            dynamic variable = "i";
            // variable++;
            // variable--;
            // var minus = -variable;
            // var plus = +variable;
            var addition = variable + variable;
            // var subtraction = variable - variable;
            // var multiplication = variable * variable;
            // var division = variable / variable;
            // var remainder = variable % variable;
        }

        void AsInteger()
        {
            dynamic variable = 8;
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
    }
}